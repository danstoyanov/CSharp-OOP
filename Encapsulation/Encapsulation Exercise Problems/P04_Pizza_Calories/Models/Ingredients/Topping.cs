using System;
using System.Collections.Generic;

namespace P04_Pizza_Calories.Ingredients
{
    public class Topping
    {
        private const string INVALID_TOPPING_MSG = "Cannot place {0} on top of your pizza.";


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
                if (!DeffToppingModifires.ContainsKey(value))
                {
                    throw new ArgumentException();
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
                this.grams = value;
            }
        }
    }
}
