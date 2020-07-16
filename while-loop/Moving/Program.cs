using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            string input = "";
            int spaceVolume = heigth * length * width;
            int boxVolume = 0;
            int occupiedVolume = 0;

            while (input != "Done")
            {
                input = Console.ReadLine();
                if (input == "Done")
                {
                    Console.WriteLine($"{spaceVolume - occupiedVolume} Cubic meters left.");
                    break;
                }
                else
                {
                    boxVolume = int.Parse(input);
                }
                occupiedVolume += boxVolume;
                if (occupiedVolume > spaceVolume)
                {
                    Console.WriteLine($"No more free space! You need {occupiedVolume - spaceVolume} Cubic meters more.");
                    break;
                }
            
            }
        }
    }
}
