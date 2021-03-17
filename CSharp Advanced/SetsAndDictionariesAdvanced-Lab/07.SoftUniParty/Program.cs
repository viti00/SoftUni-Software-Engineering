using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guestsList = new HashSet<string>();

            string command = Console.ReadLine();
            while (command != "PARTY")
            {
                guestsList.Add(command);
                command = Console.ReadLine();
            }

            string afterPartyCommand = Console.ReadLine();
            while (afterPartyCommand != "END")
            {
                guestsList.Remove(afterPartyCommand);
                afterPartyCommand = Console.ReadLine();
            }

            Console.WriteLine(guestsList.Count);

            foreach (var guest in guestsList)
            {
                char[] ch = guest.ToCharArray();
                if (char.IsDigit(ch[0]))
                {
                    Console.WriteLine(guest);
                }
            }
            foreach (var guest in guestsList)
            {
                char[] ch = guest.ToCharArray();
                if (char.IsLetter(ch[0]))
                {
                    Console.WriteLine(guest);
                }
            }
        }
    }
}
