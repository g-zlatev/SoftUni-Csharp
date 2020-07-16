using System;

namespace coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double changeIn = double.Parse(Console.ReadLine());
            double change = changeIn * 100;
            double coins = 0;

            while (change >= 200)
            {
                change -= 200;
                coins++;
            }
            while (change >= 100)
            {
                change -= 100;
                coins++;
            }
            while (change >= 50)
            {
                change -= 50;
                coins++;
            }
            while (change >= 20)
            {
                change -= 20;
                coins++;
            }
            while (change >= 10)
            {
                change -= 10;
                coins++;
            }
            while (change >= 5)
            {
                change -= 5;
                coins++;
            }
            while (change >= 2)
            {
                change -= 2;
                coins++;
            }
            while (change >= 1)
            {
                change -= 1;
                coins++;
            }


            {
                Console.WriteLine(coins);
            }
        }
    }
}
