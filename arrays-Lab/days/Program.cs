using System;

namespace days
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.Write("Enter a number (1-7): ");
            int dayInNum = int.Parse(Console.ReadLine());
            if (dayInNum > 0 && dayInNum < 8)
            {
            Console.WriteLine($"The day is {days[dayInNum-1]}");
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
