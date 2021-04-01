using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([@#+])([A-Za-z]{3,})(\1)(\1)([A-Za-z]{3,})(\1)";
            List<string> couples = new List<string>();

            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count <= 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            foreach (Match match in matches)
            {
                string normal = match.Groups[2].Value;
                string reversed = "";
                for (int i = match.Groups[5].Value.Length - 1; i >= 0; i--)
                {
                    reversed += match.Groups[5].Value[i];
                }
                if (normal == reversed)
                {
                    couples.Add($"{normal} <=> {match.Groups[5].Value}");
                }
            }

            if (matches.Count != 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
                if (couples.Count != 0)
                {
                    Console.WriteLine($"The mirror words are:");
                    Console.WriteLine(string.Join(", ", couples));
                }

            }
            if (couples.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
