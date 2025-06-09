using Microsoft.EntityFrameworkCore;

namespace Stationery_Management_System
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }

}
