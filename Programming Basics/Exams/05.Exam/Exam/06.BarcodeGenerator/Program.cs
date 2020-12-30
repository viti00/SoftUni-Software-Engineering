using System;

namespace _06.BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int digit1 = start % 10;
            int start1 = start / 10;
            int digit2 = start1 % 10;
            int start2 = start1 / 10;
            int digit3 = start2 % 10;
            int start3 = start2 / 10;
            int digit4 = start3 % 10;
            // pochaveme s endovte
            int enddigit1 = end % 10;
            int end1 = end / 10;
            int enddigit2 = end1 % 10;
            int end2 = end1 / 10;
            int enddigit3 = end2 % 10;
            int end3 = end2 / 10;
            int enddigit4 = end3 % 10;
            for (int i = digit4; i <= enddigit4; i++)
            {
                for (int j = digit3; j <= enddigit3; j++)
                {
                    for (int k = digit2; k <= enddigit2; k++)
                    {
                        for (int m = digit1; m <= enddigit1; m++)
                        {
                            if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && m % 2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{m} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
