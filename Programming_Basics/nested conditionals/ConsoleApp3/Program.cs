using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            switch (animal)
            {
                case "dog": 
                    Console.WriteLine("mammal"); 
                    break;


                default:
                    break;
            }
        }
    }
}
