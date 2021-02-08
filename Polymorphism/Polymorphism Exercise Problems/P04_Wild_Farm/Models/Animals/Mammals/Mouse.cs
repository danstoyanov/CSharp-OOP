using P04_Wild_Farm.Models.Foods;

namespace P04_Wild_Farm.Models.Animals.Mammals
{
    public class Mouse : Mammal
    {
        private const double FOOD_PIECE_QUANTITY = 0.10;

        public Mouse(string name, double weight, string livigRegion) 
            : base(name, weight, livigRegion)
        {

        }

        public override string ProducingSound()
        {
            return "Squeak";
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Fruit" && food.GetType().Name != "Vegetable")
            {
                throw new System.Exception($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            this.FoodEaten += food.Quantity;
            this.Weight += (FOOD_PIECE_QUANTITY * food.Quantity);
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
