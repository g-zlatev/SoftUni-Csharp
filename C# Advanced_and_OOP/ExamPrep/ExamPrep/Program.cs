
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var malesInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var femalesInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> maleStack = new Stack<int>(malesInput);
            Queue<int> femalesQueue = new Queue<int>(femalesInput);

            int counter = 0;

            while (maleStack.Count > 0 && femalesQueue.Count > 0)
            {
                int currentMale = maleStack.Peek();
                int currentFemale = femalesQueue.Peek();

                if (currentMale <= 0)
                {
                    maleStack.Pop();
                    continue;
                }

                if (currentFemale <= 0)
                {
                    femalesQueue.Dequeue();
                    continue;

                }

                if (currentMale % 25 == 0)
                {
                    maleStack.Pop();

                    if (maleStack.Any())
                    {
                        maleStack.Pop();
                    }

                    continue;
                }

                if (currentFemale % 25 == 0)
                {
                    femalesQueue.Dequeue();

                    if (femalesQueue.Any())
                    {
                        femalesQueue.Dequeue();
                    }

                    continue;
                }

                if (currentMale == currentFemale)
                {
                    counter++;

                    maleStack.Pop();
                    femalesQueue.Dequeue();

                }
                else
                {
                    femalesQueue.Dequeue();
                    maleStack.Push(maleStack.Pop() - 2); //maleStack.Pop(); maleStack.Push(currentMale -2);

                }

            }

            Console.WriteLine($"Matches: {counter}");

            string malesString = maleStack.Count > 0 ? String.Join(", ", maleStack) : "none";

            Console.WriteLine($"Males left: {malesString}");

            string femalesString = femalesQueue.Count > 0 ? String.Join(", ", femalesQueue) : "none";

            Console.WriteLine($"Females left: {femalesString}");

        }
    }
}
