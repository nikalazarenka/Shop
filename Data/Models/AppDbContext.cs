using Microsoft.EntityFrameworkCore;

namespace Shop.Data.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Clothes> Clothes { get; set; }
        public DbSet<Category> Category { get;set; }
    }
}
