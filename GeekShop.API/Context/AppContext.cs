using GeekShop.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GeekShop.API.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ProductEntity> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>().Property(x => x.Id);

        }
    }
}
