using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            SumFirstAndLast(list);

        }

        private static void SumFirstAndLast(List<int> list)
        {
            int orignalLength = list.Count;
            for (int i = 0; i < orignalLength / 2; i++)
            {
                list[i] += list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
            }
            Console.WriteLine(string.Join(" ", list));



            //for (int i = 0; i < list.Count / 2; i++)
            //{
            //    Console.Write(list[i] + list[list.Count - 1 - i] + " ");

            //}
            //if (list.Count % 2 == 1)
            //{
            //    Console.Write(list.Count / 2 + 1);
            //}
        }

    }

}
