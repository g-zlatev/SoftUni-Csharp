using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Topping
    {
        private const double baseCaloriesPerGram = 2;
        private const double minToppingWeight = 1;
        private const double maxToppingWeight = 50;

        private readonly Dictionary<string, double> defaultToppings = new Dictionary<string, double>()
        {
            {"meat", 1.2},
            {"veggies", 0.8},
            {"cheese", 1.1},
            {"sauce", 0.9}
        };


        private double weight;
        private string currentTopping;

        public Topping(string type, double weight)
        {
            this.CurrentTopping = type;
            this.Weight = weight;
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value < minToppingWeight || value > maxToppingWeight)
                {
                    throw new ArgumentException($"{this.CurrentTopping} weight should be in the range [{minToppingWeight}..{maxToppingWeight}].");
                }
                this.weight = value;
            }
        }

        public string CurrentTopping
        {
            get
            {
                return this.currentTopping;
            }
            private set
            {
                if (!defaultToppings.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.currentTopping = value;
            }
        }

        public double ToppingCaloriesPerGram => (baseCaloriesPerGram * this.Weight) * this.defaultToppings[this.CurrentTopping.ToLower()];

    }
}
