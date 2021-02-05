namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string favourriteFood) 
            : base(name, favourriteFood)
        {

        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + " DJAAF";
        }
    }
}
