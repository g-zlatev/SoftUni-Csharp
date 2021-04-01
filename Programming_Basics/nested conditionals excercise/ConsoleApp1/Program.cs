using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string lodging = "";
            decimal price = 0.0m;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    lodging = "Camp";
                    price = budget * 0.3m;
                }
                else if (season == "winter")
                {
                    lodging = "Hotel";
                    price = budget * 0.7m;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    lodging = "Camp";
                    price = budget * 0.4m;
                }
                else if (season == "winter")
                {
                    lodging = "Hotel";
                    price = budget * 0.8m;
                }
            }
            else
            {
                destination = "Europe";
                lodging = "Hotel";
                price = budget * 0.9m;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{lodging} - {price:f2}");
        }
    }
}
