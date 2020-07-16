using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            string passLowered = pass.ToLower();

            //PassLengthMessage(passLowered);
            if (PassLengthMessage(passLowered) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            //PassContainsMessage(passLowered);
            if (PassContainsMessage(passLowered) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            //Pass2DigitsMessage(passLowered);
            if (Pass2DigitsMessage(passLowered) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            else if (PassLengthMessage(passLowered) && PassContainsMessage(passLowered) && Pass2DigitsMessage(passLowered) == true)
            {

                Console.WriteLine("Password is valid");
            }



        }

        private static bool Pass2DigitsMessage(string pass)
        {
            bool isTrue = false;
            int count = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i] > 47 && pass[i] < 58)
                {
                    count++;
                }
            }
            if (count > 2)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }
            if (isTrue)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private static bool PassContainsMessage(string pass)
        {
            bool isDigitOrLetter = true;
            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i] >= 48 && pass[i] <= 57 || pass[i] >= 97 && pass[i] <= 122)
                {
                    isDigitOrLetter = true;
                    
                }
                else
                {
                    isDigitOrLetter = false;
                    break;
                }
                
            }
            if (isDigitOrLetter)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private static bool PassLengthMessage(string pass)
        {
            if (pass.Length >= 6 && pass.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
