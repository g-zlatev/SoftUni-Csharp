using System.Collections.Generic;

namespace MilitaryElite.Contracts
{
    public interface IEngineer : ISpecializedSoldier
    {
        IReadOnlyCollection<IRepair> Repairs { get; }

        void AddRepair(IRepair repair);
    }
}
