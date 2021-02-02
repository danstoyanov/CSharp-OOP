
using P07_Military_Elite.Contracts;
using P07_Military_Elite.Models.Soldiers;
using System.Collections.Generic;

namespace P07_Military_Elite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private ICollection<IPrivate> privates;

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<IPrivate>();
        }

        public IReadOnlyCollection<IPrivate> Privates => (IReadOnlyCollection<IPrivate>)this.privates;

        public void AddPrivate(IPrivate @private)
        {
            this.privates.Add(@private);
        }
    }
}
