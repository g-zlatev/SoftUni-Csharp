using System;
using System.Linq;

namespace FriendlistMaintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = Console.ReadLine().Split(", ").ToArray();
            int countOfBlacklisted = 0;
            int countOfLostNames = 0;
            string command = null;

            while ((command = Console.ReadLine()) != "Report")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "Blacklist")
                {
                    string name = tokens[1];
                    if (friends.Contains(name))
                    {
                        for (int i = 0; i < friends.Length; i++)
                        {
                            string currentName = friends[i];
                            if (currentName == name)
                            {
                                friends[i] = "Blacklisted";
                                countOfBlacklisted++;
                                Console.WriteLine($"{name} was blacklisted.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }

                else if (tokens[0] == "Error")
                {
                    int index = int.Parse(tokens[1]);
                    string currentNameAtIndex = friends[index];
                    if (!(friends[index] == "Blacklisted") && !(friends[index] == "Lost"))
                    {
                        friends[index] = "Lost";
                        countOfLostNames++;
                        Console.WriteLine($"{currentNameAtIndex} was lost due to an error.");
                    }
                    else
                    {
                        continue;
                    }

                }

                else if (tokens[0] == "Change")
                {
                    int index = int.Parse(tokens[1]);
                    string newName = tokens[2];
                    if (index >= 0 && index < friends.Length)
                    {
                        string currentName = friends[index];
                        friends[index] = newName;
                        Console.WriteLine($"{currentName} changed his username to {newName}.");
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine($"Blacklisted names: {countOfBlacklisted}");
            Console.WriteLine($"Lost names: {countOfLostNames}");
            Console.WriteLine(string.Join(" ", friends));
        }
    }
}