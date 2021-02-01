using P05_Birthday_Celebrations.Contracts;

namespace P05_Birthday_Celebrations.Models
{
    public class Pet : IPet
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
