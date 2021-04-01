using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split('>').ToList();
            StringBuilder finalText = new StringBuilder();
            int remainder = 0;

            for (int i = 0; i < text.Count; i++)
            {
                string word = text[i];

                for (int j = 0; j < word.Length; j++)
                {

                    if (char.IsDigit(word[0]))
                    {
                        int strength = (int)char.GetNumericValue(word[0]) + remainder;

                        if (strength <= word.Length)
                        {
                            word = word.Remove(0, strength).Insert(0, ">");
                        }
                        else
                        {
                            remainder = strength - word.Length;
                            word = word.Remove(0, word.Length).Insert(0, ">");
                        }
                        strength = 0;
                    }
                }
                finalText.Append(word);
            }
            Console.WriteLine(string.Join("", finalText));
        }
    }
}
