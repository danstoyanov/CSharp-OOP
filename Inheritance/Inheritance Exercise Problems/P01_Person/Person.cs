namespace Person
{
    using System;

    public class Person
    {
        private string name;
        private int age;

        public Person()
        {

        }

        public Person(string name, int age)
            :this()
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public int Age
        {
            get => this.age;
            set => this.age = value;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
