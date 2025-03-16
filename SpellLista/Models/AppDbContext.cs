using Microsoft.EntityFrameworkCore;

namespace SpellLista.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Spel> Spel { get; set; }
    }
}
