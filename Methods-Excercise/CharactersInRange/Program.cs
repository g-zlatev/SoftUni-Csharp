using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());

            GetCharsInRange(char1, char2);
        }

        private static void GetCharsInRange(char char1, char char2)
        {
            char temp;
            if (char1 > char2)
            {
                temp = char2;
                char2 = char1;
                char1 = temp;
            }
            for (int i = char1 + 1; i < char2; i++)
            {
                Console.Write((char)i + " ");
            }

        }
    }
}
