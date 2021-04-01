using System;

namespace Fishing_boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermenNumber = int.Parse(Console.ReadLine());

            decimal price = 0.0m;

            switch (season)
            {
                case "Spring": price = 3000; break;
                case "Summer":
                case "Autumn": price = 4200; break;
                case "Winter": price = 2600; break;
            }

            if (fishermenNumber <= 6)
            {
                price -= price * 0.1m;
            }
            else if (fishermenNumber <= 11)
            {
                price -= price * 0.15m;
            }
            else 
            {
                price -= price * 0.25m;
            }

            if ((fishermenNumber % 2 == 0) && season != "Autumn")
            {
                price -= price * 0.05m;
            }

            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }
        }
    }
}
