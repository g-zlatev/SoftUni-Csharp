using System;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            decimal price = 0.00m;
            int hallSize = row * columns;

            switch (type)
            {
                case "Premiere": price = hallSize * 12; break;
                case "Normal": price = hallSize * 7.5m; break;
                case "Discount": price = hallSize * 5; break;

            }
            Console.WriteLine($"{price:f2} leva");

        }
    }
}
