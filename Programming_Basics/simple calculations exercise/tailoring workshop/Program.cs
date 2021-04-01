using System;

namespace tailoring_workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double tableClothArea = tables * (length + 2 * 0.30) * (width + 2 * 0.30);
            double kareArea = tables * (length / 2) * (length / 2);

            Double tableClothPrice = tableClothArea * 7;
            Double karePrice =  kareArea * 9;
            double tableClothPriceBgn = tableClothPrice * 1.85;
            double karePriceBgn = karePrice * 1.85;

            Console.WriteLine($"{tableClothPrice + karePrice:f2}" + " USD");
            Console.WriteLine($"{tableClothPriceBgn + karePriceBgn:f2}" + " BGN");
        }
    }
}
