using System;

namespace Project_creation
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            int projectNumber = int.Parse(Console.ReadLine());
            int hours = projectNumber * 3;
            Console.WriteLine($"The architect {name} will need {hours} hours to complete {projectNumber} project/s.");
        }
    }
}
