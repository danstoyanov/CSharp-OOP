using System;
using System.Linq;
using System.Threading;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;


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
        public string FirstName // !
        {
            get => this.firstName;
            internal set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
            } 
        }
        public string LastName 
        {
            get => this.lastName;
            internal set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
            }
        }
        public int Age // ! 
        {
            get => this.age;
            internal set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
            }
        }
        public decimal Salary // ! 
        { 
            get => this.salary;
            internal set
            {
                if (value < 450)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
            }
        }

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
