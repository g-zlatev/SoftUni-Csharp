using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder();

            foreach (char item in input)
            {
                output.Append((char)(item + 3));
            }

            Console.WriteLine(output);
        }
    }
}
