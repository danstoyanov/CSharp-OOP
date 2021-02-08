namespace P04_Wild_Farm.Models.Animals.Birds
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double windSize) 
            : base(name, weight, windSize)
        {

        }

        public override string ProducingSound()
        {
            return "Cluck";
        }
    }
}
