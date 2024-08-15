using BodyByBurgersInfoApi.BusinessLogic;

public static class DataSeed
{
    public static IEnumerable<Ingredient> Ingredients { get; set; }
    public static IEnumerable<Review> Reviews { get; set; }
    public static IEnumerable<dynamic> IngredientReviews { get; set; }
    static DataSeed()
    {
        Ingredients = SeedIngredients();
        Reviews = SeedReviews();
        IngredientReviews = SeedIngredientReviews();
    }

    private static IEnumerable<Ingredient> SeedIngredients()
    {
        return new List<Ingredient>(){
            new Ingredient { Id = 1, Name = "Lettuce", Icon = "leaf" },
                new Ingredient { Id = 2, Name = "Tomato", Icon = "new-box" },
                new Ingredient { Id = 3, Name = "Onion", Icon = "new-box" },
                new Ingredient { Id = 4, Name = "Cheese", Icon = "cheese" },
                new Ingredient { Id = 5, Name = "Pickles", Icon = "new-box" },
                new Ingredient { Id = 6, Name = "Bacon", Icon = "pig-variant-outline" },
                new Ingredient { Id = 7, Name = "Ketchup", Icon = "new-box" },
                new Ingredient { Id = 8, Name = "Mustard", Icon = "new-box" },
                new Ingredient { Id = 9, Name = "Mayonnaise", Icon = "new-box" },
                new Ingredient { Id = 10, Name = "Beef Patty", Icon = "cow" },
                new Ingredient { Id = 11, Name = "Chicken Patty", Icon = "chicken" },
                new Ingredient { Id = 12, Name = "Veggie Patty", Icon = "leaf" },
                new Ingredient { Id = 13, Name = "Fried Egg", Icon = "egg-fried" },
                new Ingredient { Id = 14, Name = "Cheddar", Icon = "cheese"},
                new Ingredient { Id = 15, Name = "Gouda", Icon = "cheese" },
                new Ingredient { Id = 16, Name = "American", Icon = "cheese" },
                new Ingredient { Id = 17, Name = "Mozzarella", Icon = "cheese" },
                new Ingredient { Id = 18, Name = "Swiss", Icon = "cheese" },
                new Ingredient { Id = 19, Name = "Pepper Jack", Icon = "cheese" },
                new Ingredient { Id = 20, Name = "Brioche Bun", Icon = "bread-slice-outline" },
                new Ingredient { Id = 21, Name = "Sesame Bun", Icon = "bread-slice-outline" },
                new Ingredient { Id = 22, Name = "Pretzel Bun", Icon = "bread-slice-outline" },
                new Ingredient { Id = 23, Name = "Ciabatta Bun", Icon = "bread-slice-outline" },
                new Ingredient { Id = 24, Name = "Gluten Free Bun", Icon = "bread-slice-outline" },
                new Ingredient { Id = 25, Name = "Wheat Bun", Icon = "bread-slice-outline" },
                new Ingredient { Id = 26, Name = "Mayo", Icon = "liquid-spot" },
                new Ingredient { Id = 27, Name = "Hot Sauce", Icon = "liquid-spot" },
                new Ingredient { Id = 28, Name = "BBQ Sauce", Icon = "liquid-spot" },
                new Ingredient { Id = 29, Name = "Ranch", Icon = "liquid-spot" },
                new Ingredient { Id = 30, Name = "Buffalo Sauce", Icon = "liquid-spot" },
                new Ingredient { Id = 31, Name = "Honey Mustard", Icon = "liquid-spot" },
                new Ingredient { Id = 32, Name = "Chipotle Mayo", Icon = "liquid-spot" },
                new Ingredient { Id = 33, Name = "Garlic Aioli", Icon = "liquid-spot" },
                new Ingredient { Id = 34, Name = "Truffle Aioli", Icon = "liquid-spot" },
                new Ingredient { Id = 35, Name = "Peanut Butter", Icon = "peanut-outline" },
                new Ingredient { Id = 36, Name = "Jelly", Icon = "jellyfish-outline" },
                new Ingredient { Id = 37, Name = "Bacon Jam", Icon = "pig-variant-outline" },
                new Ingredient { Id = 38, Name = "Pulled Pork", Icon = "pig-variant-outline" },
                new Ingredient { Id = 39, Name = "Onion Rings", Icon = "new-box" },
                new Ingredient { Id = 40, Name = "Fried Pickles", Icon = "new-box" },
        };
    }

    public static IEnumerable<Review> SeedReviews()
    {
        return new List<Review>(){
        new Review(){
            Id = 1,
            Date =  new DateTimeOffset(new DateTime(2024, 4, 6)),
            Location = "Burger Boss",
            Name = "Burger Boss",
            Description = @"I added an egg and bacon. bacon wasn’t crispy. egg wasn’t over easy which is a shame. 
            probably 4 stars worthy at the restaurant. 
            https://www.facebook.com/burgerboss.br",
            Rating = new decimal(3.5),
            Price = new decimal(8),
            GeoLocation = "n/a",
            Insta = "n/a",
            //Ingredients = new List<Ingredient>(){
                // new () { Id = 5, ReviewId = 1 },
                // Ingredients.ElementAt(13),
                // Ingredients.ElementAt(4),
                // Ingredients.ElementAt(5),
            //}
        },
        new Review(){
            Id = 2,
            Date =  new DateTimeOffset(new DateTime(2024, 4, 8)),
            Location = "Burgers and Beyond  (Shoreditch London)",
            Name = "Butter Burger (double)",
            Description = @"bun toasted sesame seed. bacon was cooked perfectly. 
            ordered medium - was more medium well. overall very good burger. probably better as a single. 
            maybe slightly less mayo but it was a very good burger special butter mayo.",
            Rating = new decimal(5),
            GeoLocation = "n/a",
            Insta = "n/a",
            //Ingredients = new List<Ingredient>(){
                // new Ingredient(){
                //     Id = 100,
                //     Name = "Butter Mayo",
                //     Icon = "liquid-spot"
                // },
                // new Ingredient(){
                //     Id = 4,
                //     Name = "Cheese",
                //     Icon = ""
                // },
                // new Ingredient(){
                //     Id = 6,
                //     // Name = "Bacon",
                //     // Icon = "pig-variant-outline"
                // },
            //}
        }
         };
    }

    private static IEnumerable<IngredientReview> SeedIngredientReviews()
    {
        return new List<IngredientReview>(){
            new  IngredientReview { ReviewId = Reviews.ElementAt(0).Id, IngredientsId = Ingredients.ElementAt(13).Id },
            new  IngredientReview { ReviewId = Reviews.ElementAt(0).Id, IngredientsId = Ingredients.ElementAt(3).Id },
            new  IngredientReview { ReviewId = Reviews.ElementAt(0).Id, IngredientsId = Ingredients.ElementAt(5).Id },
            new  IngredientReview { ReviewId = Reviews.ElementAt(1).Id, IngredientsId = Ingredients.ElementAt(13).Id },
        };
    }

    // TODO: should be able to use this with EF but for now this works. FIGURE OUT how to change the plura Ingredient[s]Id
    private class IngredientReview
    {
        public int ReviewId { get; set; }
        public int IngredientsId { get; set; }
    }
}

