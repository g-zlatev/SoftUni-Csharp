using System;

namespace Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiteBreadPrice = double.Parse(Console.ReadLine());
            int whiteBreadQuantity = int.Parse(Console.ReadLine());
            int wholegrainBreadQuantity = int.Parse(Console.ReadLine());
            int pretzelsQuantity = int.Parse(Console.ReadLine());
            int croisantsQuantity = int.Parse(Console.ReadLine());
            string holidayOrNot = Console.ReadLine();

            double wholeGrainPrice = whiteBreadPrice * 1.2;
            double pretzelPrice = wholeGrainPrice * 0.8;
            double croisantPrice = pretzelPrice + 1.5;
            double miniCakePrice = whiteBreadPrice * 0.8;
            double dounutPrice = miniCakePrice * 0.45;

            double totalWhiteBreadPrice = whiteBreadQuantity * whiteBreadPrice;
            double totalWholeGrainPrice = wholegrainBreadQuantity * wholeGrainPrice;
            double totalPretzelPrice = pretzelsQuantity * pretzelPrice;
            double totalCroisantPrice = croisantsQuantity * croisantPrice;


            if (holidayOrNot == "yes")
            {
                int miniCakesQuantity = int.Parse(Console.ReadLine());
                int donutsQuantity = int.Parse(Console.ReadLine());
                double totalCakePrice = miniCakesQuantity * miniCakePrice;
                double totalDonutPrice = donutsQuantity * dounutPrice;

                Console.WriteLine($"Happy holidays! This will cost you {totalCakePrice+totalCroisantPrice+totalDonutPrice+totalPretzelPrice+totalWhiteBreadPrice+totalWholeGrainPrice:f2} lv.");
            }
            else if (holidayOrNot == "no")
            {
                Console.WriteLine($"The value of you order is {totalWhiteBreadPrice+totalWholeGrainPrice+totalPretzelPrice+totalCroisantPrice:f2} lv.");
            }
        }
    }
}
