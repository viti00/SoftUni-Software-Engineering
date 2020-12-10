using System;

namespace _08.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            // read input
            int lenth = int.Parse(Console.ReadLine());
            int widht = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            double precent = double.Parse(Console.ReadLine());
            //calculation
            double volumeInCm = (lenth * widht * hight);
            double volume = volumeInCm * 0.001;
            double netVolume = volume - (volume * (precent / 100));
            //print output
            Console.WriteLine(netVolume);
        }
    }
}
