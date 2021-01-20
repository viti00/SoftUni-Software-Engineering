using System;

namespace _1.RandomizeWord
{
    class Program
    {
        static void Main(string[] args)
        {
            stringRandomizer randomizer = new stringRandomizer();
            randomizer.Words = Console.ReadLine().Split();
            randomizer.Randomize();
            randomizer.PrintRnd();
        }
        public class stringRandomizer
        {
            public string[] Words;
            public void Randomize()
            {
                Random rand = new Random();
                for (int i = 0; i < Words.Length; i++)
                {
                    int randomPosition = rand.Next(0, Words.Length);
                    string temp = Words[i];
                    Words[i] = Words[randomPosition];
                    Words[randomPosition] = temp;
                }
            }

            public void PrintRnd()
            {
                Console.WriteLine(string.Join(Environment.NewLine, Words));
            }
        }
    }
}
