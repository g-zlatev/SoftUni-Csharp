using System;

namespace while_loop_excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());
            string input = "";
            int counter = 0;

            while (capacity > counter)
            {
                input = Console.ReadLine();
                if (input == book)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                counter++;
            }
            if (capacity == counter)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
                
            }
        }
    }
}
