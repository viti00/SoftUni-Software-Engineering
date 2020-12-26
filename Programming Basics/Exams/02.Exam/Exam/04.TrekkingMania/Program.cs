using System;

namespace _04.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int peoplesCount = 0;
            double musalaCount = 0.0;
            double monblanCount = 0.0;
            double kilimandjaroCount = 0.0;
            double k2Count = 0.0;
            double everestCount = 0.0;
            for (int i = 1; i <= groups; i++)
            {
                int peoples = int.Parse(Console.ReadLine());
                peoplesCount += peoples;
                if (peoples <= 5)
                {
                    musalaCount += peoples;
                }
                else if (peoples >= 6 && peoples <= 12)
                {
                    monblanCount += peoples;
                }
                else if (peoples >= 13 && peoples <= 25)
                {
                    kilimandjaroCount += peoples;
                }
                else if (peoples >= 26 && peoples <= 40)
                {
                    k2Count += peoples;
                }
                else if (peoples >= 41)
                {
                    everestCount += peoples;
                }
            }
            double musalaPercent = musalaCount / peoplesCount * 100;
            double monblanPercent = monblanCount / peoplesCount * 100;
            double kilimandjaroPercent = kilimandjaroCount / peoplesCount * 100;
            double k2Percent = k2Count / peoplesCount * 100;
            double everestPercent = everestCount / peoplesCount * 100;
            Console.WriteLine($"{musalaPercent:F2}%");
            Console.WriteLine($"{monblanPercent:f2}%");
            Console.WriteLine($"{kilimandjaroPercent:f2}%");
            Console.WriteLine($"{k2Percent:f2}%");
            Console.WriteLine($"{everestPercent:f2}%");
        }
    }
}
