using System;

namespace _06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriqCena = double.Parse(Console.ReadLine());
            double cacaCena = double.Parse(Console.ReadLine());
            double palamudKolichestvo = double.Parse(Console.ReadLine());
            double safridKolichestvo = double.Parse(Console.ReadLine());
            double midiKolichestvo = double.Parse(Console.ReadLine());
            //calculation
            double palamudCena = skumriqCena + (skumriqCena * 0.60);
            double safridCena = cacaCena + (cacaCena * 0.80);
            double palamudObshtaSuma = palamudCena * palamudKolichestvo;
            double safridObshtaSuma = safridCena * safridKolichestvo;
            double midiObshtaSuma = midiKolichestvo * 7.50;
            double obshtaSmetka = palamudObshtaSuma + safridObshtaSuma + midiObshtaSuma;
            //print output
            Console.WriteLine($"{obshtaSmetka:F2}");
        }
    }
}
