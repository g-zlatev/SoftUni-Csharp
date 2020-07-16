using System;

namespace max_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            int currentMin = int.MaxValue;
            while (counter < n)
            {
                int nextNum = int.Parse(Console.ReadLine());
                if (nextNum < currentMin)
                {
                    currentMin = nextNum;
                }
                counter++;
            }
            Console.WriteLine(currentMin);
        }
    }
}
