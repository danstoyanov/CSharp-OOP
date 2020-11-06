namespace Person
{
    using System;

    public class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
