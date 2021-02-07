using P03_Raiding.Contracts;

namespace P03_Raiding.Models
{
    public class BaseHero : IBaseHero
    {
        public string Name { get; private set; }

        public int Power { get; private set; }
    }
}
