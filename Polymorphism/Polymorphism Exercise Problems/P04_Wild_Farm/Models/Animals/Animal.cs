using P04_Wild_Farm.Contracts;
using P04_Wild_Farm.Models.Foods;

namespace P04_Wild_Farm.Models.Animals
{
    public class Animal : IAnimal
    {
        public Animal()
        {

        }

        public Animal(string name, double weight)
            : this()
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = 0;
        }

        public string Name { get; set; }

        public double Weight { get; set; }

        public int FoodEaten { get; set; }

        public virtual void Eat(Food food)
        {
            throw new System.NotImplementedException();
        }

        public virtual string ProducingSound()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
