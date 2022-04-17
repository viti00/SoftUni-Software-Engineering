namespace MusicHub
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Data;
    using Initializer;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            MusicHubDbContext context = 
                new MusicHubDbContext();

            DbInitializer.ResetDatabase(context);

            //Test your solutions here

            string result = ExportSongsAboveDuration(context, 4);

            Console.WriteLine(result);
        }

        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            var albumsByProducer = context.Albums
                              .ToList()
                              .Where(a => a.ProducerId == producerId)
                              .OrderByDescending(a => a.Price)
                              .Select(a => new
                              {
                                  AlbumName = a.Name,
                                  ReleaseDate = a.ReleaseDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture),
                                  ProducerName = a.Producer.Name,
                                  Songs = a.Songs
                                  .ToList()
                                  .Select(s => new
                                  {
                                      SongName = s.Name,
                                      SongPrice = s.Price.ToString("f2"),
                                      WriterName = s.Writer.Name
                                  })
                                  .OrderByDescending(s=> s.SongName)
                                  .ThenBy(s=> s.WriterName)
                                  .ToList(),
                                  TotalAlbumPrice = a.Price.ToString("f2")
                              })
                              .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var album in albumsByProducer)
            {
                sb
                    
                  .AppendLine($"-AlbumName: {album.AlbumName}")
                 .AppendLine($"-ReleaseDate: {album.ReleaseDate}")
                 .AppendLine($"-ProducerName: {album.ProducerName}")
                 .AppendLine("-Songs:");
                int i = 1;
                foreach (var song in album.Songs)
                {
                    sb
                        .AppendLine($"---#{i++}")
                       .AppendLine($"---SongName: {song.SongName}")
                       .AppendLine($"---Price: {song.SongPrice}")
                       .AppendLine($"---Writer: {song.WriterName}");
                    
                }
                sb.AppendLine($"-AlbumPrice: {album.TotalAlbumPrice}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            var songsAboveDuration = context.Songs
                                            .ToList()
                                            .Where(s => s.Duration.TotalSeconds > duration)
                                            .Select(s => new
                                            {
                                                SongName = s.Name,
                                                Weiter = s.Writer.Name,
                                                Performer = s.SongPerformers
                                                .ToList()
                                                .Select(sp=> $"{sp.Performer.FirstName} {sp.Performer.LastName}")
                                                .FirstOrDefault(),
                                                AlbumProducer = s.Album.Producer.Name,
                                                Duration =  s.Duration.ToString("c", CultureInfo.InvariantCulture)
                                            })
                                            .OrderBy(s => s.SongName)
                                            .ThenBy(s=> s.Weiter)
                                            .ThenBy(s => s.Performer)
                                            .ToList();
            StringBuilder sb = new StringBuilder();
            int i = 1;
            foreach (var song in songsAboveDuration)
            {
                sb
                    .AppendLine($"-Song #{i++}")
                    .AppendLine($"---SongName: {song.SongName}")
                    .AppendLine($"---Writer: {song.Weiter}")
                    .AppendLine($"---Performer: {song.Performer}")
                    .AppendLine($"---AlbumProducer: {song.AlbumProducer}")
                    .AppendLine($"---Duration: {song.Duration}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
