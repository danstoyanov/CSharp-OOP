using System;

namespace ValidationAttributes.Attributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue;
        private int maxValue;

        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public override bool IsValid(object obj)
        {
            // *NEW Here we must convert the obj value, because is inpossible to compare the object in C# !
            int intObj = Convert.ToInt32(obj);

            if (intObj >= this.minValue && intObj <= this.maxValue)
            {
                return true;
            }

            // return intObj >= this.minValue && intObj <= this.maxValue;
            return false;
        }
    }
}
