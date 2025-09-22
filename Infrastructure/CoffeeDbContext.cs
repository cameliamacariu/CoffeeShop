using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class CoffeeDbContext : DbContext
    {
        public CoffeeDbContext(DbContextOptions<CoffeeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Coffee> Coffee { get; set; }
    }
}
