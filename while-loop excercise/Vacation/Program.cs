using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal tripPrice = decimal.Parse(Console.ReadLine());
            decimal ownedMoney = decimal.Parse(Console.ReadLine());
            int daysPast = 0;
            int spendingCounter = 0;

            while (ownedMoney < tripPrice && spendingCounter < 5)
            {
                string spendOrSave = Console.ReadLine();
                decimal moneyInput = decimal.Parse(Console.ReadLine());
                daysPast++;
                if (spendOrSave == "spend")
                {
                    ownedMoney -= moneyInput;
                    if (ownedMoney < 0)
                    {
                        ownedMoney = 0;
                    }
                    spendingCounter++;
                }
                else if (spendOrSave == "save")
                {
                    ownedMoney += moneyInput;
                    spendingCounter = 0;
                }
                if (spendingCounter == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{daysPast}");
                    break;
                }
            }
            if (ownedMoney >= tripPrice)
            {
                Console.WriteLine($"You saved the money for {daysPast} days.");
            }


        }
    }
}
