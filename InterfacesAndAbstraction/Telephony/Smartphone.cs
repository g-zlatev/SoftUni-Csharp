using System;
using System.Linq;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowseable
    {

        public Smartphone()
        {
                
        }


        public string Call(string number)
        {
            if (!number.All(ch => char.IsDigit(ch)))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Calling... {number}";
        }

        public string Browse(string website)
        {
            if (website.Any(ch=> char.IsDigit(ch)))
            {
                throw new Exception("Invalid URL!");
            }

            return $"Browsing: {website}!";
        }


    }
}
