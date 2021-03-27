namespace Bakery
{
    using Bakery.Core;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Don't forget to comment out the commented code lines in the Engine class!

            var test_Repo = "Test";

            var engine = new Engine();
            engine.Run();
        }
    }
}
