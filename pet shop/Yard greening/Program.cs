using System;

namespace Yard_greening
{
    class Program
    {
        static void Main(string[] args)
        {
            int sqMeter = int.Parse(Console.ReadLine());
            double price = 7.61;
            double discount = 0.18;

            Double finalPrice = sqMeter * price;
            Double priceWithDiscount =  discount * finalPrice;
            Double finalDiscount = finalPrice - priceWithDiscount;

            Console.WriteLine("The final price is: " + $"{finalDiscount:f2}" + " lv.");
            Console.WriteLine("The discount is: " + $"{priceWithDiscount:f2}" + " lv.");
        }
    }
}
