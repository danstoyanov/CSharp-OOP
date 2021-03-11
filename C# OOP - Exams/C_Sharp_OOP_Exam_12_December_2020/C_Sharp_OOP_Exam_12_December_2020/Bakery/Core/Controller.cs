namespace Bakery.Core.Contracts
{
    public class Controller : IController
    {
        public string AddDrink(string type, string name, int portion, string brand)
        {
            throw new System.NotImplementedException();
        }

        public string AddFood(string type, string name, decimal price)
        {
            throw new System.NotImplementedException();
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            throw new System.NotImplementedException();
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
