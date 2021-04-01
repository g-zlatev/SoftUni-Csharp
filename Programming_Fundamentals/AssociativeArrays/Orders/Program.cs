using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> allPrices = new Dictionary<string, double>();
            Dictionary<string, int> allQuantities  = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "buy")
            {
                string productName = input[0];
                double productPrice = double.Parse(input[1]);
                int productQuantity = int.Parse(input[2]);

                if (!allPrices.ContainsKey(productName))
                {
                    allPrices.Add(productName, productPrice);
                    allQuantities.Add(productName, productQuantity);
                }
                else
                {
                    allQuantities[productName] += productQuantity;
                    if (allPrices[productName] != productPrice)
                    {
                        allPrices[productName] = productPrice;
                    }
                }

                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in allPrices)
            {
                double totalPrice = item.Value * allQuantities[item.Key];

                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}
