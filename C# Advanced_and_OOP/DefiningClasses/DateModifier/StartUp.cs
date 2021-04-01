using System;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            var result = DateModifier.CalculateSumBetweenDays(input1, input2);

            Console.WriteLine(result);

        }
    }
}
