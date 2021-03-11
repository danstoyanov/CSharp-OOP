using System.Linq;
using System.Collections.Generic;

using CounterStrike.Models.Players;
using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players.Contracts;

namespace CounterStrike.Models.Maps
{
    public class Map : IMap
    {
        private List<IPlayer> terrorists;
        private List<IPlayer> counterTerrorists;

        public Map()
        {
            this.terrorists = new List<IPlayer>();
            this.counterTerrorists = new List<IPlayer>();
        }

        public string Start(ICollection<IPlayer> players)
        {
            SeparateTeams(players);

            while (IsTeamAlive(this.terrorists) && IsTeamAlive(this.counterTerrorists))
            {
                AttackTeam(this.terrorists, this.counterTerrorists);
                AttackTeam(this.counterTerrorists, this.terrorists);
            }

            if (IsTeamAlive(this.counterTerrorists))
            {
                return "Counter Terrorist wins!";
            }
            else if (IsTeamAlive(this.terrorists))
            {
                return "Terrorist wins!";
            }

            return "Something wrong is happened with my logic !!!";
        }

        private bool IsTeamAlive(List<IPlayer> players)
        {
            return players.Any(p => p.IsAlive);
        }

        private void SeparateTeams(ICollection<IPlayer> players)
        {
            foreach (var player in players)
            {
                if (player is CounterTerrorist)
                {
                    counterTerrorists.Add(player);
                }
                else if (player is Terrorist)
                {
                    terrorists.Add(player);
                }
            }
        }

        private void AttackTeam(List<IPlayer> attakingTeam, List<IPlayer> defendingTeam)
        {
            foreach (var attacker in attakingTeam)
            {
                if (!attacker.IsAlive)
                {
                    continue;
                }

                foreach (var defender in defendingTeam)
                {
                    if (defender.IsAlive)
                    {
                        defender.TakeDamage(attacker.Gun.Fire());
                    }
                }
            }
        }
    }
}
