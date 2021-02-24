using System;

namespace ValidationAttributes
{
    // *NEW here we must type the atributes, who chek the Propertyes of the classes !!!
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public abstract class MyValidationAttribute : Attribute
    {
        public abstract bool IsValid(object obj);
    }
}
