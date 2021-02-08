namespace P03_Raiding.Models
{
    public class Warrior : BaseHero
    {
        private const int HERO_POWER_POINTS = 100;

        public Warrior(string name, int power) 
            : base(name, HERO_POWER_POINTS)
        {
            this.Power = HERO_POWER_POINTS;
        }

        public override string CastAbility()
        {
            return base.CastAbility() + $"{this.Name} hit for {this.Power} damage".ToString();
        }
    }
}
