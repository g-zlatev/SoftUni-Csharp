namespace BookShop.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;
    using BookShop.DataProcessor.ExportDto;
    using Data;
    using Newtonsoft.Json;
    using Formatting = Newtonsoft.Json.Formatting;

    public class Serializer
    {
        public static string ExportMostCraziestAuthors(BookShopContext context)
        {
            var authors = context.Authors.Select(x => new
            {
                AuthorName = x.FirstName + ' ' + x.LastName,
                Books = x.AuthorsBooks
                .OrderByDescending(ab => ab.Book.Price)
                .Select(b => new
                {
                    BookName = b.Book.Name,
                    BookPrice = b.Book.Price.ToString("F2")
                })
                .ToList()
                //.OrderByDescending(y => y.BookPrice)
            })
                .ToList()
                .OrderByDescending(a => a.Books.Count())
                .ThenBy(a => a.AuthorName)
                .ToList();

            var jsonResult = JsonConvert.SerializeObject(authors, Formatting.Indented);

            return jsonResult;
        }

        public static string ExportOldestBooks(BookShopContext context, DateTime date)
        {
            var sb = new StringBuilder();


            var books = context.Books
                .Where(x => x.PublishedOn < date)
                .Where(x => x.Genre == Data.Models.Enums.Genre.Science)
                .ToList()
                .OrderByDescending(x => x.Pages)
                .ThenByDescending(x => x.PublishedOn)
                .Select(b => new ExportBookDto
                {
                    Name = b.Name,
                    Date = b.PublishedOn.ToString("d", CultureInfo.InvariantCulture),
                    Pages = b.Pages
                })
                .ToList();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<ExportBookDto>), new XmlRootAttribute("Books"));

            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            using (StringWriter stringWriter = new StringWriter(sb))
            {
                xmlSerializer.Serialize(stringWriter, books, namespaces);
            }

            return sb.ToString().TrimEnd();
        }
    }
}