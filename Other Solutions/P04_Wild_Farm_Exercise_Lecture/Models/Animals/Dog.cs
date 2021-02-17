using System;
using System.Collections.Generic;

using P04_Wild_Farm_Exercise_Lecture.Models.Foods;

namespace P04_Wild_Farm_Exercise_Lecture.Models.Animals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livigRegion)
            : base(name, weight, livigRegion)
        {

        }

        public override double WeightMultiplier => 0.40;

        public override ICollection<Type> PreferredFoods => new List<Type>() 
        { 
            typeof(Meat) 
        };

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
