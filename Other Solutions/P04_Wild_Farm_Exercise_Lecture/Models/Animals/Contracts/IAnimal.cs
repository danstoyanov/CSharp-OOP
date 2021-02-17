namespace P04_Wild_Farm_Exercise_Lecture.Models.Animals.Contracts
{
    public interface IAnimal
    {
        string Name { get; }
        double Weight { get; }
        int FoodEaten { get; }
    }
}
