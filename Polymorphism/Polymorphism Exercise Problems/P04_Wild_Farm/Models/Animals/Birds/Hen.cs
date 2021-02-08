namespace P04_Wild_Farm.Models.Animals.Birds
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, int foodEaten, double windSize) 
            : base(name, weight, foodEaten, windSize)
        {

        }

        public override string ProducingSound()
        {
            return "Cluck";
        }
    }
}
