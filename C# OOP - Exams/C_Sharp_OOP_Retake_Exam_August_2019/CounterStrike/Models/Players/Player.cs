using System;

using CounterStrike.Utilities.Messages;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Players.Contracts;

namespace CounterStrike.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string username;
        private int health;
        private int armor;
        private IGun gun;

        public Player(string username, int health, int armor, IGun gun)
        {
            this.Username = username;
            this.Health = health;
            this.Armor = armor;
            this.Gun = gun;
        }

        public string Username
        {
            get
            {
                return this.username;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidPlayerName));
                }

                this.username = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidPlayerHealth));
                }

                this.health = value;
            }
        }

        public int Armor
        {
            get
            {
                return this.armor;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidPlayerArmor));
                }

                this.armor = value;
            }
        }

        public IGun Gun
        {
            get
            {
                return this.gun;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidGun));
                }

                this.gun = value;
            }
        }

        bool IPlayer.IsAlive => throw new NotImplementedException();

        public bool IsAlive()
        {
            return this.Health != 0;
        }

        public void TakeDamage(int points) 
        {
            if (this.Armor - points >= 0)
            {
                this.Armor -= points;
                return;
            }
            else if (this.Armor > 0)
            {
                points -= this.Armor;
                this.Armor = 0;
            }

            this.Health -= points;
        }
    }
}
