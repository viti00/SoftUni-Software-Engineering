using System;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();
            int index1 = 0;
            int index2 = 0;
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] temp = command.Split();
                switch (temp[0])
                {
                    case "swap":
                        index1 = int.Parse(temp[1]);
                        index2 = int.Parse(temp[2]);
                        int keeper1 = array[index1];
                        int keeper2 = array[index2];

                        array[index1] = keeper2;
                        array[index2] = keeper1;
                        break;
                    case "multiply":
                        index1 = int.Parse(temp[1]);
                        index2 = int.Parse(temp[2]);

                        array[index1] = array[index1] * array[index2];
                        break;
                    case "decrease":
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i] -= 1;
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
