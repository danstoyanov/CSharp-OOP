using P07_Military_Elite.Contracts;
using System.Collections.Generic;
using System.Text;

namespace P07_Military_Elite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private ICollection<IRepair> repairs;

        public Engineer(int id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.repairs = new List<IRepair>();
        }

        public IReadOnlyCollection<IRepair> Repairs => (IReadOnlyCollection<IRepair>)this.repairs;

        public void AddRepair(IRepair repair)
        {
            this.repairs.Add(repair);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine("Repairs:");

            foreach (var rep in this.repairs)
            {
                stringBuilder.AppendLine(rep.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
