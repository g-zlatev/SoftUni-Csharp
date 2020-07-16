using System;

namespace BachelorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int performerPrice = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int totalPeople = 0;
            int price = 0; 

            while (input != "The restaurant is full")
            {
                int people = int.Parse(input);
                totalPeople += people;
                if (people < 5)
                {
                    price += people * 100;
                }
                else if (people >= 5)
                {
                    price += people * 70;
                }
                input = Console.ReadLine();

            }
            if (input == "The restaurant is full")
            {
                if (price >= performerPrice)
                {
                    Console.WriteLine($"You have {totalPeople} guests and {price - performerPrice} leva left.");

                }
                else
                {
                    Console.WriteLine($"You have {totalPeople} guests and {price} leva income, but no singer.");

                }
            }
        }
    }
}
