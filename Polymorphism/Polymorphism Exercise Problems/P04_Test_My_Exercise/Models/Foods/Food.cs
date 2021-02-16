using P04_Test_My_Exercise.Models.Contracts;

namespace P04_Test_My_Exercise.Models.Foods
{
    public abstract class Food : IFood
    {
        public Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; private set; }
    }
}
