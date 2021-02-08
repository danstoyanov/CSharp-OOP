using P04_Wild_Farm.Models.Foods;

namespace P04_Wild_Farm.Models.Animals.Mammals.Felines
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livigRegion, string breed) 
            : base(name, weight, livigRegion, breed)
        {

        }

        public override string ProducingSound()
        {
            return "Meow";
        }

        public void Eat (Food food)
        {
            if (food.GetType().Name != "Meso")
            {
                // exeption
            }

            // foodEaten += food.Quantity;
            // this.Weight += (CONST_VALUE * food.Quantity);

            // cat eats ! 
        }
    }
}
