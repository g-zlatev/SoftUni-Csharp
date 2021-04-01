using System;

namespace exam_test
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodMoney = double.Parse(Console.ReadLine());
            double souvenirMoney = double.Parse(Console.ReadLine());
            double hotelPrice = double.Parse(Console.ReadLine());

            double liters = 420.0 / 100.0 * 7.0;
            double tripCost = liters * 1.85;
            double dayOneHotel = hotelPrice * 0.90;
            double dayTwoHotel = hotelPrice * 0.85;
            double dayThreeHotel = hotelPrice * 0.80;
            double totalHotelCost = dayOneHotel + dayTwoHotel + dayThreeHotel;
            double totalSovenirsAndFoodCost = (souvenirMoney + foodMoney) * 3;

            Console.WriteLine($"Money needed: {totalHotelCost+tripCost+totalSovenirsAndFoodCost:f2}");
        }
    }
}
