using System;
using System.Collections.Generic;

using P04_Pizza_Calories.Ingredients;

namespace P04_Pizza_Calories
{
    public class Pizza
    {
        private const int MIN_NAME_SYMBOLS = 1;
        private const int MAX_NAME_SYMBOLS = 15;
        private const int MAX_TOPPINGS_COUNT = 10;
        private const string INVALID_NAME_EXC_MSG = "Pizza name should be between 1 and 15 symbols.";
        private const string INVALID_TOPPINGS_COUNT_EXC_MSG = "Number of toppings should be in range [0..10].";

        private string name;
        private Dough dough;
        private readonly List<Topping> toppings;

        public string Name
        {
            get
            { 
                return name; 
            }
            private set 
            { 
                if (string.IsNullOrWhiteSpace(value) || value.Length < MIN_NAME_SYMBOLS || value.Length > MAX_NAME_SYMBOLS)
                {
                    throw new ArgumentException(INVALID_NAME_EXC_MSG);
                }

                name = value; 
            }
        }

        public Dough Dough
        {
            get 
            { 
                return this.dough; 
            }
            private set 
            { 
                dough = value; 
            }
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count == MAX_TOPPINGS_COUNT)
            {
                throw new ArgumentException(INVALID_TOPPINGS_COUNT_EXC_MSG);
            }

            this.toppings.Add(topping);
        }
    }
}
