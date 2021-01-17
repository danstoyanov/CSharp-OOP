using System;
using System.Collections.Generic;

namespace P03_Shopping_Spree
{
    public class Product
    {
        private const double MIN_COST_VALUE = 0;

        private string name;
        private double money;

        public Product(string name, double money)
        {
            this.Name = name;
            this.Money = money;
        }

       public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.name = value;
            }
        }

        public double Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < MIN_COST_VALUE)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        // Bag with Products !!! 
    }
}
