using P07_Military_Elite.Models;
using P07_Military_Elite.Contracts;
using System;

namespace P07_Military_Elite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Code Number: {this.CodeNumber}";
        }
    }
}
