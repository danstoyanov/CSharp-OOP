using P04_Wild_Farm.Models.Foods;

namespace P04_Wild_Farm.Models.Animals.Birds
{
    public class Owl : Bird
    {
        private const double FOOD_PIECE_QUANTITY = 0.25;

        public Owl(string name, double weight, double windSize) 
            : base(name, weight, windSize)
        {

        }

        public override string ProducingSound()
        {
            return "Hoot Hoot";
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
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
