namespace P03_Raiding.Models
{
    public class Druid : BaseHero
    {
        private const int HERO_POWER_POINTS = 80;

        public Druid(string name, int power) 
            : base(name, HERO_POWER_POINTS)
        {

        }
    }
}
