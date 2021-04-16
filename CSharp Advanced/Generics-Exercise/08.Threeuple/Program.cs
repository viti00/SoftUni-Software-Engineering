using System;

namespace _08.Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            Threeuple<string, string, string> threeuple1 = new Threeuple<string, string, string>();
            string firstInput = Console.ReadLine();

            string[] splitted = firstInput.Split();

            string fullName = $"{splitted[0]} {splitted[1]}";
            string adres = splitted[2];
            string town = " ";
            if (splitted.Length > 4)
            {
                town = $"{splitted[3]} {splitted[4]}";
            }
            else
            {
                town = splitted[3];
            }
            

            threeuple1.Item1 = fullName;
            threeuple1.Item2 = adres;
            threeuple1.Item3 = town;

            Threeuple<string, int, bool> threeuple2 = new Threeuple<string, int, bool>();

            string secondInput = Console.ReadLine();
            splitted = secondInput.Split();

            string name = splitted[0];
            int year = int.Parse(splitted[1]);
            bool IsDrunk = false;           

            threeuple2.Item1 = name;
            threeuple2.Item2 = year;
            threeuple2.Item3 = GetRuslt(splitted, IsDrunk);

            Threeuple<string, double, string> threeuple3 = new Threeuple<string, double, string>();

            string thirdInput = Console.ReadLine();
            splitted = thirdInput.Split();

            string firstName = splitted[0];
            double balance = double.Parse(splitted[1]);
            string bankName = splitted[2];

            threeuple3.Item1 = firstName;
            threeuple3.Item2 = balance;
            threeuple3.Item3 = bankName;

            Console.WriteLine($"{threeuple1.Item1} -> {threeuple1.Item2} -> {threeuple1.Item3}");
            Console.WriteLine($"{threeuple2.Item1} -> {threeuple2.Item2} -> {threeuple2.Item3}");
            Console.WriteLine($"{threeuple3.Item1} -> {threeuple3.Item2} -> {threeuple3.Item3}");
        }
        static bool GetRuslt(string[] splitted, bool IsDrunk)
        {
            if (splitted[2] == "drunk")
            {
                IsDrunk = true;
            }

            return IsDrunk;
        }
    }
}
