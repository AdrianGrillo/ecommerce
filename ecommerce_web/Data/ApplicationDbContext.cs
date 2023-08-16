using ecommerce_web.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
namespace ecommerce_web.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Passing DbContextOptions to the class ApplicationDbContext that then pass those options to the base class, DbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        // Override b/c we're overriding default behavior of OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed 3 rows in Categories table
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );
        }
    }
}
