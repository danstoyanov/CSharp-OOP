using System;
using System.Collections.Generic;

using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Repositories.Contracts;
using CounterStrike.Utilities.Messages;

namespace CounterStrike.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
        private List<IGun> models;

        public GunRepository()
        {
            this.models = new List<IGun>();
        }

        public IReadOnlyCollection<IGun> Models
        {
            get
            {
                return this.models.AsReadOnly();
            }
        }

        public void Add(IGun model)
        {
            if (model == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidGunRepository));
            }


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
