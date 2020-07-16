using System;

namespace exam_preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedThreshold = int.Parse(Console.ReadLine());
            int badGrades = 0;
            int problemsDone = 0;
            int grade;
            string problemName = "";
            double gradeSum = 0;
            string lastProblem = "";

            while (badGrades < failedThreshold)
            {
                problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    Console.WriteLine($"Average score: {gradeSum / problemsDone:f2}");
                    Console.WriteLine($"Number of problems: {problemsDone}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }
                grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    badGrades++;
                }
                gradeSum += grade;
                problemsDone++;
                lastProblem = problemName;
            }
            if (badGrades == failedThreshold)
            {
                Console.WriteLine($"You need a break, {failedThreshold} poor grades.");
            }
        }
    }
}
