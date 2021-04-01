using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            var num = int.Parse(Console.ReadLine());
            List<IBuyer> buyers = new List<IBuyer>();


            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (input.Length == 4)
                {
                    var citizen = new Citizen(input[0],int.Parse(input[1]),input[2],input[3]);
                    buyers.Add(citizen);
                }
                else if (input.Length == 3)
                {
                    var rebel = new Rebel(input[0],int.Parse(input[1]),input[2]);
                    buyers.Add(rebel);
                }
            }

            string command;

            int sum = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                if (buyers.Exists(x => x.Name == command))
                {
                    IBuyer person = buyers.Where(x => x.Name == command).FirstOrDefault();

                    person.BuyFood();
                }

            }

            foreach (var VARIABLE in buyers)
            {
                sum += VARIABLE.Food;
            }

            Console.WriteLine(sum);
          
        }
    }
}
