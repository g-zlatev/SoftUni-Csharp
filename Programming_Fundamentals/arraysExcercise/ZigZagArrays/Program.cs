using System;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr1 = new string[n];
            string[] arr2 = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] current = Console.ReadLine().Split();
                if (i % 2 == 0)
                {
                    arr1[i] = current[0];
                    arr2[i] = current[1];
                }
                else
                {
                    arr2[i] = current[0];
                    arr1[i] = current[1];
                }

            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));

            //foreach (var item in arr1)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine();

            //foreach (var item in arr2)
            //{
            //    Console.Write(item + " ");
            //}
        }
    }
}
