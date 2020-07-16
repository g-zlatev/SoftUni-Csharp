using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfQueries = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numOfQueries; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int query = input[0];

                switch (query)
                {
                    case 1:
                        int num = input[1];
                        stack.Push(num);
                        break;
                    case 2:
                        stack.TryPop(out int result);
                        //if (stack.Any())
                        //{
                        //    stack.Pop();
                        //}
                        break;
                    case 3:
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4:
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;

                    default:
                        break;
                }

            }
            Console.WriteLine(String.Join(", ", stack.ToArray()));

        }
    }
}
