using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cruiseType = Console.ReadLine();
            string cabinType = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            decimal price = 0;

            switch (cruiseType)
            {
                case "Mediterranean":
                    if (cabinType == "standard cabin")
                    {
                        price = 27.5m;
                    }
                    else if (cabinType == "cabin with balcony")
                    {
                        price = 30.2m;

                    }
                    else
                    {
                       price = 40.5m;
                    }
                    break;
                case "Adriatic":
                    switch (cabinType)
                    {
                        case "standard cabin": 
                            price = 22.99m;
                            break;
                        case "cabin with balcony":
                            price = 25m;
                            break;
                        case "apartment":
                            price = 34.99m;
                            break;
                        
                        default:
                            break;
                    }
                    break;
                case "Aegean":
                    switch (cabinType)
                    {
                        case "standard cabin":
                            price = 23m;
                            break;
                        case "cabin with balcony":
                            price = 26.6m;
                            break;
                        case "apartment":
                            price = 39.8m;
                            break;

                        default:
                            break;
                    }

                    break;

                default:
                    break;
            }
            if (days > 7)
            {
                price *= 0.75m;
            }
            decimal totalPrice = days * 4 * price;
            Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {totalPrice:f2} lv.");

        }
    }
}
