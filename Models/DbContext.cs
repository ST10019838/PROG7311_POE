using Microsoft.EntityFrameworkCore;

namespace ST10019838_DamianDare_PROG7311_POE.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
