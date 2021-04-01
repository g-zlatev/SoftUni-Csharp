using System;

namespace Exam_prep
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
            int gradeSum = 0;
            double averageGrade = gradeSum / problemsDone;
            string lastProblem = "";

            while (badGrades < failedThreshold)
            {
                problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    Console.WriteLine($"Average score: {averageGrade:f2}");
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
