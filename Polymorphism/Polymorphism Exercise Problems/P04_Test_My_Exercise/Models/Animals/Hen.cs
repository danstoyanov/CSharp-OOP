namespace P04_Test_My_Exercise.Models.Animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weigth, double wingSize) 
            : base(name, weigth, wingSize)
        {

        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
