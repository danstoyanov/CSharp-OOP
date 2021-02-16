using P04_Test_My_Exercise.Models.Animals.Contracts;

namespace P04_Test_My_Exercise.Models.Animals
{
    public abstract class Mammal : Animal, IMammal
    {
        protected Mammal(string name, double weigth, string livingRegion)
            : base(name, weigth)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; private set; }
    }
}
