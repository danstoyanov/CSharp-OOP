using System;

using Bakery.Utilities.Messages;
using Bakery.Models.Drinks.Contracts;

namespace Bakery.Models.Drinks
{
    public abstract class Drink : IDrink
    {
        private string name;
        private int portion;
        private decimal price;
        private string brand;

        public Drink(string name, int portion, decimal price, string brand)
        {
            this.Name = name;
            this.Portion = portion;
            this.Price = price;
            this.Brand = brand;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidName));
                }

                this.name = value;
            }
        }

        public int Portion
        {
            get
            {
                return this.portion;
            }
            protected set
            {

            }
        }

        public decimal Price => throw new System.NotImplementedException();

        public string Brand => throw new System.NotImplementedException();
    }
}
