using System;

using P03_Shopping_Spree_Second_Solution.Common;

namespace P03_Shopping_Spree_Second_Solution.Models
{
    public class Product
    {
        private const decimal MIN_VALUE = 0;

        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
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
                    throw new ArgumentException(GlobalConstants.INVALID_NAME_MSG_EXC);
                }

                this.name = value;
            }
        }

        public decimal Cost
        {
            get
            {
                return this.cost;
            }
            private set
            {
                if (value < MIN_VALUE)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.cost = value;
            }
        }
    }
}
