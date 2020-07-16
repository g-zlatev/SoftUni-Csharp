using System;
using System.Linq;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string biggerStr;
            string smallerStr;
            int sum = 0;

            DetermineLargerString(input, out biggerStr, out smallerStr);
            sum = MultiplyStringChars(biggerStr, smallerStr, sum);

            Console.WriteLine(sum);
        }

        private static int MultiplyStringChars(string biggerStr, string smallerStr, int sum)
        {
            for (int i = 0; i < smallerStr.Length; i++)
            {
                sum += biggerStr[i] * smallerStr[i];
            }
            for (int j = smallerStr.Length; j < biggerStr.Length; j++)
            {
                sum += biggerStr[j];
            }

            return sum;
        }

        private static void DetermineLargerString(string[] input, out string biggerStr, out string smallerStr)
        {
            if (input[0].Length > input[1].Length)
            {
                biggerStr = input[0];
                smallerStr = input[1];
            }
            else
            {
                biggerStr = input[1];
                smallerStr = input[0];
            }
        }
    }
}
