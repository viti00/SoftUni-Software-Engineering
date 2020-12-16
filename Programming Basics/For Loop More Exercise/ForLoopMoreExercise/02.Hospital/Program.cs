using System;

namespace _02.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOFDoctors = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;
            int periodOfTime = int.Parse(Console.ReadLine());
            for (int i = 1; i <= periodOfTime; i++)
            {
                if (i % 3 == 0)
                {
                    if (untreatedPatients > treatedPatients)
                    {
                        numberOFDoctors++;
                    }
                }
                int patientsPerDay = int.Parse(Console.ReadLine());
                if (patientsPerDay <= numberOFDoctors)
                {
                    treatedPatients += patientsPerDay;
                }
                if (patientsPerDay > numberOFDoctors)
                {
                    treatedPatients += numberOFDoctors;
                    untreatedPatients += (patientsPerDay - numberOFDoctors);
                }
            }
            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
        }
    }
}
