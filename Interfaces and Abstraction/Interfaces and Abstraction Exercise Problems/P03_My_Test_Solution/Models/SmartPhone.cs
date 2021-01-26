using System.Linq;

using P03_Telephony.Contracts;
using P03_Telephony.Exceptions;

namespace P03_Telephony
{
    public class SmartPhone : ICallable, IBrowsable
    {
        public string Call(string number)
        {
            if (!number.All(c => char.IsDigit(c)))
            {
                throw new InvalidNumberException();
            }

            return $"Calling... {number}";
        }

        public string Browse(string url)
        {
            if (url.Any(c => char.IsDigit(c)))
            {
                throw new InvalidURLException();
            }

            return $"Browsing: {url}!";
        }
    }
}
