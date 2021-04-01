using System;

namespace Yard_greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double sqMeter = double.Parse(Console.ReadLine());
            //double price = 7.61;
            //double discount = 0.18;

            Double Price = sqMeter * 7.61;
            Double Discount = 0.18 * Price;
            Double finalPrice = Price - Discount;

            Console.WriteLine("The final price is: " + $"{finalPrice:f2}" + " lv.");
            Console.WriteLine("The discount is: " + $"{Discount:f2}" + " lv.");
        }
    }
}
