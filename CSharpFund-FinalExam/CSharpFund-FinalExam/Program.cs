using System;

namespace CSharpFund_FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string newPassword = string.Empty;
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Done")
            {
                if (input[0] == "TakeOdd")
                {
                    for (int i = 1; i < password.Length; i += 2)
                    {
                        newPassword += password[i];
                    }
                    password = newPassword;
                    Console.WriteLine(password);
                }
                if (input[0] == "Cut")
                {
                    int index = int.Parse(input[1]);
                    int length = int.Parse(input[2]);

                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }
                if (input[0] == "Substitute")
                {
                    string substring = input[1];
                    string substitute = input[2];
                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }


                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
