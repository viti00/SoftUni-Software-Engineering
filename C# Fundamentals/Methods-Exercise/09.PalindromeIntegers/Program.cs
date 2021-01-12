using System;
using System.Linq;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            PalindromeInteger(number);
        }
        static void PalindromeInteger(string number)
        {
            string result = string.Empty;
            char[] sRev = number.ToArray();
            string reversNumber = string.Empty;
            while (number != "End")
            {

                string inputNumber = number;
                for (int i = sRev.Length - 1; i >= 0; i--)
                {
                    reversNumber += sRev[i];
                }
                if (inputNumber == reversNumber)
                {
                    result = "true";
                    Console.WriteLine(result);
                }
                else
                {
                    result = "false";
                    Console.WriteLine(result);
                }
                number = Console.ReadLine();
            }
        }
    }
}
