using System;

namespace _04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            double pagesForHour = double.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());
            Console.WriteLine((numberOfPages / pagesForHour) / numberOfDays);
        }
    }
}
