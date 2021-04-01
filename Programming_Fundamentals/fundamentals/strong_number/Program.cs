using System;

namespace strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int tempNum = num;
            int totalSum = 0;
            while (tempNum > 0)
            {
                int digit = tempNum % 10;
                tempNum /= 10;
                int currentFactoriaSum = 1;

                for (int i = 1; i <= digit; i++)
                {
                    currentFactoriaSum *= i;
                }
                totalSum += currentFactoriaSum;
            }
            if (totalSum == num)
            {
            Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
