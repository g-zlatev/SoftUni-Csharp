using System;

namespace pet_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogNumber = int.Parse(Console.ReadLine());
            int otherAnimalNumer = int.Parse(Console.ReadLine());

            Double dogFood = 2.5;
            Double otherAnimalFood = 4;

            Double dogPrise = dogNumber * dogFood;
            Double otherAnimalPrise = otherAnimalNumer * otherAnimalFood;

            Double totalPrise = dogPrise + otherAnimalPrise;

            Console.WriteLine($"{totalPrise:f2}"+" lv.");
        }
    }
}
