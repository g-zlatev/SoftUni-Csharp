using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            List<string> furnutureName = new List<string>();
            double price = 0;
            //int quantity = 0;
            string pattern = @">>([A-Za-z]+)<<([0-9]+\.?[0-9]*)!([0-9]+)";
            //Regex regex = new Regex(pattern);

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    price += double.Parse(match.Groups[2].Value) * int.Parse(match.Groups[3].Value);
                    furnutureName.Add(name);
                }

            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in furnutureName)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {price:f2}");
        }
    }
}
