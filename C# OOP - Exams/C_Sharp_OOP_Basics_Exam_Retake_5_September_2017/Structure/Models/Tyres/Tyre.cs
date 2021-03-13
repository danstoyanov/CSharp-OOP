using Structure.Models.Tyres.Contracts;

namespace Structure.Models.Tyres
{
    public class Tyre : ITyres
    {
        public string Name { get; private set; }

        public double Hardness { get; private set; }

        public double Degradation { get; private set; }
    }
}
