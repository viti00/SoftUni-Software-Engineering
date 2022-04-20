namespace BookShop
{
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            //DbInitializer.ResetDatabase(db);

            string input = Console.ReadLine();
            //int input = int.Parse(Console.ReadLine());

            string result = GetBooksReleasedBefore(db, input);

            Console.WriteLine(result);

        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            AgeRestriction ageRestriction = Enum.Parse<AgeRestriction>(command, true);

            var booksTitles = context.Books
                                    .Where(b => b.AgeRestriction == ageRestriction)
                                    .OrderBy(b => b.Title)
                                    .Select(b => b.Title)
                                    .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var book in booksTitles)
            {
                sb.AppendLine(book);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var books = context.Books
                               .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
                               .OrderBy(b => b.BookId)
                               .Select(b => b.Title)
                               .ToList();

            foreach (var book in books)
            {
                sb.AppendLine(book);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var books = context.Books
                               .Where(b => b.Price > 40)
                               .OrderByDescending(b => b.Price)
                               .Select(b => new
                               {
                                   b.Price,
                                   b.Title
                               })
                               .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - ${book.Price:F2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var books = context.Books
                               .Where(b => b.ReleaseDate.Value.Year != year)
                               .OrderBy(b => b.BookId)
                               .Select(b => b.Title)
                               .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine(book);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var categories = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(c=> c.ToLower())
                .ToList();

            var books = context.Books
            .Where(x => x.BookCategories.Any(b => categories.Contains(b.Category.Name.ToLower())))
            .Select(x => new
            {
                x.Title
            })
            .OrderBy(x => x.Title)
            .ToList();


            StringBuilder sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var books = context.Books
                               .Where(b => b.ReleaseDate.Value < DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture))
                               .OrderByDescending(b => b.ReleaseDate)
                               .Select(b => new
                               {
                                   b.Title,
                                   b.EditionType,
                                   b.Price
                               })
                               .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - {book.EditionType} - ${book.Price:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authors = context.Authors
                                 .Where(a => a.FirstName.EndsWith(input))
                                 .Select(a => new
                                 {
                                     FullName = $"{a.FirstName} {a.LastName}"
                                 })
                                 .ToList()
                                 .OrderBy(a => a.FullName);

            StringBuilder sb = new StringBuilder();

            foreach (var author in authors)
            {
                sb.AppendLine(author.FullName);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var books = context.Books
                               .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                               .OrderBy(b => b.Title)
                               .Select(b => b.Title)
                               .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine(book);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var booksAndAuthors = context.Books
                                         .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                                         .OrderBy(b => b.BookId)
                                         .Select(b => new
                                         {
                                             b.Title,
                                             AuthroFirstName = b.Author.FirstName,
                                             AuthorLastName = b.Author.LastName
                                         })
                                         .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var item in booksAndAuthors)
            {
                sb.AppendLine($"{item.Title} ({item.AuthroFirstName} {item.AuthorLastName})");
            }

            return sb.ToString().TrimEnd();
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var booksCount = context.Books
                                    .Where(b => b.Title.Length > lengthCheck)
                                    .Count();

            return booksCount;
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var authors = context.Authors
                                 .Select(a => new
                                 {
                                     FullName = $"{a.FirstName} {a.LastName}",
                                     Sum = a.Books.Sum(b=> b.Copies)
                                 })
                                 .OrderByDescending(a => a.Sum)
                                 .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var author in authors)
            {
                sb.AppendLine($"{author.FullName} - {author.Sum}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var categories = context.Categories
                                    .Select(c => new
                                    {
                                        Name = c.Name,
                                        Profit = c.CategoryBooks.Sum(b => b.Book.Price * b.Book.Copies)
                                    })
                                    .OrderByDescending(c => c.Profit).ThenBy(c => c.Name)
                                    .ToList();
                                    

            StringBuilder sb = new StringBuilder();

            foreach (var category in categories)
            {
                sb.AppendLine($"{category.Name} ${category.Profit:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var books = context.Categories
                               .Select(c => new
                               {
                                   Name = c.Name,
                                   Books = c.CategoryBooks
                                   .OrderByDescending(b=> b.Book.ReleaseDate)
                                   .Select(b => new
                                   {
                                       Title = b.Book.Title,
                                       Year = b.Book.ReleaseDate.Value.Year
                                   })
                                   .Take(3)
                                   .ToList()
                               })
                               .OrderBy(c=> c.Name)
                               .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"--{book.Name}");
                foreach (var b in book.Books)
                {
                    sb.AppendLine($"{b.Title} ({b.Year})");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static void IncreasePrices(BookShopContext context)
        {
            var books = context.Books
                                .Where(b => b.ReleaseDate.Value.Year < 2010);

            foreach (var book in books)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var books = context.Books
                               .Where(b => b.Copies < 4200);

            int count = books.Count();

            context.RemoveRange(books);

            context.SaveChanges();

            return count;
        }
    }
}
