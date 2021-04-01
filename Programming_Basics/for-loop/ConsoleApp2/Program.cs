using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());
                sum += b;
                //sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
