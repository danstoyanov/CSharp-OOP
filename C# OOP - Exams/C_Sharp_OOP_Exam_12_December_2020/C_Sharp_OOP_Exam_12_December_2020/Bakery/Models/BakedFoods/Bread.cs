namespace Bakery.Models.BakedFoods
{
    public class Bread : BakedFood
    {
        private const int INITIAL_BREAD_PORTION = 200;

        public Bread(string name, int INITIAL_BREAD_PORTION, decimal price) 
            : base(name, INITIAL_BREAD_PORTION, price)
        {

        }
    }
}
