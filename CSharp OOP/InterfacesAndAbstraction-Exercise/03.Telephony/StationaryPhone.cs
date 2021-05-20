using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony
{
    public class StationaryPhone : IStationarable
    {
        public void Call(string phone)
        {
            Console.WriteLine($"Dialing... {phone}");
        }
    }
}
