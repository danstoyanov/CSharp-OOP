namespace Bakery.Models.Drinks
{
    public class Tea : Drink
    {
        private const decimal CURRENT_TEA_PRICE = 2.50m;

        public Tea(string name, int portion, decimal CURRENT_TEA_PRICE, string brand) 
            : base(name, portion, CURRENT_TEA_PRICE, brand)
        {

        }
    }
}
