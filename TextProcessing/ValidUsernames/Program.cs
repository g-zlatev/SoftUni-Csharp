using System;
using System.Linq;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ").Where(n => ValidateUsername(n)).ToArray();

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }

        private static bool ValidateUsername(string names)
        {
            if ((names.Length < 3 || names.Length > 16))
            {
                return false;
            }

            bool add = true;
            foreach (char letter in names)
            {
                if (!(char.IsLetterOrDigit(letter) || letter == '-' || letter == '_'))
                {
                    add = false;
                    break;
                }
            }
            return add;
        }
    }
}
