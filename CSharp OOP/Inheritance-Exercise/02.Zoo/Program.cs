using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string nameGorila = "GorilaJohn";
            string nameBear = "BearGoGi";
            string nameSnake = "SnakePepa";
            string nameLizard = "LizardMito";

            Bear bear = new Bear(nameBear);
            Gorilla gorila = new Gorilla(nameGorila);
            Snake snake = new Snake(nameSnake);
            Lizard lizard = new Lizard(nameLizard);

            Console.WriteLine(bear.Name);
            Console.WriteLine(gorila.Name);
            Console.WriteLine(snake.Name);
            Console.WriteLine(lizard.Name);
        }
    }
}