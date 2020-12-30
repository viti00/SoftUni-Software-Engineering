using System;

namespace _01.AgencyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string comapnyName = Console.ReadLine();
            int adultCount = int.Parse(Console.ReadLine());
            int childCount = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            double servicePrice = double.Parse(Console.ReadLine());
            double childTicketPrice = ticketPrice - (ticketPrice * 0.7);
            double adultTicketPrice = ticketPrice + servicePrice;
            double childTicketTotalPrice = childTicketPrice + servicePrice;
            double totalPrice = (childCount * childTicketTotalPrice) + (adultTicketPrice * adultCount);
            double profit = totalPrice * 0.2;
            Console.WriteLine($"The profit of your agency from {comapnyName} tickets is {profit:f2} lv.");
        }
    }
}
