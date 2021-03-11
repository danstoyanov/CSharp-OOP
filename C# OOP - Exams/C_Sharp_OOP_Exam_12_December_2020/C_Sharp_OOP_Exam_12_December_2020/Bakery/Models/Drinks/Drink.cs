﻿using System;

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
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidPortion));
                }

                this.portion = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidPrice));
                }

                this.price = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidBrand));
                }

                this.brand = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Brand} - {this.Portion}ml - {this.Price:F2}lv";
        }
    }
}
