using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());

            bool isBullsey = false;
            int counter = 0;
            while (points > 0 && !isBullsey)
            {
                counter++;
                string sector = Console.ReadLine();
                if (sector=="bullseye")
                {
                    isBullsey = true;
                    break;
                }
                int currentPoints = int.Parse(Console.ReadLine());

                switch (sector)
                {
                    case "double ring":
                        currentPoints *= 2;
                        break;

                    case "triple ring":
                        currentPoints *= 3;
                        break;
                    
                }
                points -= currentPoints;

            }
            if (points == 0)
            {
                Console.WriteLine($"Congratulations! You won the game in {counter} moves!");
            }
            if (isBullsey)
            {
                Console.WriteLine($"Congratulations! You won the game with a bullseye in {counter} moves!");
            }
            if (points < 0)
            {
                Console.WriteLine("Sorry, you lost. Score difference: {0}.", Math.Abs(points));
            }
        }
    }
}
