namespace P04_Wild_Farm.Models.Animals.Birds
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double windSize) 
            : base(name, weight, windSize)
        {

        }

        public override string ProducingSound()
        {
            return "Hoot Hoot";
        }
    }
}
