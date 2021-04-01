using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            decimal moneySaved = 0;
            int toysSaved = 0;

            for (int currentBirthday = 1; currentBirthday <= age; currentBirthday++)
            {
                if (currentBirthday % 2 == 1)
                {
                    toysSaved++;
                }
                else
                {
                    moneySaved += currentBirthday * 5;
                    moneySaved--;
                }
            }
            moneySaved += toysSaved * toyPrice;
            if (moneySaved >= price)
            {
                Console.WriteLine($"Yes! {moneySaved - price:f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(moneySaved-price):f2}");
            }
        }
    }
}
