using System;

namespace Reflection_Lecture_Demo
{
    [Author("Galin")]

    public class TestClass
    {
        private string secret = "MySecret";
        private bool isCreated = false;
        public string name;

        public TestClass()
        {
            isCreated = true;
        }

        public TestClass(string name)
            : this()
        {
            this.name = name;
        }

        public TestClass(string name, int age)
           : this(name)
        {
            this.Age = age;
        }

        public int Age { get; set; }

        public void WhoAmI()
        {
            Console.WriteLine(name);
        }

        public void TellMeASecret()
        {
            Console.WriteLine(secret);
        }
    }
}
