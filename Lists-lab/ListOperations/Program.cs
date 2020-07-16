using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            •	Add {number} – add number at the end.
            •	Insert {number} {index} – insert number at given index.
            •	Remove {index} – remove at index.
            •	Shift left {count} – first number becomes last ‘count’ times.
            •	Shift right {count} – last number becomes first ‘count’ times.
            Note: there is a possibility that the given index is outside of the bounds of the array. In that case print "Invalid index"

             */
            List<string> list = Console.ReadLine().Split().ToList();
            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "End")
            {
                if (command[0] == "Add")
                {
                    list.Add(command[1]);
                }
                else if (command[0] == "Insert")
                {
                    list.Insert(int.Parse(command[2]), command[1]);
                }
                else if (command[0] == "Remove")
                {
                    
                }

                
                command = Console.ReadLine().Split().ToList();
            }
        }
    }
}
