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
            return string.Format("I am {0} and my fovourite food is {1}", this.Name, this.FavouriteFood);
        }
    }
}
