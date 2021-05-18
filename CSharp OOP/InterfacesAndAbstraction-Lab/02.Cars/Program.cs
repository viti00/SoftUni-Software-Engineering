using System;

namespace Cars
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ICar seat = new Seat("Leon", "Grey");
            Console.WriteLine(seat.ToString());
            seat.Start();
            seat.Stop();

            ICar tesla = new Tesla("Model 3", "Red", 2);
            Console.WriteLine(tesla.ToString());
            tesla.Start();
            tesla.Stop();

        }
    }
}
