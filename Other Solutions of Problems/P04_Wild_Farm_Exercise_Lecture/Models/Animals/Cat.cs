using System;
using System.Collections.Generic;

using P04_Wild_Farm_Exercise_Lecture.Models.Foods;

namespace P04_Wild_Farm_Exercise_Lecture.Models.Animals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livigRegion, string breed) 
            : base(name, weight, livigRegion, breed)
        {

        }

        public override double WeightMultiplier => 0.30;

        public override ICollection<Type> PreferredFoods => new List<Type>() 
        {
            typeof(Vegetable), typeof(Meat) 
        };

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
