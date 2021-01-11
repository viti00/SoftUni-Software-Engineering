using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(num1, num2));
            }
            else if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMax(first, second));
            }
        }
        static int GetMax(int num1, int num2)
        {
            int result = 0;
            if (num1 > num2)
            {
                result = num1;
            }
            else if (num1 < num2)
            {
                result = num2;
            }
            return result;
        }
        static char GetMax(char a, char b)
        {
            char result = 'a';
            if (a > b)
            {
                result = a;
            }
            else if (a < b)
            {
                result = b;
            }
            return result;
        }
        static string GetMax(string first, string second)
        {
            int comparison = first.CompareTo(second);
            if (comparison > 0)
            {
                return first;
            }
            else
            {
                return second;
            }

        }
    }
}
