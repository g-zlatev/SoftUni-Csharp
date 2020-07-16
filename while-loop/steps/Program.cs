using System;

namespace steps
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;

            while (true)
            {
                string input = Console.ReadLine();
                int steps = 0;
                if (input == "Going home")
                {
                    steps = int.Parse(Console.ReadLine());
                    totalSteps += steps;
                    break;
                }
                else
                {
                    steps = int.Parse(input);
                }

                totalSteps += steps;
                if (totalSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }
                
                
                
                
                else
                {
                    Console.WriteLine($"{10000-totalSteps} more steps to reach goal.");
                    break;
                }
            }

        }
    }
}
