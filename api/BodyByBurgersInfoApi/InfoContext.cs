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
                .HasMany(r => r.Ingredients)
                .WithMany();

            modelBuilder.Entity<Ingredient>()
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
        }
    }
}