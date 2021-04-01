using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> List = Console.ReadLine().Split().ToList();
            List<string> input = Console.ReadLine().Split().ToList();

            while (input[0] != "end")
            {
                if (input[0] == "Delete")
                {
                    for (int i = 0; i < List.Count; i++)
                    {
                        List.Remove(input[1]);
                    }
                }

                if (input[0] == "Insert")
                {
                    List.Insert(int.Parse(input[2]), input[1]);
                }
                input = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(string.Join(" ", List));

        }

    }
}
