using System;

namespace max_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currentMax = int.MinValue;
            while (n > 0)
            {
                int nextNum = int.Parse(Console.ReadLine());
                if (nextNum > currentMax)
                {
                    currentMax = nextNum;
                }
                n--;
            }
            Console.WriteLine(currentMax);
        }
    }
}
