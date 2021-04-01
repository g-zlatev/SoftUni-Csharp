using System;

namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            PrintTriangle(count);

        }
        static void PrintTriangle(int n)
        {
            PrintTopPart(n);
            PrintBottomPart(n);

        }
        static void PrintTopPart(int num)
        {
            for (int counter = 1; counter <= num; counter++)
            {
                for (int i = 1; i <= counter; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

        }
        static void PrintBottomPart(int num)
        {
            for (int counter = num; counter >= 1; counter--)
            {
                for (int i = 1; i < counter; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
