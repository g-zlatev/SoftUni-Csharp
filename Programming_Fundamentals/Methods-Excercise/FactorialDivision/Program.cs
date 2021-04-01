﻿using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double result = GetFactorial(num1) / GetFactorial(num2);
            Console.WriteLine($"{result:f2}");
        }

        private static double GetFactorial(double num)
        {
            double factorial = num;
       
            for (double i = num; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
