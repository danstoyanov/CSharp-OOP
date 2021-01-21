using System;
using System.Collections.Generic;

namespace P04_Pizza_Calories.Ingredients
{
    public class Topping
    {
        private const string INVALID_TOPPING_MSG = "Cannot place {0} on top of your pizza.";
        private const double MIN_TOPPING_VALUE = 1;
        private const double MAX_TOPPING_VALUE = 50;
        private const string INVALID_VALUE_EXC_MSG = "{0} weight should be in the range [1..50].";

        private readonly Dictionary<string, double> DeffToppingModifires = new Dictionary<string, double>()
        {
            {"meat", 1.2 },
            {"veggies", 0.8 },
            {"cheese", 1.1 },
            {"sauce", 0.9 }
        };

        private string modifire;
        private double grams;

        public Topping(string modifire, double grams)
        {
            this.Modifire = modifire;
            this.Grams = grams;
        }

        public string Modifire
        {
            get
            {
                return this.modifire;
            }
            private set
            {
                if (!DeffToppingModifires.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(String.Format(INVALID_TOPPING_MSG, value));
                }

                this.modifire = value;
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
                    throw new ArgumentException(string.Format(INVALID_VALUE_EXC_MSG, this.Modifire));
                }

                this.grams = value;
            }
        }
    }
}
