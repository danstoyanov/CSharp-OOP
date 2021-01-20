namespace P04_Pizza_Calories
{
    public class Pizza
    {
        private string name;
        private string dough;
        private string toppings;

        public Pizza(string name, string dough, string toppings)
        {
            this.Name = name;
            this.Dough = dough;
            this.Toppings = toppings;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public string Dough
        {
            get
            {
                return this.dough;
            }
            private set
            {
                this.dough = value;
            }
        }

        public string Toppings
        {
            get
            {
                return this.toppings;
            }
            private set
            {
                this.toppings = value;
            }
        }
    }
}
