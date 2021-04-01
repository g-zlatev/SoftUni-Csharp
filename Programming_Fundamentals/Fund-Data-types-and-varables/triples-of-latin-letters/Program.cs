using System;

namespace triples_of_latin_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLetters = int.Parse(Console.ReadLine());



            for (int i = 0; i < numOfLetters; i++)
            {
                char firstChar = (char)('a' + i);

                for (int j = 0; j < numOfLetters; j++)
                {
                    char secondChar = (char)('a' + j);

                    for (int l = 0; l < numOfLetters; l++)
                    {
                        char thirdChar = (char)('a' + l);

                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
