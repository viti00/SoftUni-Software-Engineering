namespace BookShop.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using BookShop.Data.Models;
    using BookShop.Data.Models.Enums;
    using BookShop.DataProcessor.ImportDto;
    using Data;
    using Newtonsoft.Json;
    using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedBook
            = "Successfully imported book {0} for {1:F2}.";

        private const string SuccessfullyImportedAuthor
            = "Successfully imported author - {0} with {1} books.";

        public static string ImportBooks(BookShopContext context, string xmlString)
        {
            StringReader reader = new StringReader(xmlString);

            XmlRootAttribute root = new XmlRootAttribute("Books");

            XmlSerializer serializer = new XmlSerializer(typeof(ImportBookDto[]), root);

            var dtos = (ImportBookDto[])serializer.Deserialize(reader);

            StringBuilder sb = new StringBuilder();

            List<Book> books = new List<Book>();

            foreach (var dto in dtos)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                DateTime date;
                bool isDateValid = DateTime.TryParseExact(dto.PublishedOn, "MM/dd/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out date);

                if (!isDateValid)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Book b = new Book
                {
                    Name = dto.Name,
                    Genre = (Genre)dto.Genre,
                    Price = dto.Price,
                    Pages = dto.Pages,
                    PublishedOn = date
                };

                books.Add(b);
                sb.AppendLine(String.Format(SuccessfullyImportedBook, b.Name, b.Price));
            }

            context.Books.AddRange(books);
            context.SaveChanges();


            return sb.ToString().TrimEnd();
        }

        public static string ImportAuthors(BookShopContext context, string jsonString)
        {
            var dtos = JsonConvert.DeserializeObject<IEnumerable<AuthorImportDto>>(jsonString);

            List<Author> authors = new List<Author>();
            List<string> emails = new List<string>();

            StringBuilder sb = new StringBuilder();

            foreach (var dto in dtos)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (emails.Contains(dto.Email))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                emails.Add(dto.Email);

                Author a = new Author
                {
                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    Phone = dto.Phone,
                    Email = dto.Email
                };

                foreach (var book in dto.Books)
                {
                    var b = context.Books.FirstOrDefault(bk => bk.Id == book.Id);
                    if (b == null)
                    {
                        continue;
                    }

                    a.AuthorsBooks.Add(new AuthorBook
                    {
                        Author = a,
                        BookId = b.Id
                    });
                }

                if(a.AuthorsBooks.Count == 0)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                authors.Add(a);
                string fullName = $"{a.FirstName} {a.LastName}";
                sb.AppendLine(String.Format(SuccessfullyImportedAuthor, fullName, a.AuthorsBooks.Count));
            }

            context.Authors.AddRange(authors);
            context.SaveChanges();


            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}