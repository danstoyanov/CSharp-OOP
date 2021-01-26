using System.Linq;

using Telephony.Contracts;
using Telephony.Exeptions;

namespace Telephony.Models.Contracts
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
                throw new InvalidNumberException();
            }

            return $"Dialing... {number}";
        }
    }
}
