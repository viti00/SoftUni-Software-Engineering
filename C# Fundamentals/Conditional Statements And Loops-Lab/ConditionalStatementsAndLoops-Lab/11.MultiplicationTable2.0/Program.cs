using System;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int multiplication = 0;
            for (int i = num2; i <= 10; i++)
            {
                multiplication = num1 * i;
                Console.WriteLine($"{num1} X {i} = {multiplication}");
            }
            if (num2 > 10)
            {
                multiplication = num1 * num2;
                Console.WriteLine($"{num1} X {num2} = {multiplication}");
            }
        }
    }
}
