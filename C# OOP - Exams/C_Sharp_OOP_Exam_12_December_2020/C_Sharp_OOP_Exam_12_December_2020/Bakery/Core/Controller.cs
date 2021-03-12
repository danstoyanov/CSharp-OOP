using System;
using System.Collections.Generic;

using Bakery.Models.Drinks;
using Bakery.Models.BakedFoods;
using Bakery.Utilities.Messages;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;
using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Tables;

namespace Bakery.Core.Contracts
{
    public class Controller : IController
    {
        private List<IBakedFood> bakedFoods;
        private List<IDrink> drinks;
        private List<ITable> tables;

        public Controller()
        {
            this.bakedFoods = new List<IBakedFood>();
            this.drinks = new List<IDrink>();
            this.tables = new List<ITable>();
        }

        public string AddDrink(string type, string name, int portion, string brand)
        {
            if (type == "Water")
            {
                this.drinks.Add(new Water(name, portion, brand));
            }
            else if (type == "Tea")
            {
                this.drinks.Add(new Tea(name, portion, brand));
            }
            else
            {
                throw new ArgumentException("Invalid drink type !");
            }

            return string.Format(OutputMessages.DrinkAdded, name, type);
        }

        public string AddFood(string type, string name, decimal price)
        {
            if (type == "Bread")
            {
                this.bakedFoods.Add(new Bread(name, price));
            }
            else if (type == "Cake")
            {
                this.bakedFoods.Add(new Cake(name, price));
            }
            else
            {
                throw new ArgumentException("Invalid food type!");
            }

            return string.Format(OutputMessages.FoodAdded, name, type);
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            if (type == "InsideTable")
            {
                this.tables.Add(new InsideTable(tableNumber, capacity));
            }
            else if (type == "OutsideTable")
            {
                this.tables.Add(new OutsideTable(tableNumber, capacity));
            }
            else
            {
                throw new ArgumentException("Invalid table type!");
            }

            return string.Format(OutputMessages.TableAdded, tableNumber);
        }

        public string GetFreeTablesInfo()
        {
            throw new System.NotImplementedException();
        }

        public string GetTotalIncome()
        {
            throw new System.NotImplementedException();
        }

        public string LeaveTable(int tableNumber)
        {
            throw new System.NotImplementedException();
        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            throw new System.NotImplementedException();
        }

        public string OrderFood(int tableNumber, string foodName)
        {
            throw new System.NotImplementedException();
        }

        public string ReserveTable(int numberOfPeople)
        {
            throw new System.NotImplementedException();
        }
    }
}
