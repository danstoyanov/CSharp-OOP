namespace P04_Wild_Farm.Models.Animals.Mammals.Felines
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livigRegion, string breed) 
            : base(name, weight, livigRegion, breed)
        {

        }

        public override string ProducingSound()
        {
            return "ROAR!!!";
        }
    }
}
