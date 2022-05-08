namespace SoftJail.DataProcessor
{

    using Data;
    using Newtonsoft.Json;
    using SoftJail.DataProcessor.ExportDto;
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;

    public class Serializer
    {
        public static string ExportPrisonersByCells(SoftJailDbContext context, int[] ids)
        {
            var prisoners = context.Prisoners
                                   .ToArray()
                                   .Where(p => ids.Contains(p.Id))
                                   .Select(p => new
                                   {
                                       Id = p.Id,
                                       Name = p.FullName,
                                       CellNumber = p.Cell.CellNumber,
                                       Officers = p.PrisonerOfficers
                                       .Select(o => new
                                       {
                                           OfficerName = o.Officer.FullName,
                                           Department = o.Officer.Department.Name
                                       })
                                       .OrderBy(o => o.OfficerName)
                                       .ToArray(),
                                       TotalOfficerSalary = Math.Round(p.PrisonerOfficers.Sum(po => po.Officer.Salary), 2)

                                   })
                                   .OrderBy(p => p.Name)
                                   .ThenBy(p => p.Id)
                                   .ToArray();

            var sereliazed = JsonConvert.SerializeObject(prisoners, Formatting.Indented);

            return sereliazed;
        }

        public static string ExportPrisonersInbox(SoftJailDbContext context, string prisonersNames)
        {
            StringBuilder sb = new StringBuilder();

            StringWriter writer = new StringWriter(sb);

            XmlRootAttribute root = new XmlRootAttribute("Prisoners");


            XmlSerializer serializer = new XmlSerializer(typeof(PrisonerExportDto[]), root);

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            string[] names = prisonersNames.Split(",");

            var prisoners = context.Prisoners
                                   .ToArray()
                                   .Where(p => names.Contains(p.FullName))
                                   .Select(p => new PrisonerExportDto
                                   {
                                       Id = p.Id,
                                       FullName = p.FullName,
                                       IncarcerationDate = p.IncarcerationDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                                       Mails = p.Mails
                                                            .Select(m => new PrisonerMailsExportDto
                                                            {
                                                                ReversedDescription = String.Join("", m.Description.Reverse())
                                                            })
                                                            .ToArray()
                                   })
                                   .OrderBy(p => p.FullName)
                                   .ThenBy(p => p.Id)
                                   .ToArray();


            serializer.Serialize(writer, prisoners, namespaces);

            return sb.ToString().TrimEnd();
        }
    }
}