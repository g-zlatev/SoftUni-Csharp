using System;

namespace MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmp = int.Parse(Console.ReadLine());
            int secondEmp = int.Parse(Console.ReadLine());
            int thirdEmp = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            int hours = 0;
            int totalPeoplePeeHour = firstEmp + secondEmp + thirdEmp;

            while (peopleCount > 0)
            {
                peopleCount -= totalPeoplePeeHour;
                hours++;
                if (hours % 4 == 0)
                {
                    hours++;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");

        }
    }
}
