using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using Bakery.Utilities.Messages;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;
using Bakery.Models.BakedFoods.Contracts;

namespace Bakery.Models.Tables
{
    public abstract class Table : ITable
    {
        private readonly List<IBakedFood> foods;
        private readonly List<IDrink> drinks;

        private int capacity;
        private int numberOfPeople;

        public Table(int tableNumber, int capacity, decimal pricePerPerson)
        {
            this.foods = new List<IBakedFood>();
            this.drinks = new List<IDrink>();

            this.TableNumber = tableNumber;
            this.Capacity = capacity;
            this.PricePerPerson = pricePerPerson;
        }

        public int TableNumber { get; }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidTableCapacity));
                }

                this.capacity = value;
            }
        }

        public int NumberOfPeople
        {
            get
            {
                return this.numberOfPeople;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidNumberOfPeople));
                }

                this.numberOfPeople = value;
            }
        }

        public decimal PricePerPerson { get; }

        public bool IsReserved { get; protected set; }

        public decimal Price => this.NumberOfPeople * this.PricePerPerson;

        public void Clear()
        {
            this.foods.Clear();
            this.drinks.Clear();

            this.IsReserved = false;
            this.NumberOfPeople = 0;
        }

        public decimal GetBill()
        {
            var foodsBillPrice = this.foods.Sum(f => f.Price);
            var drinksBillPrice = this.drinks.Sum(d => d.Price);
            var totalBillPrice = foodsBillPrice + drinksBillPrice + this.Price;

            return totalBillPrice;
        }

        public string GetFreeTableInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Table: {this.TableNumber}");
            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"Capacity: {this.Capacity}");
            sb.AppendLine($"Price per Person: {this.PricePerPerson}");

            return sb.ToString().Trim();
        }

        public void OrderDrink(IDrink drink)
        {
            this.drinks.Add(drink);
        }

        public void OrderFood(IBakedFood food)
        {
            this.foods.Add(food);
        }

        public void Reserve(int numberOfPeople)
        {
            this.NumberOfPeople = numberOfPeople;
            this.IsReserved = true;
        }
    }
}
