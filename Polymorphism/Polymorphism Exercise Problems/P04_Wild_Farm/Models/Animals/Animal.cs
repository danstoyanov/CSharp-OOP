using P04_Wild_Farm.Contracts;

namespace P04_Wild_Farm.Models.Animals
{
    public class Animal : IAnimal
    {
        public Animal(string name, double weight, int foodEaten)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = foodEaten;
        }

        public string Name { get; set; }

        public double Weight { get; set; }

        public int FoodEaten { get; set; }

        public virtual string ProducingSound()
        {
            throw new System.NotImplementedException();
        }
    }
}
