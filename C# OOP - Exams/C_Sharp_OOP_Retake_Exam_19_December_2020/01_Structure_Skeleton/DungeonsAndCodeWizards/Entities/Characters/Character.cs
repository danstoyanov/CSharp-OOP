using System;

using WarCroft.Constants;
using WarCroft.Entities.Items;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
        private const double MIN_HEALTH_VALUE = 0;
        private double MAX_HEALTH_VALUE => this.BaseHealth;

        private string name;
        private double health;
        private double armor;

        protected Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {
            this.Name = name;
            this.Health = health;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            internal set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
                }

                this.name = value;
            }
        }

        public double BaseHealth { get; private set; }

        public double Health
        {
            get
            {
                return this.health;
            }
            internal set
            {
                if (value >= MIN_HEALTH_VALUE && value <= MAX_HEALTH_VALUE)
                {
                    this.health = value;
                }
            }
        }

        public double BaseArmor { get; private set; }

        public double Armor
        {
            get
            {
                return this.armor;
            }
            internal set
            {
                if (value >= 0)
                {
                    this.armor = value;
                }
            }
        }

        public double AbilityPoints { get; private set; }

        public Bag Bag { get; private set; }

        public bool IsAlive { get; set; } = true;

        protected void EnsureAlive()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }

        }
        public void TakeDamage(double hitPoints)
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }

            if (hitPoints > this.Armor)
            {
                hitPoints -= this.Armor;
                this.Armor = 0;

                if (this.Health >= hitPoints)
                {
                    this.Health -= hitPoints;
                }
                else
                {
                    this.Health = 0;
                    this.IsAlive = false;
                }
            }
            else
            {
                this.Armor -= hitPoints;
            }
        }

        public void UseItem(Item item)
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }

            item.AffectCharacter(this);
        }
    }
}