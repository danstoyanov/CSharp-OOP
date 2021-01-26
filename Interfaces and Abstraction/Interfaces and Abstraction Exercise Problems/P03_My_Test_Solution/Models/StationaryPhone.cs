using System.Linq;

using P03_Telephony.Contracts;
using P03_Telephony.Exceptions;

namespace P03_Telephony.Models
{
    public class StationaryPhone : ICallable
    {
        public StationaryPhone()
        {

        }

        public string Call(string number)
        {
            if (! number.All(c => char.IsDigit(c)))
            {
                throw new InvalidNumberException();
            }

            return $"Dialing... {number}";
        }
    }
}
