using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            try
            {
                string[] pizzaNameInput = Console.ReadLine().Split(" ").ToArray();
                string pizzaName = pizzaNameInput[1];

                var doughInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Dough dough = CreateDough(doughInput);

                Pizza pizza = new Pizza(pizzaName, dough);

                string command;

                while ((command = Console.ReadLine()) != "END")
                {
                    var toppingInput = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string toppingType = toppingInput[1];
                    double toppingWeight = double.Parse(toppingInput[2]);

                    Topping topping = new Topping(toppingType, toppingWeight);

                    pizza.AddToping(topping);
                }

                Console.WriteLine(pizza.ToString());

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        private static Dough CreateDough(string[] input)
        {
            string flourType = input[1];
            string doughTech = input[2];
            double weight = double.Parse(input[3]);

            Dough dough = new Dough(flourType, doughTech, weight);
            return dough;
        }
    }
}
