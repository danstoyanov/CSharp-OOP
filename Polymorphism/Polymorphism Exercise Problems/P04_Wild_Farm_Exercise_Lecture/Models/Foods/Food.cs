using P04_Wild_Farm_Exercise_Lecture.Models.Foods.Contracts;

namespace P04_Wild_Farm_Exercise_Lecture.Models.Foods
{
    public abstract class Food : IFood
    {
        public Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; }
    }
}
