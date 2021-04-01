using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociativeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> charDict = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    if (charDict.ContainsKey(text[i]))
                    {
                        charDict[text[i]]++;
                    }
                    else
                    {
                        charDict.Add(text[i], 1);
                    }
                }
            }
            foreach (var item in charDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            

        }
    }
}
