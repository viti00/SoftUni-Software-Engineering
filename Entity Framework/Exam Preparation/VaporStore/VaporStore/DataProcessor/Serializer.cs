namespace VaporStore.DataProcessor
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Newtonsoft.Json;
    using VaporStore.Data.Models.Enums;
    using VaporStore.DataProcessor.Dto.Export;

    public static class Serializer
    {
        public static string ExportGamesByGenres(VaporStoreDbContext context, string[] genreNames)
        {
            var games = context.Genres
                               .Where(g => genreNames.Contains(g.Name))
                               .ToArray()
                               .Select(g => new
                               {
                                   Id = g.Id,
                                   Genre = g.Name,
                                   Games = g.Games
                                            .Where(ga => ga.Purchases.Any())
                                            .Select(ga => new
                                            {
                                                Id = ga.Id,
                                                Title = ga.Name,
                                                Developer = ga.Developer.Name,
                                                Tags = ga.GameTags.Select(t => string.Join(", ", t.Tag.Name)).ToArray(),
                                                Players = ga.Purchases.Count
                                            })
                                            .OrderByDescending(ga => ga.Players)
                                            .ThenBy(ga => ga.Id)
                                            .ToArray(),
                                   TotalPlayers = g.Games.Sum(ga => ga.Purchases.Count)
                               })
                               .OrderByDescending(g => g.TotalPlayers)
                               .ThenBy(g => g.Id)
                               .ToArray();

            string json = JsonConvert.SerializeObject(games);

            return json;
        }

        public static string ExportUserPurchasesByType(VaporStoreDbContext context, string storeType)
        {
            XmlRootAttribute root = new XmlRootAttribute("Users");
            StringBuilder sb = new StringBuilder();

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            PurchaseType pType = Enum.Parse<PurchaseType>(storeType);

            var users = context.Users
                               .ToArray()
                               .Where(u => u.Cards.Any(c => c.Purchases.Any()))
                               .Select(u => new ExportUserDto
                               {
                                   Username = u.Username,
                                   Purchases = context.Purchases
                                                      .Where(p => p.Card.User.Username == u.Username && p.Type == pType)
                                                      .OrderBy(p => p.Date)
                                                      .Select(p => new ExportUserPurcahsesDto
                                                      {
                                                          Card = p.Card.Number,
                                                          Cvc = p.Card.Cvc,
                                                          Date = p.Date.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
                                                          Game = new ExportUserPurchasesGames
                                                          {
                                                              Title = p.Game.Name,
                                                              Genre = p.Game.Genre.Name,
                                                              Price = p.Game.Price
                                                          }

                                                      })
                                                      .ToArray(),
                                   TotalSpent = context.Purchases
                                                       .Where(p => p.Card.User.Username == u.Username && p.Type == pType)
                                                       .Sum(p=> p.Game.Price)

                               })
                               .Where(u=> u.Purchases.Length > 0)
                               .OrderByDescending(u => u.TotalSpent)
                               .ThenBy(u => u.Username)
                               .ToArray();

            StringWriter writer = new StringWriter(sb);
            XmlSerializer serialzier = new XmlSerializer(typeof(ExportUserDto[]), root);

            serialzier.Serialize(writer, root, namespaces);

            return sb.ToString().TrimEnd();
        }
    }
}