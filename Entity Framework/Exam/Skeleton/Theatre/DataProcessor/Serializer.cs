namespace Theatre.DataProcessor
{
    using Newtonsoft.Json;
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Theatre.Data;
    using Theatre.DataProcessor.ExportDto;

    public class Serializer
    {

        public static string ExportTheatres(TheatreContext context, int numbersOfHalls)
        {
            var theaters = context.Theatres
                                  .ToArray()
                                  .Where(t => t.NumberOfHalls >= numbersOfHalls && t.Tickets.Count >= 20)
                                  .Select(t => new
                                  {
                                      Name = t.Name,
                                      Halls = t.NumberOfHalls,
                                      TotalIncome = t.Tickets.Where(t => t.RowNumber >= 1 && t.RowNumber <= 5).Sum(t => t.Price),
                                      Tickets = t.Tickets
                                      .ToArray()
                                      .Where(ti => ti.RowNumber >= 1 && ti.RowNumber <= 5)
                                      .Select(ti => new
                                      {
                                          Price = Math.Round(ti.Price, 2),
                                          RowNumber = ti.RowNumber
                                      })
                                      .OrderByDescending(ti => ti.Price)
                                      .ToArray()

                                  })
                                  .OrderByDescending(t => t.Halls)
                                  .ThenBy(t => t.Name)
                                  .ToArray();

            string json = JsonConvert.SerializeObject(theaters, Formatting.Indented);
            return json;
        }

        public static string ExportPlays(TheatreContext context, double rating)
        {
            StringBuilder sb = new StringBuilder();
            XmlRootAttribute root = new XmlRootAttribute("Plays");
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            XmlSerializer serializer = new XmlSerializer(typeof(ExportPlayDto[]), root);

           

            var plays = context.Plays
                               .ToArray()
                               .Where(p=> p.Rating <= rating)
                               .Select(p=> new ExportPlayDto
                               {
                                   Title = p.Title,
                                   Duration = p.Duration.ToString("c", CultureInfo.InvariantCulture),
                                   Rating = p.Rating.ToString() == "0" ? "Premier" : p.Rating.ToString(),
                                   Genre = p.Genre.ToString(),
                                   Actors = p.Casts
                                             .ToArray()
                                             .Where(c=> c.IsMainCharacter == true)
                                             .Select(c=> new PlayActorExportDto
                                             {
                                                 FullName = c.FullName,
                                                 MainCharactrer = $"Plays main character in '{p.Title}'."
                                             })
                                             .OrderByDescending(c=> c.FullName)
                                             .ToArray()
                               })
                               .OrderBy(p=> p.Title)
                               .ThenByDescending(p=> p.Genre)
                               .ToArray();


            StringWriter writer = new StringWriter(sb);

            serializer.Serialize(writer, plays, namespaces);

            return sb.ToString().TrimEnd();
        }
    }
}
