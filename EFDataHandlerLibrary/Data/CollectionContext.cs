using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DataModelLibrary.Models;

namespace EFDataHandlerLibrary.Data
{
    public class CollectionContext : DbContext
    {
        public CollectionContext(DbContextOptions<CollectionContext> options)
            : base(options)
        {
        }

        public DbSet<SwitchGame> SwitchGames => Set<SwitchGame>();
        public DbSet<CD> CDs => Set<CD>();
        public DbSet<Vinyl> Vinyls => Set<Vinyl>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var converter = new ValueConverter<VinylSpeed, string>(
                s => s.ToString(),
                s => (VinylSpeed)Enum.Parse(typeof(VinylSpeed), s)
            );

            modelBuilder
                .Entity<Vinyl>()
                .Property(e => e.Speed)
                .HasConversion(converter);

            base.OnModelCreating(modelBuilder);
        }
    }
}
