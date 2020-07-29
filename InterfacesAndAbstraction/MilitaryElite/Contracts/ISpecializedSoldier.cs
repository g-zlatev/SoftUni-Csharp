using MilitaryElite.Enumerations;

namespace MilitaryElite.Contracts
{
    public interface ISpecializedSoldier : IPrivate
    {
        Corps  Corps {get;}
    }
}
