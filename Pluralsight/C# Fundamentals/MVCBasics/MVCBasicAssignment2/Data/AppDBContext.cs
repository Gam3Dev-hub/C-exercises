using Microsoft.EntityFrameworkCore;
using MVCBasicAssignment2.Models;

namespace MVCBasicAssignment2.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) :base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
