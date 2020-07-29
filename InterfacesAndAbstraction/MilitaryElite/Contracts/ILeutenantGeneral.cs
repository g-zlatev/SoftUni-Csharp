
using System.Collections.Generic;

namespace MilitaryElite.Contracts
{
    public interface ILeutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }

        void AddPrivate(IPrivate @private);
    }
}
