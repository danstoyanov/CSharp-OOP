using P06_Food_Shortage.Contracts;

namespace P06_Food_Shortage.Models
{
    public class Rebel : IRebel, IBuyer
    {
        private const int INCREASE_REBEL_FOOD = 5;

        public Rebel()
        {
            this.Food = 0;
        }

        public Rebel(string name, string age, string group)
            : this()
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public string Name { get; private set; }

        public string Age { get; private set; }

        public string Group { get; private set; }

        public int Food { get; set; }

        public void BuyFood() => this.Food += INCREASE_REBEL_FOOD;
    }
}
