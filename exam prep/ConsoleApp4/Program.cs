using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            decimal dayLimit = 60;

            for (int currentDay = 0; currentDay < days; currentDay++, dayLimit += 60)
            {
                int productCount = 0;
                while (true)
                {
                    string command = Console.ReadLine();
                    if (command == "Day over")
                    {
                        Console.WriteLine($"Money left from today: {dayLimit:f2}. You've bought {productCount} products.");
                        break;
                    }
                    decimal price = decimal.Parse(command);
                    if (dayLimit >= price)
                    {
                        dayLimit -= price;
                        productCount++;
                        if (dayLimit == 0)
                        {
                            Console.WriteLine("Daily limit exceeded! You've bought {0} products.", productCount);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Daily limit exceeded! You've bought {0} products.", productCount);
                        break;
                    }
                }


            }
        }
    }
}
