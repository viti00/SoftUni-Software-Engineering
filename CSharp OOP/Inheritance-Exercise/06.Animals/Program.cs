using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            List<Animal> animals = new List<Animal>();
            while(true)
            {
                string typeAnimal = Console.ReadLine();
                if (typeAnimal == "Beast!")
                {
                    break;
                }
                string datas = Console.ReadLine();

                string[] splitted = datas.Split();
                if (CheckDatas(splitted))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                switch (typeAnimal)
                {
                    case "Cat":
                        Cat cat = new Cat(splitted[0], int.Parse(splitted[1]), splitted[2]);

                        animals.Add(cat);
                        break;
                    case "Dog":
                        Dog dog = new Dog(splitted[0], int.Parse(splitted[1]), splitted[2]);
                        animals.Add(dog);
                        break;
                    case "Frog":
                        Frog frog = new Frog(splitted[0], int.Parse(splitted[1]), splitted[2]);
                        animals.Add(frog);
                        break;
                    case "Kitten":
                        Kitten kitten = new Kitten(splitted[0], int.Parse(splitted[1]));
                        animals.Add(kitten);
                        break;
                    case "Tomcat":
                        Tomcat tomcat = new Tomcat(splitted[0], int.Parse(splitted[1]));
                        animals.Add(tomcat);
                        break;
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine($"{animal.ProduceSound()}");
            }
        }

        static bool CheckDatas (string[] splitted)
        {
            string name = splitted[0];
            int age = int.Parse(splitted[1]);
            string gender = splitted[2];

            if (string.IsNullOrEmpty(name) || age < 0 || gender != "Male" && gender != "Female")
            {
                return true;
            }
            return false;
        }
    }
}
