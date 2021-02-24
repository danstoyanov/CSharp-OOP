using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace ValidationAttributes.Entitys
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            // *NEW ==> Just Debug !

            Type objType = obj.GetType();
            PropertyInfo[] propertyInfos = objType.GetProperties();
             
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                List<MyValidationAttribute> allMyAttributes = propertyInfo.GetCustomAttributes<MyValidationAttribute>().ToList();

                object propertyObj = propertyInfo.GetValue(obj);

                foreach (MyValidationAttribute myValidationAttribute in allMyAttributes)
                {
                    bool isValid = myValidationAttribute.IsValid(propertyObj);

                    if (!isValid)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
