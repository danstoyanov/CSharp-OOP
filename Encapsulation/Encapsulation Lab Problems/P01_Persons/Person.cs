namespace PersonsInfo
{
    public class Person
    {
        public Person()
        {

        }

        public Person(string fistName, string lastName, int age)
            : this()
        {
            this.FirstName = fistName;
            this.LastName = lastName;
            this.Age = age;
        }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public int Age { get; internal set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
        }
    }
}
