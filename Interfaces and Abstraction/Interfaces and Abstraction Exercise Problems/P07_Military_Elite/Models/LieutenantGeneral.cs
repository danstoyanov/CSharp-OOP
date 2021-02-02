using System.Text;

using System.Collections.Generic;
using P07_Military_Elite.Contracts;
using P07_Military_Elite.Models.Soldiers;

namespace P07_Military_Elite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private ICollection<ISoldier> privates;

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<ISoldier>();
        }

        public IReadOnlyCollection<ISoldier> Privates => (IReadOnlyCollection<ISoldier>)this.privates;

        public void AddPrivate(ISoldier @private)
        {
            this.privates.Add(@private);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine("Privates:");

            foreach (var soldier in this.privates)
            {
                stringBuilder.AppendLine(soldier.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
