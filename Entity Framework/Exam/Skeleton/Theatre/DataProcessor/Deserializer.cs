namespace Theatre.DataProcessor
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Theatre.Data;
    using Theatre.Data.Models;
    using Theatre.Data.Models.Enums;
    using Theatre.DataProcessor.ImportDto;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfulImportPlay
            = "Successfully imported {0} with genre {1} and a rating of {2}!";

        private const string SuccessfulImportActor
            = "Successfully imported actor {0} as a {1} character!";

        private const string SuccessfulImportTheatre
            = "Successfully imported theatre {0} with #{1} tickets!";

        public static string ImportPlays(TheatreContext context, string xmlString)
        {
            StringReader reader = new StringReader(xmlString);

            XmlRootAttribute root = new XmlRootAttribute("Plays");

            XmlSerializer serializer = new XmlSerializer(typeof(PlayImportDto[]), root);

            StringBuilder sb = new StringBuilder();

            List<Play> plays = new List<Play>();

            var dtos = (PlayImportDto[])serializer.Deserialize(reader);

            foreach (var dto in dtos)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                object genre;
                bool isGenreValid = Enum.TryParse(typeof(Genre), dto.Genre, out genre);

                if (!isGenreValid)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Genre g = (Genre)genre;

                TimeSpan duration;
                bool isDurationValid = TimeSpan.TryParseExact(dto.Duration, "c",
                    CultureInfo.InvariantCulture, out duration);

                if (!isDurationValid)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if(duration.Hours < 1)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Play p = new Play
                {
                    Title = dto.Title,
                    Duration = duration,
                    Rating = dto.Rating,
                    Genre = g,
                    Description = dto.Description,
                    Screenwriter = dto.Screenwriter
                };

                plays.Add(p);
                sb.AppendLine(String.Format(SuccessfulImportPlay, p.Title, p.Genre, p.Rating));
            }

            context.Plays.AddRange(plays);

            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportCasts(TheatreContext context, string xmlString)
        {

            StringReader reader = new StringReader(xmlString);

            XmlRootAttribute root = new XmlRootAttribute("Casts");

            XmlSerializer serializer = new XmlSerializer(typeof(ImportCastDto[]), root);

            StringBuilder sb = new StringBuilder();

            List<Cast> casts = new List<Cast>();

            var dtos = (ImportCastDto[])serializer.Deserialize(reader);

            foreach (var dto in dtos)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Cast c = new Cast
                {
                    FullName = dto.FullName,
                    IsMainCharacter = dto.IsMainCharacter,
                    PhoneNumber = dto.PhoneNumber,
                    PlayId = dto.PlayId
                };

                casts.Add(c);

                string leserOrMain = "";
                if (c.IsMainCharacter)
                {
                    leserOrMain = "main";
                }
                else
                {
                    leserOrMain = "lesser";
                }

                sb.AppendLine(String.Format(SuccessfulImportActor, c.FullName, leserOrMain));
            }

            context.Casts.AddRange(casts);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportTtheatersTickets(TheatreContext context, string jsonString)
        {
            var dtos = JsonConvert.DeserializeObject<IEnumerable<TheatersImportDto>>(jsonString);

            List<Theatre> theatres = new List<Theatre>();

            StringBuilder sb = new StringBuilder();

            foreach (var dto in dtos)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Theatre t = new Theatre
                {
                    Name = dto.Name,
                    NumberOfHalls = dto.NumberOfHalls,
                    Director = dto.Director
                };

                List<Ticket> tickets = new List<Ticket>();
                foreach (var ticket in dto.Tickets)
                {

                    if (!IsValid(ticket))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    var playId = context.Theatres.Select(t => t.Tickets.FirstOrDefault(p => p.Id == ticket.PlayId));
                    if (playId == null)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    Ticket tick = new Ticket
                    {
                        Price = ticket.Price,
                        RowNumber = ticket.RowNumber,
                        PlayId = ticket.PlayId
                    };

                    tickets.Add(tick);
                }

                t.Tickets = tickets;
                theatres.Add(t);
                sb.AppendLine(String.Format(SuccessfulImportTheatre, t.Name, t.Tickets.Count));
            }

            context.Theatres.AddRange(theatres);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }


        private static bool IsValid(object obj)
        {
            var validator = new ValidationContext(obj);
            var validationRes = new List<ValidationResult>();

            var result = Validator.TryValidateObject(obj, validator, validationRes, true);
            return result;
        }
    }
}
