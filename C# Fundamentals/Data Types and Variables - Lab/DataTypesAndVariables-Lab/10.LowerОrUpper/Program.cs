using System;

namespace _10.LowerОrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char value = char.Parse(Console.ReadLine());
            int charValue = Convert.ToInt32(value);
            if (charValue >= 65 && charValue <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if (charValue >= 97 && charValue <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
