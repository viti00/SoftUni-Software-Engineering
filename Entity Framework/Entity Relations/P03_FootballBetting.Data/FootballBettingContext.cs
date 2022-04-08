using Microsoft.EntityFrameworkCore;
using P03_FootballBetting.Data.Models;
using System;

namespace P03_FootballBetting.Data
{
    public class FootballBettingContext: DbContext
    {
        public FootballBettingContext()
        {

        }

        public FootballBettingContext(DbContextOptions options)
            :base()
        {

        }

        public virtual DbSet<Team> Teams { get; set; }

        public virtual DbSet<Color> Colors { get; set; }

        public virtual DbSet<Town> Towns { get; set; }

        public virtual DbSet<Country> Countries { get; set; }

        public virtual DbSet<Player> Players { get; set; }

        public virtual DbSet<Position> Positions { get; set; }

        public virtual DbSet<PlayerStatistic> PlayerStatistics { get; set; }

        public virtual DbSet<Game> Games { get; set; }

        public virtual DbSet<Bet> Bets { get; set; }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.CONNECTION_STRING);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerStatistic>(ps =>
            {
                ps.HasKey(ps => new { ps.GameId, ps.PlayerId });
            });

            modelBuilder.Entity<Team>(e =>
            {
                e
                    .HasOne(t => t.PrimaryKitColor)
                    .WithMany(c => c.PrimaryKitTeams)
                    .HasForeignKey(t => t.PrimaryKitColorId)
                    .OnDelete(DeleteBehavior.Restrict);

                e
                    .HasOne(t => t.SecondaryKitColor)
                    .WithMany(c => c.SecondaryKitTeams)
                    .HasForeignKey(t => t.SecondaryKitColorId)
                    .OnDelete(DeleteBehavior.Restrict);

                e
                    .HasMany(g => g.HomeGames)
                    .WithOne(t => t.HomeTeam)
                    .HasForeignKey(g => g.HomeTeamId)
                    .OnDelete(DeleteBehavior.Restrict);


                e
                    .HasMany(g => g.AwayGames)
                    .WithOne(t => t.AwayTeam)
                    .HasForeignKey(g => g.AwayTeamId)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
