using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> pumps = new Queue<int[]>();

            FillQueue(n, pumps);

            int smallestIndex = 0;

            while (true)
            {
                int fuelAmount = 0;
                bool foundStartPoint = true;

                for (int i = 0; i < n; i++)
                {
                    var currentPump = pumps.Dequeue();
                    fuelAmount += currentPump[0];

                    if (fuelAmount < currentPump[1])
                    {
                        foundStartPoint = false;
                    }

                    fuelAmount -= currentPump[1];
                    pumps.Enqueue(currentPump);
                }
                if (foundStartPoint)
                {
                    break;
                }

                smallestIndex++;

                pumps.Enqueue(pumps.Dequeue());
            }

            Console.WriteLine(smallestIndex);

        }

        private static void FillQueue(int n, Queue<int[]> pumps)
        {
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                pumps.Enqueue(input);
            }
        }
    }
}
