using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            while (steps < 10000)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    steps += int.Parse(Console.ReadLine());
                    if (steps >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                    }
                    else
                    {
                        int diff = 10000 - steps;
                        Console.WriteLine($"{diff} more steps to reach goal.");
                        break;
                    }
                }
                else
                {
                steps += int.Parse(input);
                    if (steps >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                    }
                }
            }
        }
    }
}
