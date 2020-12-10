using System;

namespace _07.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //read input
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananasCount = double.Parse(Console.ReadLine());
            double orangesCount = double.Parse(Console.ReadLine());
            double raspberryCount = double.Parse(Console.ReadLine());
            double strawberryCount = double.Parse(Console.ReadLine());
            //calculation
            double raspberryPrice = strawberryPrice * 0.50;
            double orangesPrice = raspberryPrice - (raspberryPrice * 0.4);
            double bananasPrice = raspberryPrice - (raspberryPrice * 0.8);
            double raspberrySum = raspberryCount * raspberryPrice;
            double orangesSum = orangesCount * orangesPrice;
            double bananasSum = bananasCount * bananasPrice;
            double strawberrySum = strawberryCount * strawberryPrice;
            double totalPrice = raspberrySum + orangesSum + bananasSum + strawberrySum;
            //print input
            Console.WriteLine(totalPrice);
        }
    }
}
