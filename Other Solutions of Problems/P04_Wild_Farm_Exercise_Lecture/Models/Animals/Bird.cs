namespace P04_Wild_Farm_Exercise_Lecture.Models.Animals
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, double wingsize) 
            : base(name, weight)
        {
            this.WingSize = wingsize;
        }

        public double WingSize { get; }

        public override string ToString()
        {
            return base.ToString() + $"{this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
