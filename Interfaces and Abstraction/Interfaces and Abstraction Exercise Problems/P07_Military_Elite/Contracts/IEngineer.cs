using System.Collections.Generic;

namespace P07_Military_Elite.Contracts
{
    public interface IEngineer : ISpecialisedSoldier
    {
        IReadOnlyCollection<IRepair> Repairs { get; }
    }
}
