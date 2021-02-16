using System;
using System.Collections.Generic;

using P04_Test_My_Exercise.Models.Contracts;
using P04_Test_My_Exercise.Models.Animals.Contracts;

namespace P04_Test_My_Exercise.Models.Animals
{
    public abstract class Animal : IAnimal, IFeedable, ISoundProducable
    {
        protected Animal(string name, double weigth)
        {
            this.Name = name;
            this.Weight = weigth;
        }

        public string Name { get; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        public abstract double WeightMultiplier { get; }

        public abstract ICollection<Type> PrefferedFooods { get; }

        public void Feed(IFood food)
        {
            throw new NotImplementedException();
        }

        public abstract string ProduceSound();
    }
}
