namespace P04_Wild_Farm_Exercise_Lecture.Models.Animals
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name, double weight, string livigRegion) 
            : base(name, weight)
        {
            this.LivingRegion = livigRegion;
        }

        public string LivingRegion { get; }

        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
