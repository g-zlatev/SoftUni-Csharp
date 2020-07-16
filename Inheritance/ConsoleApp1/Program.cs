using System;

namespace OddEvenSumm1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven += number;
                }

                if (i % 2 != 0)
                {
                    sumOdd += number;
                }
            }

            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumEven}");
            }

            else if (sumEven != sumOdd)
            {
                double finsum = sumEven - sumOdd;

                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(finsum)}");
            }
        }
    }
}