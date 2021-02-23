using System;
using System.Reflection;

namespace Stealer
{
    public class StartUp
    {
        static void Main()
        {
            Spy spy = new Spy();

            string result = spy.StealFieldInfo("Stealer.Hacker", "username", "password");

            Console.WriteLine(result.ToString());

            // Stamo stop at => 2:35:44 !
        }
    }
}
