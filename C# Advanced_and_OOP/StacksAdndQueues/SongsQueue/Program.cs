using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Queue<string> songQueue = new Queue<string>(firstInput);

            while (songQueue.Any())
            {
                var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command[0] == "Play")
                {
                    songQueue.Dequeue();
                }
                else if (command[0] == "Add")
                {
                    var song = command.Skip(1).ToArray();
                    if (songQueue.Contains(string.Join(' ', song)))
                    {
                        Console.WriteLine($"{string.Join(' ', song)} is already contained!");
                    }
                    else
                    {
                        songQueue.Enqueue(string.Join(' ', song));
                    }
                }
                else if (command[0] == "Show")
                {
                    //var list = songQueue.ToArray();
                    Console.WriteLine(string.Join(", ", songQueue));
                }

            }
            Console.WriteLine("No more songs!");
            //return;
        }
    }
}
