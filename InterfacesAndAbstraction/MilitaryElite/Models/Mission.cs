using MilitaryElite.Contracts;
using MilitaryElite.Enumerations;
using MilitaryElite.Exceptions;
using System;

namespace MilitaryElite.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = this.TryParseState(state);
        }

        public string CodeName { get; private set; }

        public States State { get; private set;}

        public void CompleteMission()
        {
            if (this.State == States.Finished)
            {
                throw new InvalidMissionCompletionException();
            }

            this.State = States.Finished;
        }

        private States TryParseState(string stateStr)
        {
            States state;
            bool parsed = Enum.TryParse<States>(stateStr, out state);

            if (!parsed)
            {
                throw new InvalidStateException();
            }

            return state;
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State.ToString()}";
        }
    }
}
