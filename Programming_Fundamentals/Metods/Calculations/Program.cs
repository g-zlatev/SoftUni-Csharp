using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (input == "add")
            {
                AddNums(num1, num2);
            }
            else if (input == "multiply")
            {
                MultiplyNums(num1, num2);
            }
            else if (input == "substract")
            {
                SubstractNums(num1, num2);
            }
            else if (input == "divide")
            {
                DivideNums(num1, num2);
            }



        }
        static void AddNums(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        static void MultiplyNums(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
        static void SubstractNums(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        static void DivideNums(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
