using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Pizza
    {
        private const int maxNameLength = 15;
        private const int toppingsMinCount = 0;
        private const int toppingsMaxCount = 10;

        private string name;
        private Dough dough;
        private readonly List<Topping> toppings;


        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > maxNameLength)
                {
                    throw new ArgumentException($"Pizza name should be between 1 and {maxNameLength} symbols.");
                }

                this.name = value;
            }
        }

        public Dough Dough
        {
            get
            {
                return this.dough;
            }
            set
            {
                this.dough = value;
            }
        }

        public int NumberOfToppings => this.toppings.Count;


        public double TotalPizzaCalories => CalculateTotalCalories();



        public void AddToping(Topping topping)
        {
            if (toppings.Count >= toppingsMaxCount)
            {
                throw  new ArgumentException($"Number of toppings should be in range [{ toppingsMinCount }..{ toppingsMaxCount}].");
            }
            this.toppings.Add(topping);
        }

        private double CalculateTotalCalories()
        {
            double result = dough.CalculateDoughCalories;

            foreach (var topping in toppings)
            {
                result += topping.ToppingCaloriesPerGram;
            }

            return result;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.TotalPizzaCalories:F2} Calories.";
        }
    }
}
