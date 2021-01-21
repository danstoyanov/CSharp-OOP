using System;
using System.Collections.Generic;

using P04_Pizza_Calories.Common;

namespace P04_Pizza_Calories.Ingredients
{
    public class Topping
    {
        private const double MIN_TOPPING_VALUE = 1;
        private const double MAX_TOPPING_VALUE = 50;
        private const string INVALID_VALUE_EXC_MSG = "{0} weight should be in the range [1..50].";
        private const string INVALID_TOPPING_MSG = "Cannot place {0} on top of your pizza.";

        private readonly Dictionary<string, double> DeffToppingModifires = new Dictionary<string, double>()
        {
            {"meat", 1.2 },
            {"veggies", 0.8 },
            {"cheese", 1.1 },
            {"sauce", 0.9 }
        };

        private string type;
        private double grams;

        public Topping(string type, double grams)
        {
            this.Type = type;
            this.Grams = grams;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                if (!DeffToppingModifires.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(String.Format(INVALID_TOPPING_MSG, value));
                }

                this.type = value;
            }
        }

        public double Grams
        {
            get
            {
                return this.grams;
            }
            private set
            {
                if (value < MIN_TOPPING_VALUE || value > MAX_TOPPING_VALUE)
                {
                    throw new ArgumentException(String.Format(INVALID_VALUE_EXC_MSG, this.Type));
                }

                this.grams = value;
            }
        }

        public double CaloriesPerGram => GlobalConstants.BASE_CALORIES_PER_GRAM * this.DeffToppingModifires[this.Type];
    }
}
