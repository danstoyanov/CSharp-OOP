namespace Animals
{
    public class Animal
    {
        public Animal(string name, string favourriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favourriteFood;
        }

        public string Name { get; set; }
        public string FavouriteFood { get; set; }
        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
        }
    }
}
