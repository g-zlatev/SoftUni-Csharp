using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal travelPrice = Decimal.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int totalCount = puzzle + dolls + bears + minions + trucks;

            decimal totalPrice = 0;
            totalPrice = puzzle * 2.6m + dolls * 3 + bears * 4.1m + minions * 8.2m + trucks * 2;
            if (totalCount >= 50)
            {
                totalPrice = totalPrice * 0.75m;
            }
            totalPrice = totalPrice * 0.9m;
            if (travelPrice <= totalPrice)
            {
                Console.WriteLine($"Yes! {0:f2} lv left.", 
                    totalPrice - travelPrice);
            }
            else
            {
                Console.WriteLine($"Not enough money! {0:f2} lv needed.", 
                    travelPrice - totalPrice);
            }

        }
    }
}
