namespace BookShop.DataProcessor
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;
    using BookShop.Data.Models.Enums;
    using BookShop.DataProcessor.ExportDto;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Newtonsoft.Json;
    using Formatting = Newtonsoft.Json.Formatting;

    public class Serializer
    {
        public static string ExportMostCraziestAuthors(BookShopContext context)
        {
            var authors = context.Authors
                                 .Select(a => new
                                 {
                                     AuthorName = $"{a.FirstName} {a.LastName}",
                                     Books = a.AuthorsBooks
                                     .OrderByDescending(b => b.Book.Price)
                                     .Select(b => new
                                     {
                                         BookName = b.Book.Name,
                                         BookPrice = b.Book.Price.ToString("F2")
                                     })
                                     .ToArray()
                                 })
                                 .ToArray()
                                 .OrderByDescending(a => a.Books.Length)
                                 .ThenBy(A => A.AuthorName)
                                 .ToArray();

            string jsonString = JsonConvert.SerializeObject(authors, Formatting.Indented);

            return jsonString;
                                 
        }

        public static string ExportOldestBooks(BookShopContext context, DateTime date)
        {
            StringBuilder sb = new StringBuilder();

            XmlRootAttribute root = new XmlRootAttribute("Books");

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            var books = context.Books
                               .Where(b => b.PublishedOn < date && b.Genre == Genre.Science)
                               .OrderByDescending(b => b.Pages)
                               .ThenByDescending(b => b.PublishedOn)
                               .Select(b => new ExportBookDto()
                               {
                                   Pages = b.Pages,
                                   Name = b.Name,
                                   Date = b.PublishedOn.ToString("d", CultureInfo.InvariantCulture)
                               })
                               .Take(10)
                               .ToArray();

            StringWriter writer = new StringWriter(sb);

            XmlSerializer serializer = new XmlSerializer(typeof(ExportBookDto[]), root);

            serializer.Serialize(writer, books, namespaces);

            return sb.ToString().TrimEnd();
        }
    }
}