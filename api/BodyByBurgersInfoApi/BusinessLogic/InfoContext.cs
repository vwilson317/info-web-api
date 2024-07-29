using Microsoft.EntityFrameworkCore;

namespace BodyByBurgersInfoApi.BusinessLogic
{
    public class InfoContext : DbContext
    {
        public InfoContext(DbContextOptions<InfoContext> options) : base(options)
        {
        }
        // Add your DbSet properties here
        public DbSet<Review> Reviews { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().ToTable("Review");
        }
    }
}