namespace P04_Wild_Farm_Exercise_Lecture.Models.Animals
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight, string livigRegion, string breed)
            : base(name, weight, livigRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
