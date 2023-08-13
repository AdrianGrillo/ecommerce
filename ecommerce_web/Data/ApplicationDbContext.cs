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
    }
}
