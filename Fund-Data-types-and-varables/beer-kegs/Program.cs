using System;
using System.Numerics;

namespace beer_kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfKegs = int.Parse(Console.ReadLine());
            BigInteger biggestVolume = 0;
            string biggestKeg = string.Empty;


            for (int i = 0; i < numOfKegs; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                BigInteger volume = (BigInteger)(Math.PI * Math.Pow(radius,2) * height);

                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKeg = model;
                }
            }
            Console.WriteLine(biggestKeg);

        }
    }
}
