using System;

namespace _06.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            double mounths = double.Parse(Console.ReadLine());
            double waterBills = 0.0;
            double internetBills = 0.0;
            double otherBills = 0.0;
            double elBills = 0.0;
            double bills = 0.0;
            double total = 0.0;
            double total1 = 0.0;
            double total2 = 0.0;
            for (int i = 1; i <= mounths; i++)
            {
                double electricityBills = double.Parse(Console.ReadLine());
                elBills = electricityBills;
                total += elBills;
                waterBills = 20;
                total1 += waterBills;
                internetBills = 15;
                total2 += internetBills;
                bills = electricityBills + waterBills + internetBills + ((electricityBills + waterBills + internetBills) * 0.2);
                otherBills += bills;
            }
            double totalBills = total + total1 + total2 + otherBills;
            double averageBills = totalBills / mounths;
            Console.WriteLine($"Electricity: {total:f2} lv");
            Console.WriteLine($"Water: {total1:F2} lv");
            Console.WriteLine($"Internet: {total2:f2} lv");
            Console.WriteLine($"Other: {otherBills:f2} lv");
            Console.WriteLine($"Average: {averageBills:f2} lv");
        }
    }
}
