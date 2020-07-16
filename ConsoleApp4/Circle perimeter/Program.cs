using System;

namespace Circle_perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Double pie = Math.PI;
            Double r = Double.Parse(Console.ReadLine());
            Double area = pie * r * r;
            Double perimeter = 2 * pie * r;
            //Console.WriteLine ("{0:f2}", area);
            //Console.WriteLine("{0:f2}", perimeter);
            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perimeter:f2}");
        }
    }
}
