using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "end")
            {
                if (input.Length > 1)
                {
                    Wagons.Add(int.Parse(input[1]));
                }
                else
                {
                    for (int i = 0; i < Wagons.Count; i++)
                    {
                        if (Wagons[i] + int.Parse(input[0]) <= maxCapacity)
                        {
                            Wagons[i] += int.Parse(input[0]);
                            break;
                        }
                    }
                }

                input = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(" ",Wagons));
        }

    }
}
