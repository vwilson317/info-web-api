using Microsoft.EntityFrameworkCore;

namespace BodyByBurgersInfoApi.BusinessLogic
{
    public class InfoContext : DbContext
    {
        public InfoContext(DbContextOptions<InfoContext> options) : base(options)
        {
        }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        // public DbSet<ReviewIngredient> ReviewIngredients { get; set; }
        // public DbSet<ReviewPicture> ReviewPictures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //const iconOptions = ['new-box', 'egg-fried', 'cheese', 'bread-slice-outline', 'leaf', 'chili-hot-outline', 'cow'];

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Review>().ToTable("Review");
            modelBuilder.Entity<Ingredient>().ToTable("Ingredient")
            .HasData(
                new Ingredient { Id = 1, Name = "Lettuce", Icon = "leaf" },
                new Ingredient { Id = 2, Name = "Tomato", Icon = "new-box" },
                new Ingredient { Id = 3, Name = "Onion", Icon = "new-box" },
                new Ingredient { Id = 4, Name = "Cheese", Icon = "cheese" },
                new Ingredient { Id = 5, Name = "Pickles", Icon = "new-box" },
                new Ingredient { Id = 6, Name = "Bacon", Icon = "new-box" },
                new Ingredient { Id = 7, Name = "Ketchup", Icon = "new-box" },
                new Ingredient { Id = 8, Name = "Mustard", Icon = "new-box" },
                new Ingredient { Id = 9, Name = "Mayonnaise", Icon = "new-box" },
                new Ingredient { Id = 10, Name = "Beef Patty", Icon = "cow" },
                new Ingredient { Id = 11, Name = "Chicken Patty", Icon = "chicken" },
                new Ingredient { Id = 12, Name = "Veggie Patty", Icon = "leaf" },
                new Ingredient { Id = 13, Name = "Egg", Icon = "egg-fried" }
            );
            modelBuilder.Entity<Picture>().ToTable("Pic");

            // modelBuilder.Entity<ReviewIngredient>()
            //     .HasKey(ri => new { ri.ReviewId, ri.IngredientId });

            // modelBuilder.Entity<ReviewIngredient>()
            //     .HasOne(ri => ri.Review)
            //     .WithMany(r => r.ReviewIngredients)
            //     .HasForeignKey(ri => ri.ReviewId);

            // modelBuilder.Entity<ReviewIngredient>()
            //     .HasOne(ri => ri.Ingredient)
            //     .WithMany(i => i.ReviewIngredients)
            //     .HasForeignKey(ri => ri.IngredientId);

            // modelBuilder.Entity<ReviewPicture>()
            //     .HasKey(rp => new { rp.ReviewId, rp.PictureId });

            // modelBuilder.Entity<ReviewPicture>()
            //     .HasOne(rp => rp.Review)
            //     .WithMany(r => r.ReviewPictures)
            //     .HasForeignKey(rp => rp.ReviewId);

            // modelBuilder.Entity<ReviewPicture>()
            //     .HasOne(rp => rp.Picture)
            //     .WithMany(p => p.ReviewPictures)
            //     .HasForeignKey(rp => rp.PictureId);
        }
    }
}