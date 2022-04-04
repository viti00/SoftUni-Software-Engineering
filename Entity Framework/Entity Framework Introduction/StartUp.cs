using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Linq;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var context = new SoftUniContext();
            Console.WriteLine(RemoveTown(context));
        }

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var employees = context.Employees.ToList();

            foreach (var item in employees)
            {
                sb.AppendLine($"{item.FirstName} {item.LastName} {item.MiddleName} {item.JobTitle} {item.Salary:f2}");
            }

            return sb.ToString();
        }

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                                   .Where(e => e.Salary > 50000)
                                   .ToList();

            foreach (var item in employees.OrderBy(i=> i.FirstName))
            {
                sb.AppendLine($"{item.FirstName} - {item.Salary:f2}");
            }

            return sb.ToString();
        }

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                                   .Where(e => e.Department.Name == "Research and Development")
                                   .ToList();

            foreach (var item in employees.OrderBy(e=> e.Salary).ThenByDescending(e=>e.FirstName))
            {
                sb.AppendLine($"{item.FirstName} {item.LastName} from Research and Development - ${item.Salary:F2}");
            }

            return sb.ToString();
        }

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            Address newAddress = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            context.Addresses.Add(newAddress);

            Employee employeeNakov = context.Employees
                .First(e => e.LastName == "Nakov");

            employeeNakov.Address = newAddress;

            context.SaveChanges();

            string[] addresses = context.Employees
                                   .OrderByDescending(e => e.AddressId)
                                   .Select(e => e.Address.AddressText)
                                   .Take(10)
                                   .ToArray();

            return string.Join(Environment.NewLine, addresses);
        }

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var employees = context.Employees.Where(e => e.EmployeesProjects.Any(ep => ep.Project.StartDate.Year >= 2001 && ep.Project.StartDate.Year <= 2003))
               .Select(e => new
               {
                   FirstName = e.FirstName,
                   LastName = e.LastName,
                   ManagerFirstName = e.Manager.FirstName,
                   ManagerLastName = e.Manager.LastName,
                   Projects = e.EmployeesProjects.Select(ep => new
                   {
                       ProjectName = ep.Project.Name,
                       ProjectStartDate = ep.Project.StartDate,
                       ProjectEndDate = ep.Project.EndDate
                   })
               }).Take(10);

            StringBuilder employeeManagerResult = new StringBuilder();

            foreach (var employee in employees)
            {
                employeeManagerResult.AppendLine($"{employee.FirstName} {employee.LastName} - Manager: {employee.ManagerFirstName} {employee.ManagerLastName}");

                foreach (var project in employee.Projects)
                {
                    var startDate = project.ProjectStartDate.ToString("M/d/yyyy h:mm:ss tt");
                    var endDate = project.ProjectEndDate.HasValue ? project.ProjectEndDate.Value.ToString("M/d/yyyy h:mm:ss tt") : "not finished";

                    employeeManagerResult.AppendLine($"--{project.ProjectName} - {startDate} - {endDate}");
                }
            }
            return employeeManagerResult.ToString().TrimEnd();
        }

        public static string GetAddressesByTown(SoftUniContext context)
        {
            var addresses = context.Addresses
                                   .OrderByDescending(e => e.Employees.Count)
                                   .ThenBy(e => e.Town.Name)
                                   .ThenBy(e => e.AddressText)
                                   .Select(e => new
                                   {
                                       e.AddressText,
                                       townName = e.Town.Name,
                                       count = e.Employees.Count
                                   })
                                   .Take(10)
                                   .ToArray();
            StringBuilder sb = new StringBuilder();

            foreach (var item in addresses)
            {
                sb.AppendLine($"{item.AddressText}, {item.townName} - {item.count} employees");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetEmployee147(SoftUniContext context)
        {
            var employee = context.Employees
                                   .Where(e => e.EmployeeId == 147)
                                   .Select(e => new
                                   {
                                       e.FirstName,
                                       e.LastName,
                                       e.JobTitle,
                                       projects = e.EmployeesProjects
                                                   .Select(ep => new
                                                   {
                                                       projectName = ep.Project.Name
                                                   })
                                   })
                                   .First();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
            foreach (var item in employee.projects.OrderBy(i=> i.projectName))
            {
                sb.AppendLine(item.projectName);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var departments = context.Departments
                                     .Where(d => d.Employees.Count > 5)
                                     .OrderBy(d => d.Employees.Count)
                                     .Select(d => new
                                     {
                                         d.Name,
                                         manegerFirstName = d.Manager.FirstName,
                                         manegerLastName = d.Manager.LastName,
                                         employees = d.Employees.Select(e => new
                                         {
                                             e.FirstName,
                                             e.LastName,
                                             e.JobTitle
                                         })
                                         .OrderBy(e => e.FirstName)
                                         .ThenBy(e => e.LastName)
                                         .ToArray()
                                     })
                                     .ToArray();
            StringBuilder sb = new StringBuilder();
            foreach (var d in departments)
            {
                sb.AppendLine($"{d.Name} - {d.manegerFirstName} {d.manegerLastName}");
                foreach (var e in d.employees)
                {
                    sb.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetLatestProjects(SoftUniContext context)
        {
            var projects = context.Projects
                                  .OrderByDescending(p => p.StartDate)
                                  .Take(10)
                                  .Select(p => new
                                  {
                                      p.Name,
                                      p.Description,
                                      p.StartDate
                                  })
                                  .OrderBy(p => p.Name)
                                  .ToArray();

            StringBuilder sb = new StringBuilder();
            foreach (var p in projects)
            {
                sb.AppendLine(p.Name);
                sb.AppendLine(p.Description);

                var startDate = p.StartDate.ToString("M/d/yyyy h:mm:ss tt");
                sb.AppendLine(startDate);
            }

            return sb.ToString().TrimEnd();
        }

        public static string IncreaseSalaries(SoftUniContext context)
        {
            var employees = context.Employees
                                   .Where(e => e.Department.Name == "Engineering"
                                   || e.Department.Name == "Tool Design"
                                   || e.Department.Name == "Marketing"
                                   || e.Department.Name == "Information Services");

            foreach (var e in employees)
            {
                e.Salary *= 1.12m;
            }

            context.SaveChanges();

            var employeesWhitNameAndSalary = employees.Select(e => new
            {
                e.FirstName,
                e.LastName,
                e.Salary
            })
            .OrderBy(e=> e.FirstName)
            .ThenBy(e=> e.LastName)
            .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var e in employeesWhitNameAndSalary)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} (${e.Salary:F2})");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            string startWith = "Sa";
            var employees = context.Employees
                                   .Where(e => e.FirstName.ToLower().StartsWith(startWith.ToLower()))
                                   .Select(e => new
                                   {
                                       e.FirstName,
                                       e.LastName,
                                       e.JobTitle,
                                       e.Salary
                                   })
                                   .OrderBy(e => e.FirstName)
                                   .ThenBy(e => e.LastName)
                                   .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:F2})");
            }

            return sb.ToString().TrimEnd();
        }

        public static string DeleteProjectById(SoftUniContext context)
        {
            var project = context.Projects
                                 .FirstOrDefault(p => p.ProjectId == 2);
            var employeesProject = context.EmployeesProjects
                                          .Where(ep => ep.ProjectId == 2);
            context.RemoveRange(employeesProject);
            context.Remove(project);

            context.SaveChanges();

            var projects = context.Projects
                                  .Select(p => p.Name)
                                  .Take(10)
                                  .ToArray();

            return string.Join(Environment.NewLine, projects);
        }

        public static string RemoveTown(SoftUniContext context)
        {
            var seattleAddress = context.Addresses
                                     .Where(a => a.Town.Name == "Seattle")
                                     .ToArray();

            var employeesInSeattle = context.Employees
                                   .ToArray()
                                   .Where(e => seattleAddress.Any(a=> a.AddressId == e.AddressId))
                                   .ToArray();

            foreach (var e in employeesInSeattle)
            {
                e.AddressId = null;
            }

            context.Addresses.RemoveRange(seattleAddress);

            var town = context.Towns
                              .First(t => t.Name == "Seattle");
            context.Towns.Remove(town);

            context.SaveChanges();

            return $"{seattleAddress.Length} addresses in Seattle were deleted";
        }
    }
}
