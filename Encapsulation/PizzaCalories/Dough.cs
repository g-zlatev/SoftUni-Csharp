using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Dough
    {
        private const double BaseCaloriesPerGram = 2;
        private const double weightMinValue = 1;
        private const double weightMaxValue = 200;

        private readonly Dictionary<string, double> flourTypes = new Dictionary<string, double>()
        {
            {"white", 1.5 },
            {"wholegrain", 1.0}
        };

        private readonly Dictionary<string, double> bakingTechniques = new Dictionary<string, double>()
        {
            {"crispy", 0.9},
            {"chewy", 1.1},
            {"homemade", 1.0}
        };


        private double weight;
        private string bakingTechnique;
        private string flourType;


        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }


        public string FlourType
        {
            get
            {
                return flourType;
            }
            private set
            {
                if (!flourTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value;
            }
        }


        public string BakingTechnique
        {
            get 
            {
                return this.bakingTechnique; 
            }
            private set 
            {
                if (!this.bakingTechniques.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value; 
            }
        }


        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value < weightMinValue || value > weightMaxValue)
                {
                    throw new ArgumentException($"Dough weight should be in the range[{weightMinValue}..{weightMaxValue}].");
                }
                this.weight = value;
            }

        }

        public double CalculateDoughCalories => (BaseCaloriesPerGram * this.Weight) * this.flourTypes[this.FlourType.ToLower()] * this.bakingTechniques[this.BakingTechnique.ToLower()];

    }
}
