namespace Structure.Models.Tyres.Contracts
{
    public interface ITyres
    {
        string Name { get; }
        double Hardness { get; }
        double Degradation { get; }
    }
}
