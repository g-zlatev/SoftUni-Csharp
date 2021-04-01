using System;

namespace godzilla_vs_kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double costumePrice = double.Parse(Console.ReadLine());

            double decorsPrice = budget * 0.1;
            double totalCostumePrice = costumePrice * actors;

            if (actors >= 150)
            {
                totalCostumePrice = totalCostumePrice - (totalCostumePrice * 0.1);
            }
            double moneyNeeded = decorsPrice + totalCostumePrice;
            if (moneyNeeded > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - moneyNeeded:f2} leva left.");
            }
        }
    }
}
