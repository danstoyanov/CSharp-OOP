using P03_Raiding.Contracts;

namespace P03_Raiding.Models
{
    public class BaseHero : IBaseHero
    {
        public string Name => throw new System.NotImplementedException();

        public int Power => throw new System.NotImplementedException();
    }
}
