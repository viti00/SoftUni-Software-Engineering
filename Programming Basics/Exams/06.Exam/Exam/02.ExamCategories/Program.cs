using System;

namespace _02.ExamCategories
{
    class Program
    {
        static void Main(string[] args)
        {
            int complexity = int.Parse(Console.ReadLine());
            int spinning = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());
            if (complexity >= 80 && spinning >= 80 && pages >= 8)
            {
                Console.WriteLine("Legacy");
            }
            if (complexity >= 80 && spinning <= 10)
            {
                Console.WriteLine("Master");
            }
            if (spinning >= 50 && pages >= 2)
            {
                Console.WriteLine("Hard");
            }
            if (complexity <= 30 && pages <= 1)
            {
                Console.WriteLine("Easy");
            }
            if (complexity <= 10)
            {
                Console.WriteLine("Elementary");
            }
            else
            {
                Console.WriteLine("Regular");
            }
        }
    }
}
