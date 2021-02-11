using System;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string field = Console.ReadLine();
            int strenght = 0;
            for (int i = 0; i < field.Length; i++)
            {
                var currChar = field[i];
                if (currChar == '>')
                {
                    strenght += int.Parse(field[i + 1].ToString());
                    continue;
                }

                if (strenght > 0)
                {
                    field = field.Remove(i, 1);
                    i--;
                    strenght--;
                }
            }
            Console.WriteLine(field);
        }
    }
}
