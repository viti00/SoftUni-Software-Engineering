using System;

namespace _07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0;
            int standartTickets = 0;
            int kidsTickets = 0;

            string movie = Console.ReadLine();
            while (movie != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());
                int currentMovieTickets = 0;
                for (int i = 0; i < availableSeats; i++)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }
                    else if (ticketType == "student")
                    {
                        studentTickets++;
                    }
                    else if (ticketType == "standard")
                    {
                        standartTickets++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidsTickets++;
                    }
                    currentMovieTickets++;
                }
                Console.WriteLine($"{movie} - {(double)currentMovieTickets / (double)availableSeats * 100:f2}% full.");
                movie = Console.ReadLine();
            }
            int totalTickets = studentTickets + standartTickets + kidsTickets;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(double)studentTickets / (double)totalTickets * 100f:f2}% student tickets.");
            Console.WriteLine($"{(double)standartTickets / (double)totalTickets * 100f:f2}% standard tickets.");
            Console.WriteLine($"{(double)kidsTickets / (double)totalTickets * 100f:f2}% kids tickets.");
        }
    }
}
