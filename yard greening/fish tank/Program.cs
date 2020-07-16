using System;

namespace fish_tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Double percentInput = Double.Parse(Console.ReadLine());

            Double percent = percentInput * 0.01;
            int tankVolume = length * width * height;
            Double liters = tankVolume * 0.001;
            Double totalLiters = liters * (1-percent);

            Console.WriteLine($"{totalLiters:f3}");
        }
    }
}
