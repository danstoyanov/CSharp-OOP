namespace P04_Wild_Farm.Models.Animals.Mammals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livigRegion) 
            : base(name, weight, livigRegion)
        {

        }

        public override string ProducingSound()
        {
            return "Woof!";
        }
    }
}
