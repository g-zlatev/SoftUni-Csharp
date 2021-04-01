using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            bool valid = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                {
                    stack.Push(input[i]);
                    continue;
                }

                if (stack.Count == 0)
                {
                    valid = false;
                    break;
                }

                if (stack.Peek().Equals('(') && input[i] == ')')
                {
                    stack.Pop();
                }
                else if (stack.Peek().Equals('{') && input[i] == '}')
                {
                    stack.Pop();
                }
                else if (stack.Peek().Equals('[') && input[i] == ']')
                {
                    stack.Pop();
                }
                else
                {
                    valid = false;
                    break;
                }


            }
            if (valid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
