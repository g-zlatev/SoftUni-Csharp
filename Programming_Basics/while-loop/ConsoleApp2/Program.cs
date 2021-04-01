using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int depositsNum = int.Parse(Console.ReadLine());
            int counter = 0;
            double balance = 0.0;
            double totalBalance = 0.0;
            while (counter < depositsNum)
            {
                balance = double.Parse(Console.ReadLine());
                if (balance < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Increase: {balance:f2}");
                    depositsNum--;
                    totalBalance += balance;
                }
            }
            Console.WriteLine($"Total: {totalBalance:f2}");
        }
    }
}
