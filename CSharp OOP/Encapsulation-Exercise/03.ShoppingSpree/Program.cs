using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            string[] namesAndMoney = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] productsAndPrice = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < namesAndMoney.Length; i++)
            {
                string[] splitted = namesAndMoney[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = splitted[0];
                double money = double.Parse(splitted[1]);
                try
                {
                    Person person = new Person(name, money);
                    persons.Add(person);
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                    return;
                }


            }

            for (int i = 0; i < productsAndPrice.Length; i++)
            {
                string[] splitted = productsAndPrice[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = splitted[0];
                double cost = double.Parse(splitted[1]);
                try
                {
                    Product product = new Product(name, cost);
                    products.Add(product);
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                    return;
                }


            }

            string command = Console.ReadLine();

            while (command != "END")
            {

                string[] splitted = command.Split();
                Person person = persons.FirstOrDefault(p => p.Name == splitted[0]);

                Product product = products.FirstOrDefault(p => p.Name == splitted[1]);

                person.AddInBag(person, product);

                command = Console.ReadLine();

            }


            foreach (var person in persons)
            {
                Console.Write($"{person.Name} - ");
                if (person.BagOfProducts.Count == 0)
                {
                    Console.WriteLine("Nothing bought");
                }
                else
                {
                    Console.WriteLine(string.Join(", ", person.BagOfProducts));
                }

            }

        }
    }
}
