namespace P04_Wild_Farm.Contracts
{
    public interface IAnimal
    {
        public string Name { get; }
        public double Weight { get; }
        public int FoodEaten { get; }

        string ProducingSound();
    }
}
