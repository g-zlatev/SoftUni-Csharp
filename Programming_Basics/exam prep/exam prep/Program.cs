using System;

namespace exam_prep
{
    class Program
    {
        static void Main(string[] args)
        {
            double lemonQuantity = double.Parse(Console.ReadLine());
            double sugarQuantity = double.Parse(Console.ReadLine());
            double waterQuantity = double.Parse(Console.ReadLine());

            double totalQuantity = lemonQuantity * 980 + waterQuantity*1000;
            totalQuantity += sugarQuantity * 0.3;
            int cups = (int)(totalQuantity / 150);
            decimal price = cups * 1.2m;

            Console.WriteLine($"All cups sold: {cups}");
            Console.WriteLine($"Money earned: {price:f2}");
        }
    }
}
