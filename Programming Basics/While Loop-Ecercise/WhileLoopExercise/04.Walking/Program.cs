using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int sum = 0;



            while (command != "Going home")
            {
                sum += int.Parse(command);



                if (sum < 10000)
                {


                }
                if (sum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{sum - 10000} steps over the goal!");
                    break;
                }
                command = Console.ReadLine();
            }

            if (command == "Going home")
            {
                command = Console.ReadLine();
                sum += int.Parse(command);

                if (sum < 10000)
                {
                    Console.WriteLine($"{10000 - sum} more steps to reach goal.");

                }
                else if (sum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{sum - 10000} steps over the goal!");
                }

            }
        }
    }
}
