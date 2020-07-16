using System;
using System.Collections.Generic;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> house = Console.ReadLine().Split("@").Select(int.Parse).ToList();
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command;
            int houseIndex = 0;

            while ((command = input[0]) != "Love!")
            {

                if (command == "Jump")
                {
                    int length = int.Parse(input[1]);
                    houseIndex += length;

                    if (houseIndex > house.Count-1)
                    {
                        houseIndex = 0;
                    }
                    if (house[houseIndex] == 0)
                    {
                        Console.WriteLine($"Place {houseIndex} already had Valentine's day.");
                    }

                    if (house[houseIndex] > 0)
                    {
                        house[houseIndex] -= 2;
                        if (house[houseIndex] == 0)
                        {
                            Console.WriteLine($"Place {houseIndex} has Valentine's day.");
                        }
                    }
                }
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            }


            Console.WriteLine($"Cupid's last position was {houseIndex}.");
            int count = 0;
            foreach (var h in house)
            {
                if (h == 0)
                {
                    count++;
                }
            }

            if (count == house.Count)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {(house.Count)-count} places.");
            }
        }
    }
}
