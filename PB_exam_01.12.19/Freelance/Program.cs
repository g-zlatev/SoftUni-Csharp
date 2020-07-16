using System;

namespace Freelance
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumToBeAmassed = double.Parse(Console.ReadLine());
            double monthlyExpenses = double.Parse(Console.ReadLine());

            double jorosMoney = 0;
            int months = 0;
            int years = 0;

            while (jorosMoney < sumToBeAmassed && jorosMoney > -1)
            {
                double montlyIncome = double.Parse(Console.ReadLine());
                jorosMoney = (jorosMoney + montlyIncome) - monthlyExpenses;
                months++;
                if (months == 12)
                {
                    years++;
                    months = 0;

                }
                if (jorosMoney < 0)
                {
                    Console.WriteLine("It seems you have bankrupted...");
                    Console.WriteLine($"You have worked {years} years {months} months");
                    break;
                }
                if (jorosMoney >= sumToBeAmassed)
                {
                    Console.WriteLine("You did it!");
                    Console.WriteLine($"It took you {years} years {months} months");
                }
            }
        }
    }
}
