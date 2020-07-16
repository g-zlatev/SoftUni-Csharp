using System;
using System.Linq;

namespace arraysExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());

            int[] train = new int[wagons];

            for (int i = 0; i < train.Length; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
            }

           
                Console.WriteLine(String.Join(" ", train));
                Console.WriteLine(train.Sum());
        }
    }
}
