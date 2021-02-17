using System;
using System.Collections.Generic;

using P04_Wild_Farm_Exercise_Lecture.Models.Foods.Contracts;

namespace P04_Wild_Farm_Exercise_Lecture.Models.Animals.Contracts
{
    public interface IFeedable
    {
        void Feed(IFood food);
        int FoodEaten { get; }
        double WeightMultiplier { get; }
        ICollection<Type> PreferredFoods { get; }
    }
}
