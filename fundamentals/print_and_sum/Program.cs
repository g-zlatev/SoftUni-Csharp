using System;

namespace print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
                Console.Write(i + " ");
            }
            //Console.WriteLine(); - can be used for a new line
            Console.WriteLine($"\nSum: {sum}");

        }
    }
}
