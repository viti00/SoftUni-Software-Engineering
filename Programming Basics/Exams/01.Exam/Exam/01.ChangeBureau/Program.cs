using System;

namespace _01.ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoins = double.Parse(Console.ReadLine());
            double yuans = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());
            double bitcoinToLeva = bitcoins * 1168;
            double yuanToDolars = yuans * 0.15;
            double dolarToLeva = yuanToDolars * 1.76;
            double totalSumInLeva = bitcoinToLeva + dolarToLeva;
            double totalSumInEuro = totalSumInLeva / 1.95;
            double comissions = totalSumInEuro * (comission / 100);
            double finalPrice = totalSumInEuro - comissions;
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
