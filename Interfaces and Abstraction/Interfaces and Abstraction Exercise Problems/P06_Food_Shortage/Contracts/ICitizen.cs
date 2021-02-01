using System;

namespace P06_Food_Shortage.Contracts
{
    public interface ICitizen
    {
        public string Name { get; }
        public string Age { get; }
        public string Id { get; }
    }
}
