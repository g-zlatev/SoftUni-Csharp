using MilitaryElite.Contracts;

namespace MilitaryElite.Models
{
    public class Private : Soldier, IPrivate
    {
        public Private(int id, string firstName, string lastname, decimal salary) : base(id, firstName, lastname)
        {
            Salary = salary;
        }

        public decimal Salary { get; private set; }

        public override string ToString()
        {
            return $"{}";
            //< firstName > < lastName > Id: < id > Salary: < salary >
        }
    }
}
