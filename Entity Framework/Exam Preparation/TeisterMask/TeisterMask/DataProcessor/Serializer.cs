namespace TeisterMask.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using TeisterMask.DataProcessor.ExportDto;
    using TeisterMask.Models.Enums;
    using Formatting = Newtonsoft.Json.Formatting;

    public class Serializer
    {

        public static string ExportProjectWithTheirTasks(TeisterMaskContext context)
        {
            StringBuilder sb = new StringBuilder();
            XmlRootAttribute root = new XmlRootAttribute("Projects");
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();

            XmlSerializer serializer = new XmlSerializer(typeof(List<ProjectExportDto>), root);

            namespaces.Add(string.Empty, string.Empty);

            var projects = context.Projects
                                  .Where(p => p.Tasks.Count >= 1)
                                  .ToArray()
                                  .Select(p => new ProjectExportDto
                                  {
                                      ProjectName = p.Name,
                                      HasEndDate = p.DueDate.HasValue ? "Yes" : "No",
                                      TasksCount = p.Tasks.Count,
                                      Tasks = p.Tasks
                                               .ToArray()
                                               .Select(t => new ProjectTasksExportDto
                                               {
                                                   Name = t.Name,
                                                   Label = t.LabelType.ToString()
                                               })
                                               .OrderBy(t => t.Name)
                                               .ToArray()
                                  })
                                  .OrderByDescending(p => p.TasksCount)
                                  .ThenBy(t => t.ProjectName)
                                  .ToList();

            StringWriter writer = new StringWriter(sb);

            serializer.Serialize(writer, projects, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string ExportMostBusiestEmployees(TeisterMaskContext context, DateTime date)
        {
            var employees = context.Employees
                                   .Where(e => e.EmployeesTasks.Any(t => t.Task.OpenDate >= date))
                                   .ToArray()
                                   .Select(e => new
                                   {
                                       Username = e.Username,
                                       Tasks = e.EmployeesTasks
                                       .Where(et => et.Task.OpenDate >= date)
                                       .ToArray()
                                       .OrderByDescending(et => et.Task.DueDate)
                                       .ThenBy(et => et.Task.Name)
                                       .Select(et => new
                                       {
                                           TaskName = et.Task.Name,
                                           OpenDate = et.Task.OpenDate.ToString("d", CultureInfo.InvariantCulture),
                                           DueDate = et.Task.DueDate.ToString("d", CultureInfo.InvariantCulture),
                                           LabelType = et.Task.LabelType.ToString(),
                                           ExecutionType = et.Task.ExecutionType.ToString()

                                       }).ToArray()

                                   })
                                   .OrderByDescending(e => e.Tasks.Length)
                                   .ThenBy(e => e.Username)
                                   .Take(10)
                                   .ToList();

            string jsonString = JsonConvert.SerializeObject(employees, Formatting.Indented);
            return jsonString;
        }
    }
}