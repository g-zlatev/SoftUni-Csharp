using System;
using System.Linq;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().TrimStart('0');
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder product = new StringBuilder();

            int secondDigit = 0;
            int sum = 0;
            int remainder = 0;
            for (int i = first.Length - 1; i >= 0; i--)
            {
                //int mnojitelEdno = Convert.ToInt32(new string(first[i], 1));
                char currChar = first[i];
                int currentNum = int.Parse(currChar.ToString());

                if (multiplier == 0)
                {
                    Console.WriteLine(0);
                    return;
                }

                sum = (currentNum * multiplier) + remainder;

                secondDigit = sum % 10;
                product.Append(secondDigit);
                remainder = sum / 10;
            }

            if (remainder > 0)
            {
                product.Append(remainder);
            }

            Console.WriteLine(product.ToString().Reverse().ToArray());
        }
    }
}
