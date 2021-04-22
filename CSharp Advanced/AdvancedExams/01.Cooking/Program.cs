using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>();
            Stack<int> ingredients = new Stack<int>();
            Dictionary<string, int> foods = new Dictionary<string, int>();

            foods = AddInDictionary(foods);

            int[] allLiquids = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < allLiquids.Length; i++)
            {
                liquids.Enqueue(allLiquids[i]);
            }

            int[] allIngredients = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < allIngredients.Length; i++)
            {
                ingredients.Push(allIngredients[i]);
            }

            while (liquids.Count != 0 && ingredients.Count != 0)
            {
                foods = GetProduct(foods, liquids, ingredients);
            }
            int counter = 0;
            foreach (var food in foods)
            {
                if (food.Value >= 1)
                {
                    counter++;
                }
            }

            if (counter == 4)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.Write("Liquids left: ");
                Console.WriteLine(string.Join(", ", liquids));
            }

            if (ingredients.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.Write("Ingredients left: ");
                Console.WriteLine(string.Join(", ", ingredients));
            }

            foreach (var food in foods.OrderBy(X=>X.Key))
            {
                Console.WriteLine($"{food.Key}: {food.Value}");
            }
        }


        static Dictionary<string, int> AddInDictionary(Dictionary<string, int> foods)
        {
            foods.Add("Bread", 0);
            foods.Add("Cake", 0);
            foods.Add("Pastry", 0);
            foods.Add("Fruit Pie", 0);

            return foods;
        }

        static Dictionary<string, int> GetProduct(Dictionary<string, int> foods,
                                                    Queue<int> liquids, Stack<int> ingredients)
        {
            int result = liquids.Peek() + ingredients.Peek();
            string food = "";
            switch (result)
            {
                case 25:
                    food = "Bread";
                    foods[food]++;
                    liquids.Dequeue();
                    ingredients.Pop();
                    break;
                case 50:
                    food = "Cake";
                    foods[food]++;
                    liquids.Dequeue();
                    ingredients.Pop();
                    break;
                case 75:
                    food = "Pastry";
                    foods[food]++;
                    liquids.Dequeue();
                    ingredients.Pop();
                    break;
                case 100:
                    food = "Fruit Pie";
                    foods[food]++;
                    liquids.Dequeue();
                    ingredients.Pop();
                    break;
                default:
                    liquids.Dequeue();
                    int ingredientsSum = ingredients.Pop() + 3;
                    ingredients.Push(ingredientsSum);
                    break;
            }

            return foods;
        }
    }
}
