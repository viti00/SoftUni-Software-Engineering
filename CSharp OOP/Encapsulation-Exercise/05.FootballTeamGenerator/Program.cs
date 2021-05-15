using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FootballTeamGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Team team;
            Player player;

            List<Team> teams = new List<Team>();

            string command = Console.ReadLine();

            while(command != "END")
            {
                string[] splitted = command.Split(";");
                switch (splitted[0])
                {
                    case "Team":
                        try
                        {
                            team = new Team(splitted[1]);
                            teams.Add(team);
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                            continue;
                        }
                        break;
                    case "Add":
                        team = teams.FirstOrDefault(t => t.Name == splitted[1]);

                        if (team == null)
                        {
                            Console.WriteLine($"Team {splitted} does not exist.");
                            continue;
                        }
                        player = new Player(splitted[2], int.Parse(splitted[3]), int.Parse(splitted[4])
                            , int.Parse(splitted[5]), int.Parse(splitted[6]), int.Parse(splitted[7]));

                        team.Add(splitted[1], player);
                        break;
                    case "Remove":

                        break;
                    case "Raiting":
                        break;
                }
            }
        }
    }
}
