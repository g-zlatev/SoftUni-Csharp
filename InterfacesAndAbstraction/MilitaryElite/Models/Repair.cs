using MilitaryElite.Contracts;
using System.Dynamic;

namespace MilitaryElite.Models
{
    public class Repair : IRepair
    {
        public Repair(string partName, int hours)
        {
            this.PartName = partName;
            this.HoursWorked = hours;
        }

        public string PartName { get; private set; }
        public int HoursWorked { get; private set; }

    };

}

