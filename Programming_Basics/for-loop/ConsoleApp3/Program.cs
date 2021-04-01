﻿using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            for (int i = 0; i < n; i++)
            {
                leftSum = leftSum + int.Parse(Console.ReadLine());
            }

            int rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                rightSum = rightSum + int.Parse(Console.ReadLine());
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum-rightSum)}");
            }
        }
    }
}