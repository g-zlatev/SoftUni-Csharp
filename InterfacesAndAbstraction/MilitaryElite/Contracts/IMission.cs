using MilitaryElite.Enumerations;

namespace MilitaryElite.Contracts
{
    public interface IMission
    {
        string CodeName { get; }

        States State { get; }

        void CompleteMission();
    }
}
