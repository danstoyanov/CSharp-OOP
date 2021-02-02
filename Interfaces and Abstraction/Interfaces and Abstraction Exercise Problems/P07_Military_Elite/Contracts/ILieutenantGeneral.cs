using System.Collections.Generic;

using P07_Military_Elite.Models.Soldiers;

namespace P07_Military_Elite.Contracts
{
    public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<ISoldier> Privates { get; }

        public void AddPrivate(ISoldier @private);
    }
}
