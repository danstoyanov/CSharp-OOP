namespace P03_Raiding.Models
{
    public class Paladin : BaseHero
    {
        private const int HERO_POWER_POINTS = 100;

        public Paladin(string name, int power) 
            : base(name, HERO_POWER_POINTS)
        {
            this.Power = HERO_POWER_POINTS;
        }

        public override string CastAbility()
        {
            return base.CastAbility() + $"{this.Name} healed for {this.Power}";
        }
    }
}
