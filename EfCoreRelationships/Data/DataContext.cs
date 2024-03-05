using Microsoft.EntityFrameworkCore;

namespace EfCoreRelationships.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        { 

        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Backpack> BackPacks { get; set; }
        public DbSet<Faction> Factions { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

    }
}
