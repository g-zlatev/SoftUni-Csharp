using System;
using System.Text;

namespace RomanNumeralConvertor
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number between 0 and 3999...");
            int num = int.Parse(Console.ReadLine());
            int tempNum = num;

            StringBuilder sb = new StringBuilder();

            while (tempNum > 0)
            {
                if (tempNum >= 1000)
                {
                    sb.Append("M");
                    tempNum -= 1000;
                }
                else if (tempNum >= 900)
                {
                    sb.Append("CM");
                    tempNum -= 900;
                }
                else if (tempNum >= 500)
                {
                    sb.Append("D");
                    tempNum -= 500;
                }
                else if (tempNum >= 400)
                {
                    sb.Append("CD");
                    tempNum -= 400;
                }
                else if (tempNum >= 100)
                {
                    sb.Append("C");
                    tempNum -= 100;
                }
                else if (tempNum >= 90)
                {
                    sb.Append("XC");
                    tempNum -= 90;
                }
                else if (tempNum >= 50)
                {
                    sb.Append("L");
                    tempNum -= 50;
                }
                else if (tempNum >= 40)
                {
                    sb.Append("XL");
                    tempNum -= 40;
                }
                else if (tempNum >= 10)
                {
                    sb.Append("X");
                    tempNum -= 10;
                }
                else if (tempNum >= 9)
                {
                    sb.Append("IX");
                    tempNum -= 9;
                }
                else if (tempNum >= 5)
                {
                    sb.Append("V");
                    tempNum -= 5;
                }
                else if (tempNum >= 4)
                {
                    sb.Append("IV");
                    tempNum -= 4;
                }
                else if (tempNum >= 1)
                {
                    sb.Append("I");
                    tempNum -= 1;
                }
            }

            Console.WriteLine($"{num} is: {sb}");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
