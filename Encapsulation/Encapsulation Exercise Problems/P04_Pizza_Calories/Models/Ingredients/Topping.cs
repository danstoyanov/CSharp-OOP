using System.Collections.Generic;

namespace P04_Pizza_Calories.Ingredients
{
    public class Topping
    {
        private readonly Dictionary<string, double> DeffToppingModifires = new Dictionary<string, double>() 
        {
            {"Meat", 1.2 },
            {"Veggies", 0.8 },
            {"Cheese", 1.1 },
            {"Sauce", 0.9 }
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
