using System;
using System.Linq;

namespace _03.Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            ISmartable smartphone = new Smartphone();
            IStationarable stationaryPhone = new StationaryPhone();
            string[] phoneNumbers = Console.ReadLine().Split();
            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                if (IsInvalid(phoneNumbers[i]))
                {
                    Console.WriteLine($"Invalid number!");
                }
                else
                {
                    if (phoneNumbers[i].Length == 10)
                    {
                        smartphone.Call(phoneNumbers[i]);
                    }
                    else if (phoneNumbers[i].Length == 7)
                    {
                        stationaryPhone.Call(phoneNumbers[i]);
                    }
                }
                
            }

            string[] webAdresses = Console.ReadLine().Split();

            for (int i = 0; i < webAdresses.Length; i++)
            {
                if (HasDigit(webAdresses[i]))
                {
                    Console.WriteLine($"Invalid URL!");
                }
                else
                {
                    smartphone.Browse(webAdresses[i]);
                }
            }
        }

        static bool HasDigit(string webAdresses)
        {
            for (int i = 0; i < webAdresses.Length; i++)
            {
                if (char.IsDigit(webAdresses[i]))
                {
                    return true;
                }
            }
            return false;
        }

        static bool IsInvalid(string phoneNumber)
        {
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (!char.IsDigit(phoneNumber[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
