using System;

namespace sum_of_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginning = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i < beginning; i++)
            {
                for (int j = 1; j < end; j++)
                {
                    if (i + j == number)
                    {
                        Console.WriteLine(counter);
                    }
                    else
                    {
                        counter++;
                    }
                }
            }
        }
    }
}
