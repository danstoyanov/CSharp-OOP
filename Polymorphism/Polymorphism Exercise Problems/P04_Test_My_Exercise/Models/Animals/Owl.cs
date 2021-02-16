namespace P04_Test_My_Exercise.Models.Animals
{
    public class Owl : Bird
    {
        public Owl(string name, double weigth, double wingSize) 
            : base(name, weigth, wingSize)
        {

        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
