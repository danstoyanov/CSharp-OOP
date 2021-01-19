using System;
using System.Collections.Generic;

using P03_Shopping_Spree_Second_Solution.Common;

namespace P03_Shopping_Spree_Second_Solution.Models
{
    public class Person
    {
        private const decimal MIN_VALUE = 0;

        private string name;
        private decimal money;
        private HashSet<Product> bag;

        private Person()
        {
            this.bag = new HashSet<Product>();
        }

        public Person(string name, decimal money)
            : this()
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
                    throw new ArgumentException(GlobalConstants.INVALID_NAME_MSG_EXC);
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < MIN_VALUE)
                {
                    throw new ArgumentException(GlobalConstants.MONEY_INVALID_MSG_EXC);
                }

                this.money = value;
            }
        }

        public HashSet<Product> Bag
        {
            get
            {
                return this.bag;
            }
        }

        public bool Buying(Product product)
        {
            if (this.Money < product.Cost)
            {
                throw new ArgumentException();
            }

            this.Money -= product.Cost;
            this.bag.Add(product);

            return true;
        }
    }
}