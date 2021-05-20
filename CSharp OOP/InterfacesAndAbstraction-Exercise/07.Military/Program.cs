using _07.Military.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Military
{
    public class Program
    {
        private static List<Soldier> soldiers = new List<Soldier>();
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] splitted = command.Split();

                switch (splitted[0])
                {
                    case "Private":
                        AddPrivate(splitted);
                        break;
                    case "LieutenantGeneral":
                        AddLieutenantGeneral(splitted);
                        break;
                    case "Engineer":
                        AddEngineer(splitted);
                        break;
                    case "Commando":
                        AddCommando(splitted);
                        break;
                    case "Spy":
                        AddSpy(splitted);
                        break;
                }

                command = Console.ReadLine();
            }
            soldiers.ForEach(Console.WriteLine);
        }

        private static void AddSpy(string[] splitted)
        {
            Spy spy = new Spy(splitted[1], splitted[2], splitted[3], int.Parse(splitted[4]));

            soldiers.Add(spy);
        }
        private static void AddCommando(string[] splitted)
        {
            try
            {
                Commando commando = new Commando(splitted[1], splitted[2], splitted[3]
                    , decimal.Parse(splitted[4]), splitted[5]);

                for (int i = 6; i < splitted.Length; i += 2)
                {
                    try
                    {
                        Mission mission = new Mission(splitted[i], splitted[i + 1]);
                        commando.AddMisssion(mission);
                    }
                    catch (ArgumentException)
                    { 
                        
                    }
                   
                }
                soldiers.Add(commando);
            }
            catch (ArgumentException)
            {

            }

        }

        private static void AddEngineer(string[] splitted)
        {
            try
            {
                Engineer engineer = new Engineer(splitted[1], splitted[2], splitted[3]
                    , decimal.Parse(splitted[4]), splitted[5]);

                for (int i = 6; i < splitted.Length; i += 2)
                {
                    Repair repair = new Repair(splitted[i], int.Parse(splitted[i + 1]));
                    engineer.AddRepairs(repair);
                }

                soldiers.Add(engineer);
            }
            catch (ArgumentException)
            {

            }
        }
        private static void AddLieutenantGeneral(string[] splitted)
        {
            LieutenantGeneral lieutenantGeneral = new LieutenantGeneral(splitted[1], splitted[2],
                splitted[3], decimal.Parse(splitted[4]));
            for (int i = 5; i < splitted.Length; i++)
            {
                Private privat = (Private)soldiers.Single(s => s.Id == splitted[i]);
                lieutenantGeneral.AddPrivates(privat);
            }
            soldiers.Add(lieutenantGeneral);
        }

        private static void AddPrivate(string[] splitted)
        {
            Private privat = new Private(splitted[1], splitted[2], splitted[3], decimal.Parse(splitted[4]));

            soldiers.Add(privat);
        }
    }
}
