using System;
using System.Linq;

namespace makemeaword
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] charas = input.Split().Select(int.Parse).ToArray();
            string result = "";

            for (int i = 0; i < charas.Length; i++)
            {
                charas[i] += 8;
                result += (char)charas[i];
            }
            Console.WriteLine(result);
        }
    }
}
