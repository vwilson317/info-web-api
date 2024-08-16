using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BodyByBurgersInfoApi.BusinessLogic
{
    public class InfoContext : DbContext
    {
        public InfoContext(DbContextOptions<InfoContext> options) : base(options)
        {
        }
        public DbSet<Review> Review { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<Picture> Picture { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //const iconOptions = ['new-box', 'egg-fried', 'cheese', 'bread-slice-outline', 'leaf', 'chili-hot-outline', 'cow'];

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Review>()
            .Property(r => r.Id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<Review>()
                .HasMany(r => r.Ingredients)
                .WithMany();

            modelBuilder.Entity<Review>()
                .HasMany(r => r.Pics)
                .WithOne()
                .HasForeignKey(p => p.ReviewId);


            modelBuilder.Entity<Ingredient>()
                .HasData(DataSeed.Ingredients);
            modelBuilder.Entity<Review>()
                .HasData(DataSeed.Reviews);
            modelBuilder.Entity<Picture>()
                .HasData(DataSeed.Pictures);
            modelBuilder.Entity("IngredientReview")
                .HasData(DataSeed.IngredientReviews);
        }
    }
}