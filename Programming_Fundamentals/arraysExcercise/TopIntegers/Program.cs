using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string result = " ";

            for (int i = 0; i < arr.Length; i++)
            {
                int current = arr[i];

                arr.Where(x => x == current);
            }
            Console.WriteLine(result);

        }
    }
}
