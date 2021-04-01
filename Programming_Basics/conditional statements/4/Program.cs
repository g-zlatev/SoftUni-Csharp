using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            if (shape == "square")
            {
                double a = Double.Parse(Console.ReadLine());
                double area = a * a;
                Console.WriteLine("{0:f3}", area);
            }
            else if (shape == "rectangle")
            {
                double sideA = Double.Parse(Console.ReadLine());
                double sideB = Double.Parse(Console.ReadLine());
                double area = sideA * sideB;
                Console.WriteLine("{0:f3}", area);
            }
            else if (shape == "circle")
            {
                double radius = Double.Parse(Console.ReadLine());
                double area = Math.PI * (radius * radius);
                Console.WriteLine("{0:f3}", area);
            }
            else if(shape == "triangle")
            {
                double a = Double.Parse(Console.ReadLine());
                double h = Double.Parse(Console.ReadLine());
                double area = (a * h) / 2;
                Console.WriteLine("{0:f3}", area);
            }
        }
    }
}
