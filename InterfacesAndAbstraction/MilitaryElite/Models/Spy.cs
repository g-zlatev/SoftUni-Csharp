using MilitaryElite.Contracts;
using System;

namespace MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstname, string lastname, int codeNum) : base(id, firstname, lastname)
        {
            this.CodeNumber = codeNum;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            return $"{base.ToString()} {Environment.NewLine} Code Number: {this.CodeNumber}";
        }
    }
}
