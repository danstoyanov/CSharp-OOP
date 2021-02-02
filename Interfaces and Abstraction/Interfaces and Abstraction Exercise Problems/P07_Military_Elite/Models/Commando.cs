using P07_Military_Elite.Contracts;
using System.Collections.Generic;
using System.Text;

namespace P07_Military_Elite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private ICollection<IMission> missions;

        public Commando(int id, string firstName, string lastName, decimal salary, string corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.missions = new List<IMission>();
        }

        public IReadOnlyCollection<IMission> Missions => (IReadOnlyCollection<IMission>)this.missions;

        public void AddMission(IMission mission)
        {
            this.missions.Add(mission);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine("Missions:");

            foreach (var miss in this.missions)
            {
                stringBuilder.AppendLine(miss.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
