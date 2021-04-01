using System;

namespace bonus_score
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonus = 0.0;

            if (num <= 100)
            {
                bonus = 5;
            }
            else if (num > 1000)
            {
                bonus = num * 0.10;
            }
            else
            {
                bonus = num * 0.2;
            }
            if (num % 10 == 5)
            {
                bonus += 2;
            }
            else if (num % 2 == 0)
            {
                bonus = bonus + 1;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);

        }
    }
}
