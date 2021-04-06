using System;

namespace _05.DateModifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifier dateModifire = new DateModifier(firstDate, secondDate);

            Console.WriteLine(dateModifire.GetDifference(dateModifire.FirstDate, dateModifire.SecondDate));
        }
    }
}
