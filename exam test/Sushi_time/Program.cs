using System;

namespace Sushi_time
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushiType = Console.ReadLine();
            string restaurantName = Console.ReadLine();
            int portions = int.Parse(Console.ReadLine());
            char delivery = char.Parse(Console.ReadLine());

            double price = 0;
            switch (restaurantName)
            {
                case "Sushi Zone":
                    switch (sushiType)
                    {
                        case "sashimi":
                            price = 4.99;
                            break;
                        case "maki":
                            price = 5.29;
                            break;
                        case "uramaki":
                            price = 5.99;
                            break;
                        case "temaki":
                            price = 4.29;
                            break;
                    }
                    break;
                case "Sushi Time":
                    switch (sushiType)
                    {
                        case "sashimi":
                            price = 5.49;
                            break;
                        case "maki":
                            price = 4.69;
                            break;
                        case "uramaki":
                            price = 4.49;
                            break;
                        case "temaki":
                            price = 5.19;
                            break;
                    }
                    break;
                case "Sushi Bar":
                    switch (sushiType)
                    {
                        case "sashimi":
                            price = 5.25;
                            break;
                        case "maki":
                            price = 5.55;
                            break;
                        case "uramaki":
                            price = 6.25;
                            break;
                        case "temaki":
                            price = 4.75;
                            break;
                    }
                    break;
                case "Asian Pub":
                    switch (sushiType)
                    {
                        case "sashimi":
                            price = 4.5;
                            break;
                        case "maki":
                            price = 4.8;
                            break;
                        case "uramaki":
                            price = 5.5;
                            break;
                        case "temaki":
                            price = 5.5;
                            break;
                    }
                    break;
                default:
                    Console.WriteLine($"{restaurantName} is invalid restaurant!");
                    return;
            }
            double totalSushiPrice = price * portions;
            if (delivery == 'Y')
            {
                totalSushiPrice += totalSushiPrice * 0.2;
            }
            Console.WriteLine($"Total price: {Math.Ceiling(totalSushiPrice)} lv.");

        }
    }
}
