using System.Collections.Generic;
using MilitaryElite.Contracts;

namespace MilitaryElite.Models
{
    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        private ICollection<IPrivate> privates;


        public LeutenantGeneral(int id, string firstName, string lastname, decimal salary) : base(id, firstName, lastname, salary)
        {
            this.privates = new List<IPrivate>();
        }

        public IReadOnlyCollection<IPrivate> Privates => (IReadOnlyCollection<IPrivate>) this.privates;

        public void AddPrivate(IPrivate @private)
        {
            this.privates.Add(@private);
        }
    }
}
