using ECommerceApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }

        public DbSet<Order> Orders { get; set; }
    }
}
