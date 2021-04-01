using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCommands = int.Parse(Console.ReadLine());
            List<string> command = new List<string>();
            List<string> nameList = new List<string>();

            for (int i = 0; i < numOfCommands; i++)
            {
                command = Console.ReadLine().Split().ToList();
                if (command.Contains("not"))
                {
                    if (nameList.Contains(command[0]))
                    {
                        nameList.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
                else
                {
                    if (nameList.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        nameList.Add(command[0]);
                    }
                }

            }
            Console.WriteLine(string.Join("\r\n", nameList));
        }
    }
}
