using P04_Wild_Farm.Contracts;

namespace P04_Wild_Farm.Models.Animals.Birds
{
    public class Bird : Animal, IBird
    {
        public Bird(string name, double weight, int foodEaten, double windSize) 
            : base(name, weight, foodEaten)
        {
            this.WingSize = windSize;
        }

        public double WingSize { get; set; }

        public override string ProducingSound()
        {
            return base.ProducingSound();
        }
    }
}
