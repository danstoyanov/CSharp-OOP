using System.Collections.Generic;

using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players.Contracts;

namespace CounterStrike.Models.Maps
{
    public class Map : IMap
    {
        private List<IPlayer> terrorosits;
        private List<IPlayer> counterTerrorists;

        public Map()
        {
            this.terrorosits = new List<IPlayer>();
            this.counterTerrorists = new List<IPlayer>();
        }

        public string Start(ICollection<IPlayer> players)
        {
            throw new System.NotImplementedException();
        }
    }
}
