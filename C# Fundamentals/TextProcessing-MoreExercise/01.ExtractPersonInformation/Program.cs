using System;

namespace ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string information = Console.ReadLine();
                int nameFirstIndex = information.IndexOf("@");
                int nameLastIndex = information.IndexOf("|");

                int ageFirstIndex = information.IndexOf("#");
                int ageLastIndex = information.IndexOf("*");

                string age = "";
                string name = "";
                name = information.Substring(nameFirstIndex + 1, nameLastIndex - nameFirstIndex - 1);
                age = information.Substring(ageFirstIndex + 1, ageLastIndex - ageFirstIndex - 1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
