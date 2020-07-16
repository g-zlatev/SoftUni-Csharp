using System;

namespace water_overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentLiters = 0;
            int maxCapacity = 255;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                //currentLiters += liters;

                //if (currentLiters > 255)
                //{
                //    Console.WriteLine("Insufficient capacity!");
                //    currentLiters -= liters;
                //    continue;
                //}

                if (liters + currentLiters <= maxCapacity)
                {
                    currentLiters += liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }
            Console.WriteLine($"{currentLiters}");

        }
    }
}
