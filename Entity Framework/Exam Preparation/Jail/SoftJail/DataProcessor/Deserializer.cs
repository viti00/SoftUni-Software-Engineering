namespace SoftJail.DataProcessor
{
    using AutoMapper;
    using Data;
    using Newtonsoft.Json;
    using SoftJail.Data.Models;
    using SoftJail.Data.Models.Enums;
    using SoftJail.DataProcessor.ImportDto;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Text;
    using System.Xml.Serialization;

    public class Deserializer
    {
        public static IMapper mapper;
        public const string ErrorMessage = "Invalid Data";
        public const string SuccsesfulyAddedDepartmentCells = "Imported {0} with {1} cells";
        public const string SuccsesfulyAddedPrisonerMails = "Imported {0} {1} years old";
        private const string SuccessfullyImportedOfficer = "Imported {0} ({1} prisoners)";

        public static string ImportDepartmentsCells(SoftJailDbContext context, string jsonString)
        {
            var dtos = JsonConvert.DeserializeObject<IEnumerable<DepartmentImportDto>>(jsonString);
            List<Department> departments = new List<Department>();

            StringBuilder sb = new StringBuilder();

            foreach (var dto in dtos)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }


                Department d = new Department
                {
                    Name = dto.Name
                };


                List<Cell> cells = new List<Cell>();

                bool areAllCellIsValid = true;

                foreach (var cell in dto.Cells)
                {
                    if (!IsValid(cell))
                    {
                        areAllCellIsValid = false;
                        break;
                    }

                    Cell c = new Cell
                    {
                        CellNumber = cell.CellNumber,
                        HasWindow = cell.HasWindow
                    };

                    cells.Add(c);
                }

                if (!areAllCellIsValid)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if(cells.Count == 0)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                d.Cells = cells;
                departments.Add(d);
                sb.AppendLine(String.Format(SuccsesfulyAddedDepartmentCells, d.Name, d.Cells.Count));
            }

            context.Departments.AddRange(departments);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportPrisonersMails(SoftJailDbContext context, string jsonString)
        {
            var dtos = JsonConvert.DeserializeObject<IEnumerable<PrisonerImportDto>>(jsonString);

            StringBuilder sb = new StringBuilder();

            List<Prisoner> prisoners = new List<Prisoner>();

            foreach (var dto in dtos)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                DateTime incarcerationDate;
                bool incarcerationDateValid = DateTime.TryParseExact(dto.IncarcerationDate, "dd/MM/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out incarcerationDate);

                if (!incarcerationDateValid)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                DateTime? releaseDate = null;

                if (!String.IsNullOrEmpty(dto.ReleaseDate))
                {
                    DateTime releaseDateValue;
                    bool isRelaseDateValid = DateTime.TryParseExact(dto.ReleaseDate, "dd/MM/yyyy",
                        CultureInfo.InvariantCulture, DateTimeStyles.None, out releaseDateValue);

                    if (!isRelaseDateValid)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    releaseDate = releaseDateValue;
                }


                Prisoner p = new Prisoner
                {
                    FullName = dto.FullName,
                    Nickname = dto.Nickname,
                    Age = dto.Age,
                    IncarcerationDate = incarcerationDate,
                    ReleaseDate = releaseDate,
                    Bail = dto.Bail,
                    CellId = dto.CellId
                };

                List<Mail> mails = new List<Mail>();
                bool areAllMailValid = true;
                foreach (var mail in dto.Mails)
                {
                    if (!IsValid(mail))
                    {
                        areAllMailValid = false;
                        break;
                    }

                    Mail m = new Mail
                    {
                        Description = mail.Description,
                        Sender = mail.Sender,
                        Address = mail.Address
                    };

                    mails.Add(m);
                }

                if (!areAllMailValid)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                p.Mails = mails;
                prisoners.Add(p);
                sb.AppendLine(String.Format(SuccsesfulyAddedPrisonerMails, p.FullName, p.Age));
            }

            context.Prisoners.AddRange(prisoners);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportOfficersPrisoners(SoftJailDbContext context, string xmlString)
        {
            StringReader reader = new StringReader(xmlString);
            XmlRootAttribute root = new XmlRootAttribute("Officers");
            XmlSerializer serializer = new XmlSerializer(typeof(OfficerImportDto[]), root);

            var dtos = (OfficerImportDto[])serializer.Deserialize(reader);

            StringBuilder sb = new StringBuilder();

            List<Officer> officers = new List<Officer>();

            foreach (var dto in dtos)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                object weaponEnum;
                bool IsWeaponEnumValid = Enum.TryParse(typeof(Weapon), dto.Weapon, out weaponEnum);

                if (!IsWeaponEnumValid)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Weapon w = (Weapon)weaponEnum;

                object positionEnum;
                bool IsPositionEnumValid = Enum.TryParse(typeof(Position), dto.Position, out positionEnum);

                if (!IsPositionEnumValid)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Position p = (Position)positionEnum;

                Officer of = new Officer
                {
                    FullName = dto.FullName,
                    Salary = dto.Salary,
                    Position = p,
                    Weapon = w,
                    DepartmentId = dto.DepartmentId
                };

                foreach (var prisoner in dto.Prisoners)
                {

                    of.OfficerPrisoners.Add(new OfficerPrisoner
                    {
                        Officer = of,
                        PrisonerId = prisoner.Id
                    });

                }

                officers.Add(of);
                sb.AppendLine(String.Format(SuccessfullyImportedOfficer, of.FullName, of.OfficerPrisoners.Count));
            }

            context.Officers.AddRange(officers);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var validationResult = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(obj, validationContext, validationResult, true);
            return isValid;
        }

        public static void InitizalizeMapper()
        {
            var config = new MapperConfiguration(c =>
            {
                c.AddProfile<SoftJailProfile>();
            });

            mapper = config.CreateMapper();
        }
    }
}