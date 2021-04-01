using System;

namespace arrays_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[3];
            ages[0] = 15;
            ages[1] = 21;
            ages[2] = 55;

            Console.WriteLine(ages[0]); //15

            Console.WriteLine(ages.Length); //3
                                            //////////////////////////////////////////////////////////////

            // Create an array of four elements, and add values later
            string[] cars = new string[4];

            // Create an array of four elements and add values right away 
            string[] cars1 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] cars2 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars3 = { "Volvo", "BMW", "Ford", "Mazda" };

        }
    }
}
