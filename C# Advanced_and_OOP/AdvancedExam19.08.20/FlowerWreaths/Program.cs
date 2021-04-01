using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerWreaths
{
    class Program
    {
        static void Main()
        {
            var liliesInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var rosesInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var liliesStack = new Stack<int>(liliesInput);
            var rosesQueue = new Queue<int>(rosesInput);

            int wreathsDone = 0;
            int flowerSum = 0;

            while (liliesStack.Any() && rosesQueue.Any())
            {
                var result = liliesStack.Peek() + rosesQueue.Peek();

                if (result == 15)
                {
                    wreathsDone++;
                    liliesStack.Pop();
                    rosesQueue.Dequeue();
                }
                else if (result > 15)
                {
                    liliesStack.Push(liliesStack.Pop() - 2);
                }
                else
                {
                    flowerSum += result;
                    liliesStack.Pop();
                    rosesQueue.Dequeue();
                }
                
            }

            int additionalWreaths = flowerSum / 15;

            wreathsDone += additionalWreaths;

            int wreathsNeeded = 5 - wreathsDone;

            if (wreathsDone >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathsDone} wreaths!");   
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {wreathsNeeded} wreaths more!");
            }


        }
    }
}
