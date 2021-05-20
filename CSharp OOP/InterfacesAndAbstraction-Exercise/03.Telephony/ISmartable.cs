using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony
{
    public interface ISmartable
    {
        void Call(string phone);

        void Browse(string webSite);
    }
}
