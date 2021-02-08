using P04_Wild_Farm.Contracts;

namespace P04_Wild_Farm.Models.Animals.Mammals.Felines
{
    public class Feline : Mammal, IFeline
    {
        public Feline(string name, double weight, string livigRegion, string breed) 
            : base(name, weight, livigRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; set; }

        public override string ProducingSound()
        {
            return base.ProducingSound();
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
