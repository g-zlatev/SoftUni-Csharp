using System;

namespace radians_to_degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Double rad = Double.Parse(Console.ReadLine());
            Double deg = rad * 180 / Math.PI;

            Console.WriteLine(Math.Round(deg));
        }
    }
}
