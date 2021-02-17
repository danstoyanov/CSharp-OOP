using System;

using System.Collections.Generic;
using P04_Test_My_Exercise.Models.Contracts;

namespace P04_Test_My_Exercise.Models.Animals.Contracts
{
    public interface IFeedable
    {
        void Feed(IFood food);

        int FoodEaten { get; }

        double WeightMultiplier { get; }

        ICollection<Type> PrefferedFooods { get; }
    }
}
