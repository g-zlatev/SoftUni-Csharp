using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string winnerName = "";
            int winnerSum = 0;

            while (name != "STOP")
            {
                int nameLength = name.Length;
                int sum = 0;
                for (int i = 0; i < nameLength; i++)
                {
                    sum += (int)name[i];
                }
                if (sum > winnerSum)
                {
                    winnerSum = sum;
                    winnerName = name;
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {winnerName} - {winnerSum}!");
        }
    }
}
