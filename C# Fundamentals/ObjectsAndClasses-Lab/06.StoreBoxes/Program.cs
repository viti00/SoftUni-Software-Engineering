using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _6.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            List<Box> addBoxes = new List<Box>();
            while (data != "end")
            {
                string[] temp = data.Split();
                string serialNumber = temp[0];
                string item = temp[1];
                int quantity = int.Parse(temp[2]);
                double price = double.Parse(temp[3]);
                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.Item = item;
                box.Price = price;
                box.Quantity = quantity;
                box.PriceForBox = quantity * price;
                addBoxes.Add(box);
                data = Console.ReadLine();
            }
            List<Box> sortedBox = addBoxes.OrderBy(sort => sort.PriceForBox).ToList();
            sortedBox.Reverse();
            foreach (Box box in sortedBox)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item} - ${box.Price:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }
        }

        public class Box
        {

            public string SerialNumber { get; set; }
            public string Item { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }
            public double PriceForBox { get; set; }
        }
    }
}
