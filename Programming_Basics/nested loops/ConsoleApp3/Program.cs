using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int batches = int.Parse(Console.ReadLine());
                bool haveErrorsInBatch = false;
                bool isSugar = false;
                bool isFlour = false;
                bool isEggs = false;
            for (int currentBatch = 1; currentBatch < batches; currentBatch++)
            {
                if (!haveErrorsInBatch)
                {

                }
                string ingredient = Console.ReadLine();
                while (ingredient != "Bake!")
                {
                    switch (ingredient)
                    {
                        case "sugar": isSugar = true; break;
                        case "flour": isFlour = true; break;
                        case "eggs": isFlour = true; break;
                    }
                    ingredient = Console.ReadLine();
                }
                if (isSugar == true && isFlour == true && isEggs == true)
                {
                    Console.WriteLine("Baking batch number {0}...", currentBatch);
                }
                else
                {
                    currentBatch++;
                    haveErrorsInBatch = true;
                    Console.WriteLine("The batter should contain flour, eggs and sugar!");
                }
            }
        }
    }
}
