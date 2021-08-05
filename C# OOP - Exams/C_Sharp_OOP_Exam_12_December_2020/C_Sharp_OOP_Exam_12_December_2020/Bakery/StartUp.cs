namespace Bakery
{
    using Bakery.Core;

    public class StartUp
    {
        public static void Main()
        {
            var engine = new Engine();
            engine.Run();
        }

        private static void TestCode()
        {
            System.Console.WriteLine("We test the App !");
        }
    }
}
