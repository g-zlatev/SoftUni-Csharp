using System;

namespace MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int num1 = 1; num1 <= (num % 10); num1++)
            {
                for (int num2 = 1; num2 <= (num % 100 / 10); num2++)
                {
                    for (int num3 = 1; num3 <= (num % 1000 / 100); num3++)
                    {
                        Console.WriteLine($"{num1} * {num2} * {num3} = {num1 * num2 * num3};");
                    }
                }
            }
        }
    }
}
