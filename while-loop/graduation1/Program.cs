using System;

namespace graduation1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int currentClass = 1;
            double sumGrades = 0;
            while (currentClass <= 12)
            {
                Double currentGrade = double.Parse(Console.ReadLine());
                if (currentGrade >= 4)
                {
                    currentClass++;
                    sumGrades += currentGrade;
                }
            }
            Console.WriteLine($"{name} graduated. Average grade: {sumGrades / 12:f2}");
        }
    }
}
