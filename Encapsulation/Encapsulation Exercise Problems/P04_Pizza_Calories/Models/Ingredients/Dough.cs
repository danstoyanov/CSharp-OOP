using System;
using System.Collections.Generic;

using P04_Pizza_Calories.Common;

namespace P04_Pizza_Calories.Ingredients
{
    public class Dough
    {
        private const string INVALID_FLOUR_TYPE_MSG = "Invalid type of dough.";
        private const string INVALID_BAKING_TECH_MSG = "Invalid baking technique";
        private const int MIN_CAL_RANGE_EXC_VALUE = 1;
        private const int MAX_CAL_RANGE_EXC_VALUE = 200;
        private const string CAL_RANGE_EXC_MSG = "Dough weight should be in the range [1..200].";

        private readonly Dictionary<string, double> DeffFlourType = new Dictionary<string, double>()
        {
            {"white",1.5},
            {"wholegrain", 1.0 }
        };

        private readonly Dictionary<string, double> DeffBakingTechnique = new Dictionary<string, double>()
        {
            {"crispy", 0.9 },
            {"chewy", 1.1 },
            {"homemade", 1.0 }
        };

        private string flourType;
        private string bakingTechnique;
        private double grams;

        public Dough(string flourType, string bakingTechnique, double grams)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Grams = grams;
        }

        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            private set
            {
                if (!DeffFlourType.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(INVALID_FLOUR_TYPE_MSG);
                }

                this.flourType = value.ToLower();
            }
        }

        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            private set
            {
                if (!DeffBakingTechnique.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(INVALID_BAKING_TECH_MSG);
                }

                this.bakingTechnique = value.ToLower();
            }
        }

        public double Grams
        {
            get
            {
                return this.grams;
            }
            private set
            {
                if (value < MIN_CAL_RANGE_EXC_VALUE || value > MAX_CAL_RANGE_EXC_VALUE)
                {
                    throw new ArgumentException(CAL_RANGE_EXC_MSG);
                }

                this.grams = value;
            }
        }

        public double CaloriesPerGrams => GlobalConstants.BASE_CALORIES_PER_GRAM * DeffFlourType[this.FlourType] * DeffBakingTechnique[this.BakingTechnique];

        public double TotalCalories => this.CaloriesPerGrams * this.Grams;
    }
}
