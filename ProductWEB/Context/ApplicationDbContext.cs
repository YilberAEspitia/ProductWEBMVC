using Microsoft.EntityFrameworkCore;
using ProductWEB.Models;

namespace ProductWEB.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
