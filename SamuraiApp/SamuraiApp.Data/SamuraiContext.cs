using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;

namespace SamuraiApp.Data
{
    public class SamuraiContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Many-to-many relationships must define a joining key between two classes.
            modelBuilder.Entity<SamuraiBattle>()
                        .HasKey(s => new { s.BattleId, s.SamauraiId });

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=OWNER-PC\\SQLEXPRESS;Database=SamuraiData;Trusted_Connection=True;");
        }
    }
}
