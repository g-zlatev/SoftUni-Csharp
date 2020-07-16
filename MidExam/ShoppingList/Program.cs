using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("!").ToList();
            string input = Console.ReadLine();

            while (input  != "Go Shopping!")
            {
                List<string> listCommand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                string command = listCommand[0];
                if (command == "Urgent")
                {
                    if (!list.Contains(listCommand[1]))
                    {
                        list.Insert(0, listCommand[1]);
                    }
                    //else
                    //{
                    //    break;
                    //}
                }

                if (command == "Unnecessary")
                {
                    if (list.Contains(listCommand[1]))
                    {
                        list.Remove(listCommand[1]);
                    }
                    //else
                    //{
                    //    break;
                    //}

                }

                if (command == "Correct")
                {
                    if (list.Contains(listCommand[1]))
                    {
                        int index = list.IndexOf(listCommand[1]);
                        list.Insert(index, listCommand[2]);
                        list.Remove(listCommand[1]);
                    }

                }

                if (command == "Rearrange")
                {
                    if (list.Contains(listCommand[1]))
                    {
                        string temp = listCommand[1];
                        list.Remove(listCommand[1]);
                        list.Insert(list.Count, temp);
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
