using System.Collections.Generic;

namespace MilitaryElite.Contracts
{
    public interface ICommando : ISpecializedSoldier
    {
       IReadOnlyCollection<IMission> Missions { get; }

       void AddMission(IMission mission);
    }
}
