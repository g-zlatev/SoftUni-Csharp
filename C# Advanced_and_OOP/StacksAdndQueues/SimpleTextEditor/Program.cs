using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfOperations = int.Parse(Console.ReadLine());

            StringBuilder text = new StringBuilder();
            Stack<string> stack = new Stack<string>();

            stack.Push(text.ToString());

            for (int i = 0; i < numOfOperations; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = input[0];
                if (command == "1")
                {
                    string stringToAppend = input[1];
                    text.Append(stringToAppend);
                    stack.Push(text.ToString());

                }
                else if (command == "2")
                {
                    int count = int.Parse(input[1]);
                    text.Remove(text.Length - count, count);
                    stack.Push(text.ToString());
                }
                else if (command == "3")
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(text[index - 1].ToString());

                }
                else if (command == "4")
                {
                    stack.Pop();
                    if (text.Length > 0)
                    {
                        text.Clear();
                        text.Append(stack.Peek());
                    }
                    else
                    {
                        text.Append(stack.Peek());
                    }

                }
            }

        }
    }
}
