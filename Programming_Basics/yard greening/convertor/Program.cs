using System;

namespace convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            Double usd = Double.Parse(Console.ReadLine());
            Double bgn = usd * 1.79549;

            Console.WriteLine($"{bgn:f2}");
        }
    }
}
