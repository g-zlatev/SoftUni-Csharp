﻿using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    sum = arr[i] + arr[j];
                    if (sum == num)
                    {
                        result += arr[i] + " " + arr[j] + Environment.NewLine;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
