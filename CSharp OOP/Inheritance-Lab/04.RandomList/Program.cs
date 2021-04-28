using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("Pesho");
            list.Add("Gogi");
            list.Add("Gigi");
            list.Add("Mishi");
            list.Add("dimi");
            list.Add("Mi");
            list.Add("Mish");

            Console.WriteLine(list.RandomString());

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
