using System;
using System.Collections.Generic;

namespace BakeryOpenning
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Bakery bakery = new Bakery("Barny", 10, employees);

            Employee employee = new Employee("Stephen", 40, "Bulgaria");

            bakery.Add(employee);
            Console.WriteLine(bakery.Remove("Name"));

            Employee secondEmployee = new Employee("Mark", 34, "UK");

            bakery.Add(secondEmployee);

            Employee oldestEmployee = bakery.GetOldestEmpoloyee();
            Employee employeeName = bakery.GetEmployee("Stephen");

            Console.WriteLine(oldestEmployee);
            Console.WriteLine(employeeName);


            Console.WriteLine(bakery.Count());

            bakery.Report();
        }
    }
}
