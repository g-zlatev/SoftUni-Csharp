namespace BookShop.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using BookShop.Data.Models;
    using BookShop.Data.Models.Enums;
    using BookShop.DataProcessor.ImportDto;
    using Data;
    using Newtonsoft.Json;
    using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedBook
            = "Successfully imported book {0} for {1:F2}.";

        private const string SuccessfullyImportedAuthor
            = "Successfully imported author - {0} with {1} books.";

        public static string ImportBooks(BookShopContext context, string xmlString)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportBooksDto[]), new XmlRootAttribute("Books"));

            using (StringReader stringReader = new StringReader(xmlString))
            {
                ImportBooksDto[] bookDtos = (ImportBooksDto[])xmlSerializer.Deserialize(stringReader);

                var sb = new StringBuilder();
                var validBooks = new List<Book>();

                foreach (var book in bookDtos)
                {

                    if (!IsValid(book))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    //var date = DateTime.ParseExact(book.PublishedOn, "MM/dd/yyyy", CultureInfo.InvariantCulture);

                    DateTime date;
                    var isValidDate = DateTime.TryParseExact(book.PublishedOn, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);

                    if (!isValidDate)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    var bookToAdd = new Book()
                    {
                        Name = book.Name,
                        Genre = Enum.Parse<Genre>(book.Genre),
                        Price = book.Price,
                        Pages = book.Pages,
                        PublishedOn = date
                    };

                    validBooks.Add(bookToAdd);
                    sb.AppendLine(String.Format(SuccessfullyImportedBook, book.Name, book.Price));
                }

                context.Books.AddRange(validBooks);
                context.SaveChanges();
                return sb.ToString().TrimEnd();
            };

        }

        public static string ImportAuthors(BookShopContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var authorsDto = JsonConvert.DeserializeObject<ICollection<ImportAutorDto>>(jsonString);

            var validAuthors = new List<Author>();

            foreach (var currAuthor in authorsDto)
            {
                if (!IsValid(currAuthor))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                //var authorExistsInDb = context.Authors.Any(x => x.Email == currAuthor.Email);
                var authorExistsInList = validAuthors.Any(x => x.Email == currAuthor.Email);

                if (authorExistsInList)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var authorToAdd = new Author
                {
                    FirstName = currAuthor.FirstName,
                    LastName = currAuthor.LastName,
                    Phone = currAuthor.Phone,
                    Email = currAuthor.Email,
                };

                foreach (var book in currAuthor.Books)
                {
                    if (!book.Id.HasValue)
                    {
                        continue;
                    }

                    var bookExists = context.Books.FirstOrDefault(x => x.Id == book.Id);
                    //var bookExists = context.Books.Any(x => x.Id == book.Id);

                    if (bookExists == null)
                    {
                        continue;
                    }

                    authorToAdd.AuthorsBooks.Add(new AuthorBook
                    {
                        Author = authorToAdd,
                        Book = bookExists
                    });

                }

                if (authorToAdd.AuthorsBooks.Count == 0)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                validAuthors.Add(authorToAdd);
                sb.AppendLine(String.Format(SuccessfullyImportedAuthor, authorToAdd.FirstName + " " + authorToAdd.LastName, authorToAdd.AuthorsBooks.Count));

            }

            context.Authors.AddRange(validAuthors);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}