using P04_Test_My_Exercise.Models.Animals.Contracts;

namespace P04_Test_My_Exercise.Models.Animals
{
    public abstract class Bird : Animal, IBird
    {
        protected Bird(string name, double weigth, double wingSize)
            : base(name, weigth)
        {
            this.WingSize = wingSize;
        }

        public double WingSize { get; private set; }
    }
}
