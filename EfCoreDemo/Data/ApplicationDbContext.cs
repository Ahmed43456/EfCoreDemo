using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EfCoreDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}

