using System.Linq;

using Telephony.Contracts;
using Telephony.Exeptions;

namespace P03_Telephony
{
    public class Smartphone : ICallable, IBrowseable
    {
        public string Call(string number)
        {
            if (!number.All(ch => char.IsDigit(ch)))
            {
                throw new InvalidNumberException();
            }

            return $"Calling... {number}";
        }

        public string Browse(string url)
        {
            if (url.Any(ch => char.IsDigit(ch)))
            {
                throw new InvalidURLException();
            }

            return $"Browsing: {url}!";
        }
    }
}
