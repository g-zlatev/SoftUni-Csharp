using System;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetSubtract(GetSum(num1, num2), num3));
        }

        private static int GetSum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;

        }
        static int GetSubtract(int num1, int num2) 
        {
            int result = num1 - num2;
            return result;
        }

    }
}
