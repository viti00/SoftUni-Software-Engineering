using System;
namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string username = "Pesho";
            int level = 33;

            BladeKnight bladeKnight = new BladeKnight(username, level);

            Console.WriteLine(bladeKnight);
        }
    }
}