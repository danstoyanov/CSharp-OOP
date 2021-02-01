using System;

using P06_Food_Shortage.Contracts;

namespace P06_Food_Shortage.Models
{
    public class Pet : IPet, IBirthdates
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name { get; private set; }

        public string Birthdate { get; private set; }
    }
}
