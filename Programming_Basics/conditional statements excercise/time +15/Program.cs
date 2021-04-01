using System;

namespace time__15
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHours = int.Parse(Console.ReadLine());
            int startMinutes = int.Parse(Console.ReadLine());

            int timeInMinutes = startHours * 60 + startMinutes;
            int timePlus15 = timeInMinutes + 15;

            int finalHours = timePlus15 / 60;
            int finalMinutes = timePlus15 % 60;
            if (finalHours >= 24)
            {
                finalHours = finalHours - 24;
            }
            if (finalMinutes<10)
            {
                Console.WriteLine($"{finalHours}:0{finalMinutes}");
            }
            else
            {
                Console.WriteLine($"{finalHours}:{finalMinutes}");
            }
        }
    }
}
