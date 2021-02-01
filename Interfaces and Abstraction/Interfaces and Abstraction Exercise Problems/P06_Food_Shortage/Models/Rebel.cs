using P06_Food_Shortage.Contracts;

namespace P06_Food_Shortage.Models
{
    public class Rebel : IRebel
    {
        public string Name { get; private set; }

        public string Age { get; private set; }

        public string Group { get; private set; }
    }
}
