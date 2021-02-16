using System;
using System.Collections.Generic;

using P04_Wild_Farm_Exercise_Lecture.Models.Foods;

namespace P04_Wild_Farm_Exercise_Lecture.Models.Animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingsize)
            : base(name, weight, wingsize)
        {

        }

        public override double WeightMultiplier => 0.35;

        public override ICollection<Type> PreferredFoods => new List<Type>() 
        { 
            typeof(Vegetable), typeof(Fruit), typeof(Meat), typeof(Seeds) 
        };

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
