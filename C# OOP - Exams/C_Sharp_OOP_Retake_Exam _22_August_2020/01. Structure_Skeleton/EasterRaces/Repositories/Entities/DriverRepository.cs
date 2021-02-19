using System.Linq;
using System.Collections.Generic;

using EasterRaces.Repositories.Contracts;
using EasterRaces.Models.Drivers.Contracts;

namespace EasterRaces.Repositories.Entities
{
    public class DriverRepository : IRepository<IDriver>
    {
        private readonly List<IDriver> drivers;

        public DriverRepository()
        {
            this.drivers = new List<IDriver>();
        }

        public void Add(IDriver model) => this.drivers.Add(model);

        public IReadOnlyCollection<IDriver> GetAll() => this.drivers.ToArray();

        public IDriver GetByName(string name) => this.drivers.FirstOrDefault(d => d.Name == name);

        public bool Remove(IDriver model) => this.drivers.Remove(model);
    }
}
