namespace P06_Food_Shortage.Contracts
{
    public interface IBuyer
    {
        public string Name { get; }

        public int Food { get; }

        void BuyFood()
        {

        }
    }
}
