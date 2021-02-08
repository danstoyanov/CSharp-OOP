using P04_Wild_Farm.Contracts;

namespace P04_Wild_Farm.Models.Animals.Birds
{
    public class Bird : Animal, IBird
    {
        public Bird(string name, double weight, double windSize) 
            : base(name, weight)
        {
            this.WingSize = windSize;
        }

        public double WingSize { get; set; }

        public override string ProducingSound()
        {
            return base.ProducingSound();
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
