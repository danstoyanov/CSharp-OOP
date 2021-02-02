using System;

using P07_Military_Elite.Contracts;
using P07_Military_Elite.Exceptions;
using P07_Military_Elite.Models.Soldiers;

namespace P07_Military_Elite.Models
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = this.TryParseCorps(corps);
        }

        public Corps Corps { get; private set; }

        private Corps TryParseCorps (string corpsStr)
        {
            Corps corps;
            bool parsed = Enum.TryParse<Corps>(corpsStr, out corps);

            if (!parsed)
            {
                throw new InvalidCorpsException();
            }

            return corps;
        }
    }
}
