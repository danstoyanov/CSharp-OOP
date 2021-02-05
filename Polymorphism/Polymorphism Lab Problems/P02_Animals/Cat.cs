using System;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string favourriteFood) 
            : base(name, favourriteFood)
        {

        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "MEEOW";
        }
    }
}
