using P04_Border_Control.Contracts;

namespace P04_Border_Control.Models
{
    public class Citizen : ICitizen, IInhabitants
    {
        public Citizen(string name, string age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public string Name { get; private set; }

        public string Age { get; private set; }

        public string Id { get; private set; }
    }
}
