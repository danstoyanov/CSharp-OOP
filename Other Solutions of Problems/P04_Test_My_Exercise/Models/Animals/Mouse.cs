using System;
using System.Collections.Generic;

using P04_Test_My_Exercise.Models.Foods;

namespace P04_Test_My_Exercise.Models.Animals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weigth, string livingRegion)
            : base(name, weigth, livingRegion)
        {

        }

        public override double WeightMultiplier => 0.10;

        public override ICollection<Type> PrefferedFooods => new List<Type>()
        {
            typeof(Vegetable), typeof(Fruit)
        };

        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}
