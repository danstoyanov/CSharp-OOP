using P04_Wild_Farm.Models.Foods;

namespace P04_Wild_Farm.Models.Animals.Mammals
{
    public class Dog : Mammal
    {
        private const double FOOD_PIECE_QUANTITY = 0.40;

        public Dog(string name, double weight, string livigRegion) 
            : base(name, weight, livigRegion)
        {

        }

        public override string ProducingSound()
        {
            return "Woof!";
        }

        public void Eat(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                throw new System.Exception($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            this.FoodEaten += food.Quantity;
            this.Weight += (FOOD_PIECE_QUANTITY * food.Quantity);
        }

        public override string ToString()
        {
            return $"{this.GetType()} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
