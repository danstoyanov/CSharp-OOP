using P04_Wild_Farm.Models.Foods;

namespace P04_Wild_Farm.Models.Animals.Mammals.Felines
{
    public class Tiger : Feline
    {
        private const double FOOD_PIECE_QUANTITY = 1.00;

        public Tiger(string name, double weight, string livigRegion, string breed) 
            : base(name, weight, livigRegion, breed)
        {

        }

        public override string ProducingSound()
        {
            return "ROAR!!!";
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
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
