using System;

namespace P03_Shopping_Spree
{
    public class Person
    {
        private const double MIN_MONEY_VALUE = 0;

        private string name;
        private double cost;

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
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public double Cost
        {
            get
            {
                return this.cost;
            }
            private set
            {
                if (value < MIN_MONEY_VALUE)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.cost = value;
            }
        }
    }
}
