using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int reservationDay = int.Parse(Console.ReadLine());
            int reservationMonth = int.Parse(Console.ReadLine());
            int checkInDay = int.Parse(Console.ReadLine());
            int checkInMonth = int.Parse(Console.ReadLine());
            int checkOutDay = int.Parse(Console.ReadLine());
            int checkOutMonth = int.Parse(Console.ReadLine());

            decimal price = 30m;

            if (checkInDay - reservationDay >= 10)
            {
                price = 25;
            }
            if (checkInMonth!=reservationMonth)
            {
                price = 25 * 0.8m;
            }
            decimal finalPrice = (checkOutDay - checkInDay) * price;
            Console.WriteLine($"Your stay from {checkInDay}/{checkInMonth} to {checkOutDay}/{checkOutMonth} will cost {finalPrice:f2}");
        }
    }
}
