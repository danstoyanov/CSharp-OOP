using System;

using P04_Border_Control.Contracts;
using P05_Birthday_Celebrations.Contracts;

namespace P04_Border_Control.Models
{
    public class Citizen : ICitizen, IInhabitants, IBirthdates
    {
        public Citizen(string name, string age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Name { get; private set; }

        public string Age { get; private set; }

        public string Id { get; private set; }

        public string Birthdate { get; private set; }
    }
}
