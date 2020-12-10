using System;

namespace _07.ProjectCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projectCount = int.Parse(Console.ReadLine());
            int time = projectCount * 3;


            Console.WriteLine($"The architect {name} will need {time} hours to complete {projectCount} project/s.");
        }
    }
}
