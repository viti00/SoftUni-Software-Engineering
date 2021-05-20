using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony
{
    public class Smartphone : ISmartable
    {
        public void Browse(string webSite)
        {
            Console.WriteLine($"Browsing: {webSite}!");
        }

        public void Call(string phone)
        {
            Console.WriteLine($"Calling... {phone}");
        }
    }
}
