using System;

namespace Airplane_seats
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengers = int.Parse(Console.ReadLine());

            double windowSeats = 0;
            double middleSeats = 0;
            double isleSeats = 0;

            for (int i = 0; i < passengers; i++)
            {
                string seat = Console.ReadLine();

                 if (seat[1] == 'A' || seat[1] == 'F')
                {
                    windowSeats++;
                }
                if (seat[1] == 'B' || seat[1] == 'E')
                {
                    middleSeats++;
                }
                if (seat[1] == 'C' || seat[1] == 'D')
                {
                    isleSeats++;
                }

            }
            double windowSeatPercent = (windowSeats / passengers) * 100;
            double middleSeatPercent = (middleSeats / passengers) * 100;
            double isleSeatPercent = (isleSeats / passengers) * 100;


            Console.WriteLine($"Window Seats: {windowSeatPercent:f2}%");
            Console.WriteLine($"Middle Seats: {middleSeatPercent:f2}%");
            Console.WriteLine($"Aisle Seats: {isleSeatPercent:f2}%");

        }
    }
}
