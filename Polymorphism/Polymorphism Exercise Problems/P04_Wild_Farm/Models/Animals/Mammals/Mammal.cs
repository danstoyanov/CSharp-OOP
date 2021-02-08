using P04_Wild_Farm.Contracts;

namespace P04_Wild_Farm.Models.Animals.Mammals
{
    public class Mammal : Animal, IMammal
    {
        public Mammal(string name, double weight, string livigRegion) 
            : base(name, weight)
        {
            this.LivingRegion = livigRegion;
        }

        public string LivingRegion { get; set; }

        public override string ProducingSound()
        {
            return base.ProducingSound();
        }

        public override string ToString()
        {
            return $"{this.GetType()} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
