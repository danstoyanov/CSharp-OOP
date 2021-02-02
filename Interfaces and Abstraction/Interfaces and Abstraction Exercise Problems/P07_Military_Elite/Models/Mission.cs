using P07_Military_Elite.Contracts;
using P07_Military_Elite.Core;
using System;

namespace P07_Military_Elite.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; private set; }

        public State State { get; private set; }

        public void CompleteMission()
        {
            throw new System.NotImplementedException();
        }

        private State TryParseState(string stateStr)
        {
            State state;
            bool parsed = Enum.TryParse<State>(stateStr, out state);

            if (!parsed)
            {
                throw new
            }

            return state;
        }
    }
}
