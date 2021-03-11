using System.Collections.Generic;

using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Repositories.Contracts;

namespace CounterStrike.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
        public IReadOnlyCollection<IGun> Models => throw new System.NotImplementedException();

        public void Add(IGun model)
        {
            throw new System.NotImplementedException();
        }

        public IGun FindByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(IGun model)
        {
            throw new System.NotImplementedException();
        }
    }
}
