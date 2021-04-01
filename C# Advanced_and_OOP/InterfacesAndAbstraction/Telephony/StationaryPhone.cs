using System;
using System.Linq;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {

        public StationaryPhone()
        {

        }


        public string Call(string number)
        {
            if (!number.All(ch => char.IsDigit(ch)))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Dialing... {number}";
        }
    }
}
