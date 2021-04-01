using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            GetMiddleChar(str);
        }

        private static void GetMiddleChar(string str)
        {
            if (str.Length % 2 == 0)
            {
                char firstChar = str[str.Length / 2 - 1];
                char secondChar = str[str.Length / 2];
                Console.WriteLine(firstChar + "" + secondChar);
            }
            else
            {
                Console.WriteLine((char)str[str.Length / 2]);
            }

        }
    }
}
