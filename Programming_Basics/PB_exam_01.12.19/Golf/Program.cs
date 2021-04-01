using System;

namespace Golf
{
    class Program
    {
        static void Main(string[] args)
        {
            int recordHits = int.Parse(Console.ReadLine());
            int holes = int.Parse(Console.ReadLine());

            int totalHits = 0;

            for (int i = 0; i < holes; i++)
            {
                int strengthNeeded = int.Parse(Console.ReadLine());

                int Strength = 0;
                while (Strength < strengthNeeded)
                {
                    totalHits++;
                    string hitStrengthInText = Console.ReadLine();
                    int textStrength = 0;

                    for (int l = 0; l < hitStrengthInText.Length; l++)
                    {
                        textStrength += hitStrengthInText[l];
                    }
                    textStrength /= hitStrengthInText.Length;
                    Strength += textStrength;

                    if (Strength >= strengthNeeded)
                    {
                        Console.WriteLine($"New hole reached! Hits so far: {totalHits}");
                        break;
                    }
                }
            }
            if (totalHits < recordHits)
            {
                Console.WriteLine($"Yes, you won! Total hits: {totalHits}");
            }
            else
            {
                Console.WriteLine($"Better luck next time... Total hits: {totalHits}");
            }
        }
    }
}
