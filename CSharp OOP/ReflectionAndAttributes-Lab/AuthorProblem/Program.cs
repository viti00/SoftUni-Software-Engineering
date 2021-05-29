using System;

namespace AuthorProblem
{
    [Author("Gogi")]
    public class StartUp
    {
        static void Main(string[] args)
        {
            Tracker tracker = new Tracker();

            tracker.PrintMethodsByAuthor();
        }
        [Author("penyo")]
        public void SayHi()
        {

        }
        [Author("tanq")]
        public void SayBye()
        {

        }
    }
}
