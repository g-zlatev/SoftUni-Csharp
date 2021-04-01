using System;

namespace Methods_Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            GetSmallestInt(num1, num2, num3);
        }
        static void GetSmallestInt(int num1, int num2, int num3)
        {
            int result = int.MaxValue;
          
            if (num1 < result)
            {
                result = num1;
            }
            if (num2 < result)
            {
                result = num2;
            }
            if (num3 < result)
            {
                result = num3;
            }


            Console.WriteLine(result);
        }

    }
}
