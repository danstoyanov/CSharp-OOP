using System;
using System.Collections.Generic;

using P04_Test_My_Exercise.Models.Foods;

namespace P04_Test_My_Exercise.Models.Animals
{
    public class Cat : Feline
    {
        public Cat(string name, double weigth, string livingRegion, string breed)
            : base(name, weigth, livingRegion, breed)
        {

        }

        public override double WeightMultiplier => 0.30;

        public override ICollection<Type> PrefferedFooods => new List<Type>()
        {
            typeof(Vegetable), typeof(Meat)
        };
        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
