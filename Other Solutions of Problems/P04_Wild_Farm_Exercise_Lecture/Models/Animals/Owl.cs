using System;
using System.Collections.Generic;

using P04_Wild_Farm_Exercise_Lecture.Models.Foods;

namespace P04_Wild_Farm_Exercise_Lecture.Models.Animals
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingsize) 
            : base(name, weight, wingsize)
        {
            
        }

        public override double WeightMultiplier => 0.25;

        public override ICollection<Type> PreferredFoods => new List<Type>() 
        { 
            typeof(Meat) 
        };

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
