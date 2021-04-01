using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Method(a);

            Console.WriteLine(a); //5
            Console.WriteLine(Method(a)); //1000
        }

        public static int Method(int a)
        {
            a = 1000;
            return a;

        }

    }
}
