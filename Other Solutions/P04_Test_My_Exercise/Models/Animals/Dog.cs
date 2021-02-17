namespace P04_Test_My_Exercise.Models.Animals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weigth, string livingRegion) 
            : base(name, weigth, livingRegion)
        {

        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
