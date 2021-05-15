using System;
using System.Collections.Generic;
using System.Text;

namespace _03.ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<string> bagOfProducts;

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            BagOfProducts = bagOfProducts;
        }

        public List<string> BagOfProducts
        {
            get => bagOfProducts;
            private set
            {
                value = new List<string>();
                bagOfProducts = value;
            }
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public double Money
        {
            get => this.money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public void AddInBag(Person person, Product product)
        {

            if (CanBuy(person, product))
            {
                person.money -= product.Cost;

                Console.WriteLine($"{person.Name} bought {product.Name}");
                bagOfProducts.Add(product.Name);
                
            }
            else
            {
                Console.WriteLine($"{person.Name} can't afford {product.Name}");

            }
            
        }

        private bool CanBuy(Person person, Product product)
        {
            if (person.money >= product.Cost)
            {
                return true;
            }
            return false;
        }
    }
}
