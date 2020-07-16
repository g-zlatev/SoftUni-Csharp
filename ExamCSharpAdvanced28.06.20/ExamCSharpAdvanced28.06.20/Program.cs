using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamCSharpAdvanced28._06._20
{
    class Program
    {
        static void Main(string[] args)
        {
            var casings = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray().Reverse();
            var effects = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray().Reverse();

            Stack<int> casingStack = new Stack<int>(casings);
            Queue<int> effectQueue = new Queue<int>(effects);

            SortedDictionary<string, int> pouch = new SortedDictionary<string, int>();

            bool notDone = true;
            bool notEnoughMaterials = false;
            bool pouchFilled = false;

            while (notDone)
            {
                if (casingStack.Any() && effectQueue.Any())
                {
                    MakingBombs(casingStack, effectQueue, pouch);
                }
                else
                {
                    notDone = false;
                    notEnoughMaterials = true;
                    break;
                }

                if (pouch.ContainsKey("Cherry Bombs") && pouch.ContainsKey("Datura Bombs") && pouch.ContainsKey("Smoke Decoy Bombs"))
                {
                    if (pouch["Cherry Bombs"] >= 3 && pouch["Datura Bombs"] >= 3 && pouch["Smoke Decoy Bombs"] >= 3)
                    {
                        pouchFilled = true;
                        notDone = false;
                        break;
                    }
                }

            }

            if (pouchFilled)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (effectQueue.Any())
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", casingStack.ToArray())}"); //!
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (casingStack.Any())
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", effectQueue.ToArray())}"); //!
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            foreach (var kvp in pouch)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        private static void MakingBombs(Stack<int> casingStack, Queue<int> effectQueue, SortedDictionary<string, int> bombs)
        {
            int currCasing = casingStack.Peek();
            int currEffect = effectQueue.Peek();

            if (currCasing + currEffect == 40)
            {
                if (!bombs.ContainsKey("Datura Bombs"))
                {
                    bombs.Add("Datura Bombs", 1);
                }
                else
                {
                    bombs["Datura Bombs"]++;
                }

                RemoveMaterials(casingStack, effectQueue);

            }
            else if (currCasing + currEffect == 60)
            {
                if (!bombs.ContainsKey("Cherry Bombs"))
                {
                    bombs.Add("Cherry Bombs", 1);
                }
                else
                {
                    bombs["Cherry Bombs"]++;
                }

                RemoveMaterials(casingStack, effectQueue);

            }
            else if (currCasing + currEffect == 120)
            {
                if (!bombs.ContainsKey("Smoke Decoy Bombs"))
                {
                    bombs.Add("Smoke Decoy Bombs", 1);
                }
                else
                {
                    bombs["Smoke Decoy Bombs"]++;
                }

                RemoveMaterials(casingStack, effectQueue);

            }
            else if (casingStack.Peek() > 0)
            {
                casingStack.Push(casingStack.Pop() - 5);
            }
        }

        private static void RemoveMaterials(Stack<int> effectsStack, Queue<int> casingsQueue)
        {
            effectsStack.Pop();
            casingsQueue.Dequeue();
        }
    }
}
