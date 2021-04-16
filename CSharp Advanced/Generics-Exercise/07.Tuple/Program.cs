using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tuple<string, string> tuple1 = new Tuple<string, string>();
            string firstInput = Console.ReadLine();
            string[] splitted = firstInput.Split();

            string fullName = $"{splitted[0]} {splitted[1]}";
            string adres = splitted[2];

            tuple1.Item1 = fullName;
            tuple1.Item2 = adres;

            

            Tuple<string, int> tuple2 = new Tuple<string, int>();

            string secondInput = Console.ReadLine();
            splitted = secondInput.Split();
            string name = splitted[0];
            int beerLiters = int.Parse(splitted[1]);

            tuple2.Item1 = name;
            tuple2.Item2 = beerLiters;

            
            Tuple<int, double> tuple3 = new Tuple<int, double>();

            string thirdInput = Console.ReadLine();
            splitted = thirdInput.Split();
            int num = int.Parse(splitted[0]);
            double doubleNum = double.Parse(splitted[1]);

            tuple3.Item1 = num;
            tuple3.Item2 = doubleNum;


            Console.WriteLine($"{tuple1.Item1} -> {tuple1.Item2}");
            Console.WriteLine($"{tuple2.Item1} -> {tuple2.Item2}");
            Console.WriteLine($"{tuple3.Item1} -> {tuple3.Item2}");
        }
    }
}
