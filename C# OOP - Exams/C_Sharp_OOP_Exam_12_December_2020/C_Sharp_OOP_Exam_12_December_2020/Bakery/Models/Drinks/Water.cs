﻿namespace Bakery.Models.Drinks
{
    public class Water : Drink
    {
        private const decimal CURRENT_WATER_PRICE = 1.50m;

        public Water(string name, int portion, decimal CURRENT_WATER_PRICE, string brand) 
            : base(name, portion, CURRENT_WATER_PRICE, brand)
        {

        }
    }
}
