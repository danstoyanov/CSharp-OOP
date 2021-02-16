using P04_Test_My_Exercise.Core;
using P04_Test_My_Exercise.Core.Contracts;

namespace P04_Test_My_Exercise
{
    public class StartUp
    {
        static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
