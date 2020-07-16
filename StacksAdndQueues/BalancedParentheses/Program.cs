using System;
using System.Collections.Generic;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();

            for (int i = 0; i < input.Length / 2; i++)
            {
                stack.Push(input[i]);
            }
            for (int i = input.Length / 2; i < input.Length; i++)
            {
                queue.Enqueue(input[i]);
            }

            bool isDifferent = false;
            while (stack.Count != 0)
            {
                if (stack.Peek().Equals('{') && !queue.Peek().Equals('}'))
                {
                    isDifferent = true;
                    break;
                }
                else if (stack.Peek().Equals('[') && !queue.Peek().Equals(']'))
                {
                    isDifferent = true;
                    break;
                }
                else if (stack.Peek().Equals('(') && !queue.Peek().Equals(')'))
                {
                    isDifferent = true;
                    break;
                }
                stack.Pop();
                queue.Dequeue();

            }
            if (isDifferent)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
