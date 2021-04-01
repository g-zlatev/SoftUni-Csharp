using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>();
            List<Product> productsList = new List<Product>();

            var people = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var products = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            try
            {
                foreach (var personkvp in people)
                {
                    var token = personkvp.Split("=", StringSplitOptions.RemoveEmptyEntries).ToArray();

                    var name = token[0];
                    var money = decimal.Parse(token[1]);
                    var person = new Person(name, money);

                    peopleList.Add(person);
                }


                foreach (var productKvp in products)
                {
                    var token = productKvp.Split("=", StringSplitOptions.RemoveEmptyEntries).ToArray();

                    var name = token[0];
                    var money = decimal.Parse(token[1]);
                    var product = new Product(name, money);

                    productsList.Add(product);
                }

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                Environment.Exit(0);
            }


            BuyProducts(peopleList, productsList);


            foreach (var person in peopleList)
            {
                Console.WriteLine(person.ToString());
            }

        }

        private static void BuyProducts(List<Person> peopleList, List<Product> productsList)
        {
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                var commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string personName = commandArgs[0];
                string productName = commandArgs[1];

                try
                {
                    Person person = peopleList.FirstOrDefault(p => p.Name == personName);
                    Product product = productsList.FirstOrDefault(p => p.Name == productName);

                    person.AddProduct(product);

                    Console.WriteLine($"{person.Name} bought {product.Name}");

                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }
        }
    }
}
