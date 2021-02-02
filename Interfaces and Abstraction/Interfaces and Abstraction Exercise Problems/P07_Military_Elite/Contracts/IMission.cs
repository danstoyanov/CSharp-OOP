using P07_Military_Elite.Core;

namespace P07_Military_Elite.Contracts
{
    public interface IMission
    {
        string CodeName { get; }
        State state { get; }
        void CompleteMission();
    }
}
