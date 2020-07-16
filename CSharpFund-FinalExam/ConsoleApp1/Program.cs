using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string[] input = Console.ReadLine().Split(":|:", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Reveal")
            {
                if (input[0] == "InsertSpace")
                {
                    int index = int.Parse(input[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                if (input[0] == "Reverse")
                {
                    if (message.Contains(input[1]))
                    {
                        char[] substringArray = input[1].ToCharArray();
                        string reversed = "";
                        for (int i = substringArray.Length - 1; i >= 0; i--)
                        {
                            reversed += substringArray[i].ToString();
                        }
                        int index = message.IndexOf(input[1]);

                        message = message.Remove(index, input[1].Length);
                        //message = message.Replace(input[1], "");
                        message = message + reversed;
                        Console.WriteLine(message);
                        ;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                if (input[0] == "ChangeAll")
                {
                    string substr = input[1];
                    string replacement = input[2];
                    message = message.Replace(substr, replacement);
                    Console.WriteLine(message);                   
                }

                input = Console.ReadLine().Split(":|:", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
