using P04_Wild_Farm.Contracts;

namespace P04_Wild_Farm.Models.Animals.Mammals.Felines
{
    public class Feline : Mammal, IFeline
    {
        public Feline(string name, double weight, int foodEaten, string livigRegion) 
            : base(name, weight, foodEaten, livigRegion)
        {

        }

        public string Breed { get; set; }
    }
}
