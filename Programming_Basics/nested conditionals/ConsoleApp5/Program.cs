﻿using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            
            double price = 0;

            if (day == "Monday" || day== "Tuesday" || day == "Wednesday" || day == "Thursday" || day =="Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = quantity * 2.70; break;
                    case "apple":
                        price = quantity * 1.20; break;
                    case "orange":
                        price = quantity * 0.85; break;
                    case "grapefruit":
                        price = quantity * 1.45; break;
                    case "kiwi":
                        price = quantity * 2.70; break;
                    case "pineapple":
                        price = quantity * 5.50; break;
                    case "grapes":
                        price = quantity * 3.85; break;
                    default:
                        break;

                }
            }
            else if (true)
            {

            }
        }
    }
}
