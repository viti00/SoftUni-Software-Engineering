using System;

namespace _07.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            //calculation
            //steni
            double stranichnaStena = x * y;
            double window = 1.5 * 1.5;
            double dveteStraniObshto = stranichnaStena * 2 - window * 2;
            double zadnaStena = x * x;
            double vhod = 1.2 * 2;
            double obshtoPrednaZadna = zadnaStena * 2 - vhod;
            double obshto = dveteStraniObshto + obshtoPrednaZadna;
            double zelenaBoq = obshto / 3.4;
            //pokriv
            double dvaPravougulnikaNaPokriva = 2 * (x * y);
            double dvaTriugulnika = 2 * ((x * h) / 2);
            double obshtaPlosht = dvaPravougulnikaNaPokriva + dvaTriugulnika;
            double chervenaBoq = obshtaPlosht / 4.3;
            //print output
            Console.WriteLine($"{zelenaBoq:F2}");
            Console.WriteLine($"{chervenaBoq:F2}");
        }
    }
}
