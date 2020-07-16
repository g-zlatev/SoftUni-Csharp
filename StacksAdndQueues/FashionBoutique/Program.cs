using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothesInBox = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> clothes = new Stack<int>(clothesInBox);

            int currentRack = rackCapacity;
            //int sum = 0;
            int rackCounter = 1;

            while (clothes.Any())
            {
                if ((currentRack - clothes.Peek()) >= 0)
                {
                    currentRack -= clothes.Pop();
                }

                else
                {
                    rackCounter++;
                    currentRack = rackCapacity;
                }
            }

            //while (clothes.Any())
            //{
            //    sum += clothes.Peek();
            //    if (sum <= rackCapacity)
            //    {
            //        clothes.Pop();
            //    }
            //    else
            //    {
            //        rackCounter++;
            //        sum = 0;

            //    }

            //}

            Console.WriteLine(rackCounter);

        }
    }
}
