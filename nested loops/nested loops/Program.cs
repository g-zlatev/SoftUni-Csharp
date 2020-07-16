using System;

namespace nested_loops
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int h = 0; h <= 24; h++)
            {
                for (int m = 0; m <= 59; m++)
                {
                    Console.WriteLine($"{h}:{m}");
                }
            }
        }
    }
}
