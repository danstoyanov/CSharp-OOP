namespace Bakery.Models.BakedFoods
{
    public class Cake : BakedFood
    {
        private const int INITIAL_CAKE_PORTION = 245;

        public Cake(string name, int INITIAL_CAKE_PORTION, decimal price) 
            : base(name, INITIAL_CAKE_PORTION, price)
        {

        }
    }
}
