namespace P07_Military_Elite.Contracts
{
    public interface ISpecialisedSoldier : IPrivate
    {
        public Corps Corps { get; }
    }
}
