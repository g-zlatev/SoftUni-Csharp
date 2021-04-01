using System;

namespace Book_a_flight
{
    class Program
    {
        static void Main(string[] args)
        {
            string flightClass = Console.ReadLine();
            double flightDuration = double.Parse(Console.ReadLine());
            int passengers = int.Parse(Console.ReadLine());

            double ticketPrice = 0;

            switch (flightClass)
            {
                case "Economy":
                    if (flightDuration < 1500)
                    {
                        ticketPrice = 59.99;
                    }
                    else if (flightDuration <= 3500)
                    {
                        ticketPrice = 184.99;
                    }
                    else
                    {
                        ticketPrice = 269.99;
                    }
                    break;
                case "Premium":
                    if (flightDuration < 1500)
                    {
                        ticketPrice = 179.99;
                    }
                    else if (flightDuration <= 3500)
                    {
                        ticketPrice = 279.99;
                    }
                    else
                    {
                        ticketPrice = 394.99;
                    }
                    break;

                case "Business":
                    if (flightDuration < 1500)
                    {
                        ticketPrice = 254.99;
                    }
                    else if (flightDuration <= 3500)
                    {
                        ticketPrice = 379.99;
                    }
                    else
                    {
                        ticketPrice = 619.99;
                    }
                    break;

            }
            if (passengers > 6)
            {
                ticketPrice *= 0.8;
            }
            Console.WriteLine($"The total price of the tickets is: {ticketPrice * passengers:f2} lv.");
        }
    }
}
