using P04_Wild_Farm.Contracts;

namespace P04_Wild_Farm.Models.Foods
{
    public class Food : IFood
    {
        public Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; set; }
    }
}
