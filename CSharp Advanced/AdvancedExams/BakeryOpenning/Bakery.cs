using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        public Bakery(string name, int capacity, List<Employee> employees)
        {
            Name = name;
            Capacity = capacity;
            Employees = employees;
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Employee> Employees { get; set; }
        private int counter = 0;
        

        public List<Employee> Add(Employee employee)
        {
            if (counter < Capacity)
            {
                Employees.Add(employee);
                counter++;
            }
            return Employees;
        }

        public bool Remove (string name)
        {
            foreach (var item in Employees)
            {
                if (item.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public Employee GetOldestEmpoloyee()
        {
            int oldest = int.MinValue;
            string nameOldestPeople = "";
            foreach (var item in Employees)
            {
                if (item.Age > oldest)
                {
                    oldest = item.Age;
                    nameOldestPeople = item.Name;
                }
            }
            foreach (var item in Employees)
            {
                if(item.Name == nameOldestPeople)
                {
                    return item;
                }
            }
            return null;
        }
        public Employee GetEmployee (string name)
        {
            foreach (var item in Employees)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }
        public int Count()
        {
            return Employees.Count;
        }
        public void Report()
        {
            Console.WriteLine($"Employees working at Bakery {Name}:");
            foreach (var item in Employees)
            {
                Console.WriteLine(item);
            }
        }
    }
}
