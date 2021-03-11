
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;
using Bakery.Models.BakedFoods.Contracts;

namespace Bakery.Models.Tables
{
    public abstract class Table : ITable
    {
        public int TableNumber => throw new System.NotImplementedException();

        public int Capacity => throw new System.NotImplementedException();

        public int NumberOfPeople => throw new System.NotImplementedException();

        public decimal PricePerPerson => throw new System.NotImplementedException();

        public bool IsReserved => throw new System.NotImplementedException();

        public decimal Price => throw new System.NotImplementedException();

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public decimal GetBill()
        {
            throw new System.NotImplementedException();
        }

        public string GetFreeTableInfo()
        {
            throw new System.NotImplementedException();
        }

        public void OrderDrink(IDrink drink)
        {
            throw new System.NotImplementedException();
        }

        public void OrderFood(IBakedFood food)
        {
            throw new System.NotImplementedException();
        }

        public void Reserve(int numberOfPeople)
        {
            throw new System.NotImplementedException();
        }
    }
}
