using System;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(ChekTypes(num));
            }
            else if (type == "real")
            {
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine($"{ChekTypes(num):f2}");
            }
            else if (type == "string")
            {
                string word = Console.ReadLine();
                Console.WriteLine(ChekTypes(word));
            }
        }
        static int ChekTypes(int num)
        {
            int result = num * 2;
            return result;
        }
        static double ChekTypes(double num)
        {
            double result = num * 1.5;
            return result;
        }
        static string ChekTypes(string word)
        {
            string result = $"${word}$";
            return result;
        }
    }
}
