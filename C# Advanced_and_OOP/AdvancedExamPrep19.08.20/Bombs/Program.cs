using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bombs
{
    class Program
    {
        static void Main()
        {
            var bombEffectsInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var bombCasingInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> casingStack = new Stack<int>(bombCasingInput);
            Queue<int> effectQueue = new Queue<int>(bombEffectsInput);


            //Queue<int> effectQueue = new Queue<int>();

            //foreach (var effect in bombEffectsInput)
            //{
            //    effectQueue.Enqueue(effect);
            //}

            //Stack<int> casingStack = new Stack<int>();

            //foreach (var casing in casingStack)
            //{
            //    casingStack.Push(casing);
            //}

            //var bombs = new Dictionary<string, int>()
            //{
            //    {"cherryBombs", 0},
            //    {"daturaBombs", 0},
            //    {"smokeDecoyBombs", 0}
            //};

            int cherryBombs = 0;
            int daturaBombs = 0;
            int smokeDecoyBombs = 0;

            bool fullPouch = false;

            //bool fullPouch = (bombs["cherryBombs"] >= 3 && bombs["daturaBombs"] >= 3 && bombs["smokeDecoyBombs"] >= 3);

            while (effectQueue.Any() && casingStack.Any() && !fullPouch)
            {

                var result = effectQueue.Peek() + casingStack.Peek();

                switch (result)
                {
                    case 40:
                        effectQueue.Dequeue();
                        casingStack.Pop();
                        //bombs["daturaBombs"]++;
                        daturaBombs++;
                        break;
                    case 60:
                        effectQueue.Dequeue();
                        casingStack.Pop();
                        //bombs["cherryBombs"]++;
                        cherryBombs++;
                        break;
                    case 120:
                        effectQueue.Dequeue();
                        casingStack.Pop();
                        //bombs["smokeDecoyBombs"]++;
                        smokeDecoyBombs++;
                        break;

                    default:
                        casingStack.Push(casingStack.Pop() - 5);
                        break;
                }

                if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                {
                    fullPouch = true;
                    break;
                }

            }

            if (fullPouch)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (effectQueue.Any())
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", effectQueue)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (casingStack.Any())
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", casingStack)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cherry Bombs: {cherryBombs}");
            sb.AppendLine($"Datura Bombs: {daturaBombs}");
            sb.AppendLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
