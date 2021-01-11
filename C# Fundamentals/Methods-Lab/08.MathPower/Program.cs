using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(RiseToPower(num, power));
        }
        static double RiseToPower(double num, int pow)
        {
            double result = 0d;
            result = Math.Pow(num, pow);
            return result;
        }
    }
}
