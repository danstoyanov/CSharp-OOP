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

        public Person(string fistName, string lastName, int age, decimal salary)
            : this(fistName, lastName, age)
        {
            this.Salary = salary;
        }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public int Age { get; internal set; }
        public decimal Salary { get; set; }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age < 30)
            {
                this.Salary += this.Salary * percentage / 200;
            }
            else
            {
                this.Salary += this.Salary * percentage / 100;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:F2} leva.";
        }
    }
}
