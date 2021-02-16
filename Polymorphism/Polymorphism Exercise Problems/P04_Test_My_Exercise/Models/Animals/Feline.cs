using P04_Test_My_Exercise.Models.Animals.Contracts;

namespace P04_Test_My_Exercise.Models.Animals
{
    public abstract class Feline : Mammal, IFeline
    {
        protected Feline(string name, double weigth, string livingRegion, string breed)
            : base(name, weigth, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; private set; }
    }
}
