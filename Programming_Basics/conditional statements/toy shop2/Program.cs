using System;

namespace toy_shop2
{
    class Program
    {
        static void Main(string[] args)
        {
            double travelPrice = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double puzzlePrice = puzzle * 2.6;
            double dollsPrice = dolls * 3;
            double bearsPrice = bears * 4.1;
            double minionsPrice = minions * 8.2;
            double trucksPrice = trucks * 2;

            int toyQuantity = puzzle + dolls + bears + minions + trucks;
            double toyPrice = puzzlePrice + dollsPrice + bearsPrice + minionsPrice + trucksPrice;
            double discount = 0.0;

            if (toyQuantity >= 50)
            {
                discount = toyPrice * 0.25;
            }

            double totalPrice = toyPrice - discount;
            totalPrice = totalPrice - (totalPrice * 0.10);

            if (totalPrice > travelPrice)
            {
                Console.WriteLine("Yes! {0:f2} lv left.", totalPrice - travelPrice);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:f2} lv needed.", travelPrice - totalPrice);
            }
        }
    }
}
