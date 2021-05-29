
using System;

namespace AuthorProblem
{
    [Author("Venci")]
    public class StartUp
    {
        [Author("Gosho")]
        public static void Main(string[] args)
        {
            var tracker = new Tracker();

            tracker.PrintMethodsByAuthor();
        }
    }
}
