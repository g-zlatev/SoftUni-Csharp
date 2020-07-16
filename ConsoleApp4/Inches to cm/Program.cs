using System;

namespace Inches_to_cm
{
    class Program
    {
        static void Main(string[] args)
        {
            Double inch = Double.Parse(Console.ReadLine());
            Double cm = inch * 2.54;
            Console.WriteLine(cm);

        }
    }
}
