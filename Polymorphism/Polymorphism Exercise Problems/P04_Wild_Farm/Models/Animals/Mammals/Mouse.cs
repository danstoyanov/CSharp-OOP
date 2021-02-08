namespace P04_Wild_Farm.Models.Animals.Mammals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livigRegion) 
            : base(name, weight, livigRegion)
        {

        }

        public override string ProducingSound()
        {
            return "Squeak";
        }
    }
}
