using System;

namespace ObjectsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = Console.ReadLine();
            var type = test.GetType();

            Console.WriteLine(type);
        }
    }
}
