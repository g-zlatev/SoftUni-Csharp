using System;

namespace MilitaryElite.Exceptions
{
    public class InvalidCorpsException : Exception
    {
        private const string defaultExceptionMessage = "Invalid corps!";

        public InvalidCorpsException() : base(defaultExceptionMessage)
        {
        }

        public InvalidCorpsException(string message) : base(message)
        {
        }
    }
}
