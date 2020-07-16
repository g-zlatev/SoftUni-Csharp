using System;
using System.Text;

namespace ReplaceRepeatingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder text = new StringBuilder();
           
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    text.Append(input[i]);
                }

            }
            text.Append(input[input.Length-1]);
            Console.WriteLine(text);
        }
    }
}
