using System;

namespace Shaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double shipWidth = double.Parse(Console.ReadLine());
            double shipLength = double.Parse(Console.ReadLine());
            double shipHeight = double.Parse(Console.ReadLine());
            double astronautMeanHeigth = double.Parse(Console.ReadLine());

            double shipVolume = (shipLength * shipWidth) * shipHeight;
            double roomVolume = (astronautMeanHeigth + 0.40) * 2 * 2;
            double totalRooms = Math.Floor(shipVolume / roomVolume);

            if (totalRooms < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (totalRooms > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
            else
            {
                Console.WriteLine($"The spacecraft holds {totalRooms} astronauts.");
            }
        }
    }
}
