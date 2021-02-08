﻿using P04_Wild_Farm.Contracts;

namespace P04_Wild_Farm.Models.Animals.Mammals
{
    public class Mammal : Animal, IMammal
    {
        public Mammal(string name, double weight, int foodEaten, string livigRegion) 
            : base(name, weight, foodEaten)
        {
            this.LivingRegion = livigRegion;
        }

        public string LivingRegion { get; set; }
    }
}
