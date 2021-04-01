using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;


            //int usernameLength;
            //usernameLength = username.Length - 1;
            //while (usernameLength >= 0)
            //{
            //    password += username[usernameLength];
            //    usernameLength--;
            //}

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            //string input = Console.ReadLine();
            //if (input != password)
            //{
            //    int counter = 1;
            //    while (counter < 4)
            //    {
            //        Console.WriteLine("Incorrect password. Try again.");
            //        counter++;
            //        input = Console.ReadLine();
            //        if (input == password)
            //        {
            //            Console.WriteLine($"User {username} logged in.");
            //            return;
            //        }
            //    }
            //    Console.WriteLine($"User {username} blocked!");
            //    return;
            //}
            //if (input == password)
            //{
            //    Console.WriteLine($"User {username} logged in.");
            //}


            for (int i = 1; i <= 4; i++)
            {
                string input = Console.ReadLine();
                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                if (i <= 3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {username} blocked!");

                }
            }

        }
    }
}
