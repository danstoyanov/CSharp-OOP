using System;

namespace AuthorProblem
{

    [Author("Ventsi")]
    public class StartUp
    {

        [Author("Gosho")]
        static void Main()
        {
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }
    }
}
