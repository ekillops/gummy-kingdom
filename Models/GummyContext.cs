using Microsoft.EntityFrameworkCore;

namespace GummyBearKingdom.Models
{
    public class GummyContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GummyBearKingdom; integrated security=True");
        }

        public GummyContext(DbContextOptions<GummyContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

