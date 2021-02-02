using System.Collections.Generic;

namespace P07_Military_Elite.Contracts
{
    public interface ICommando : ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission> Missions { get; }
    }
}
