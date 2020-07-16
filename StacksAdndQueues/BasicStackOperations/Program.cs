using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int itemsToPush = input[0];
            int itemsToPop = input[1];
            int itemToLookFor = input[2];

            var items = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            foreach (var item in items)
            {
                stack.Push(item);
            }

            for (int i = 0; i < itemsToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(itemToLookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                //int smallestInt = stack.Min();
                Console.WriteLine(stack.Min());
            }

        }
    }
}
