using System;

namespace Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengers = int.Parse(Console.ReadLine());
            int stops = int.Parse(Console.ReadLine());

            for (int i = 1; i <= stops; i++)
            {
                passengers -= int.Parse(Console.ReadLine());
                passengers += int.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    passengers += 2;
                }
                else
                {
                    passengers -= 2;
                }

            }
                Console.WriteLine($"The final number of passengers is : {passengers}");
        }
    }
}
