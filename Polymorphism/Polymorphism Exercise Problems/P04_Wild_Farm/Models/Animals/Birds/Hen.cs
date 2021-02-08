using P04_Wild_Farm.Models.Foods;

namespace P04_Wild_Farm.Models.Animals.Birds
{
    public class Hen : Bird
    {
        private const double FOOD_PIECE_QUANTITY = 0.35;

        public Hen(string name, double weight, double windSize)
            : base(name, weight, windSize)
        {

        }

        public override string ProducingSound()
        {
            return "Cluck";
        }

        public override void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
            this.Weight += (FOOD_PIECE_QUANTITY * food.Quantity);
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
