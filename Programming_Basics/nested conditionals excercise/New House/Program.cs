using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerNumber = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            decimal price = 0.0m;

            if (flowerType == "Roses")
            {
                price = flowerNumber * 5;
                if (flowerNumber > 80)
                {
                    price -= price * 0.1m;
                }
            }
            else if (flowerType == "Dahlias")
            {
                price = flowerNumber * 3.8m;
                if (flowerNumber > 90)
                {
                    price -= price * 0.15m;
                }
            }
            else if (flowerType == "Tulips")
            {
                price = flowerNumber * 2.8m;
                if (flowerNumber > 80)
                {
                    price -= price * 0.15m;
                }
            }
            else if (flowerType == "Narcissus")
            {
                price = flowerNumber * 3;
                if (flowerNumber < 120)
                {
                    price += price * 0.15m;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                price = flowerNumber * 2.5m;
                if (flowerNumber < 80)
                {
                    price += price * 0.20m;
                }
            }

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerNumber} {flowerType} and {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");
            }
        }
    }
}
