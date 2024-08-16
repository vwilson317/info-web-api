using BodyByBurgersInfoApi.BusinessLogic;

public static class DataSeed
{
    public static IEnumerable<Ingredient> Ingredients { get; set; }
    public static IEnumerable<Review> Reviews { get; set; }
    public static IEnumerable<dynamic> IngredientReviews { get; set; }
    public static IEnumerable<Picture> Pictures { get; set; }

    static DataSeed()
    {
        Ingredients = SeedIngredients();
        Reviews = SeedReviews();
        IngredientReviews = SeedIngredientReviews();
        Pictures = SeedPictures();
    }

    private static IEnumerable<Ingredient> SeedIngredients()
    {
        return new List<Ingredient>(){
         new Ingredient { Id = (int)IngredientType.Lettuce, Name = "Lettuce", Icon = "leaf" },
new Ingredient { Id = (int)IngredientType.Tomato, Name = "Tomato", Icon = "new-box" },
new Ingredient { Id = (int)IngredientType.Onion, Name = "Onion", Icon = "new-box" },
new Ingredient { Id = (int)IngredientType.Cheese, Name = "Cheese", Icon = "cheese" },
new Ingredient { Id = (int)IngredientType.Pickles, Name = "Pickles", Icon = "new-box" },
new Ingredient { Id = (int)IngredientType.Bacon, Name = "Bacon", Icon = "pig-variant-outline" },
new Ingredient { Id = (int)IngredientType.Ketchup, Name = "Ketchup", Icon = "new-box" },
new Ingredient { Id = (int)IngredientType.Mustard, Name = "Mustard", Icon = "new-box" },
new Ingredient { Id =(int) IngredientType.Mayonnaise, Name = "Mayonnaise", Icon = "new-box" },
new Ingredient { Id =(int) IngredientType.BeefPatty, Name = "Beef Patty", Icon = "cow" },
new Ingredient { Id = (int)IngredientType.ChickenPatty, Name = "Chicken Patty", Icon = "chicken" },
new Ingredient { Id =(int) IngredientType.VeggiePatty, Name = "Veggie Patty", Icon = "leaf" },
new Ingredient { Id = (int)IngredientType.FriedEgg, Name = "Fried Egg", Icon = "egg-fried" },
new Ingredient { Id =(int) IngredientType.Cheddar, Name = "Cheddar", Icon = "cheese" },
new Ingredient { Id = (int)IngredientType.Gouda, Name = "Gouda", Icon = "cheese" },
new Ingredient { Id = (int)IngredientType.American, Name = "American", Icon = "cheese" },
new Ingredient { Id = (int)IngredientType.Mozzarella, Name = "Mozzarella", Icon = "cheese" },
new Ingredient { Id = (int)IngredientType.Swiss, Name = "Swiss", Icon = "cheese" },
new Ingredient { Id = (int)IngredientType.PepperJack, Name = "Pepper Jack", Icon = "cheese" },
new Ingredient { Id = (int)IngredientType.BriocheBun, Name = "Brioche Bun", Icon = "bread-slice-outline" },
new Ingredient { Id = (int)IngredientType.SesameBun, Name = "Sesame Bun", Icon = "bread-slice-outline" },
new Ingredient { Id = (int)IngredientType.PretzelBun, Name = "Pretzel Bun", Icon = "bread-slice-outline" },
new Ingredient { Id = (int)IngredientType.CiabattaBun, Name = "Ciabatta Bun", Icon = "bread-slice-outline" },
new Ingredient { Id = (int)IngredientType.GlutenFreeBun, Name = "Gluten Free Bun", Icon = "bread-slice-outline" },
new Ingredient { Id = (int)IngredientType.WheatBun, Name = "Wheat Bun", Icon = "bread-slice-outline" },
new Ingredient { Id = (int)IngredientType.Mayo, Name = "Mayo", Icon = "liquid-spot" },
new Ingredient { Id = (int)IngredientType.HotSauce, Name = "Hot Sauce", Icon = "liquid-spot" },
new Ingredient { Id = (int)IngredientType.BBQSauce, Name = "BBQ Sauce", Icon = "liquid-spot" },
new Ingredient { Id = (int)IngredientType.Ranch, Name = "Ranch", Icon = "liquid-spot" },
new Ingredient { Id = (int)IngredientType.BuffaloSauce, Name = "Buffalo Sauce", Icon = "liquid-spot" },
new Ingredient { Id =(int) IngredientType.HoneyMustard, Name = "Honey Mustard", Icon = "liquid-spot" },
new Ingredient { Id = (int)IngredientType.ChipotleMayo, Name = "Chipotle Mayo", Icon = "liquid-spot" },
new Ingredient { Id = (int)IngredientType.GarlicAioli, Name = "Garlic Aioli", Icon = "liquid-spot" },
new Ingredient { Id = (int)IngredientType.TruffleAioli, Name = "Truffle Aioli", Icon = "liquid-spot" },
new Ingredient { Id = (int)IngredientType.PeanutButter, Name = "Peanut Butter", Icon = "peanut-outline" },
new Ingredient { Id = (int)IngredientType.Jelly, Name = "Jelly", Icon = "jellyfish-outline" },
new Ingredient { Id = (int)IngredientType.BaconJam, Name = "Bacon Jam", Icon = "pig-variant-outline" },
new Ingredient { Id = (int)IngredientType.PulledPork, Name = "Pulled Pork", Icon = "pig-variant-outline" },
new Ingredient { Id =(int) IngredientType.OnionRings, Name = "Onion Rings", Icon = "new-box" },
new Ingredient { Id =(int) IngredientType.FriedPickles, Name = "Fried Pickles", Icon = "new-box" },
new Ingredient { Id = (int)IngredientType.Jalapenos, Name = "Jalapenos", Icon = "chili-hot-outline" },
new Ingredient { Id = (int)IngredientType.Avocado, Name = "Avocado", Icon = "new-box" },
new Ingredient { Id =(int) IngredientType.Mushrooms, Name = "Mushrooms", Icon = "new-box" },
new Ingredient { Id = (int)IngredientType.CaramelizedOnions, Name = "Caramelized Onions", Icon = "new-box" },
new Ingredient { Id = (int)IngredientType.WagyuBeef, Name = "Wagyu Beef", Icon = "cow" },
new Ingredient { Id = (int)IngredientType.SpecialSauce, Name = "Special Sauce", Icon = "star" },
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
            Insta = "n/a"
        },
        new Review(){
            Id = 3,
            Date =  new DateTimeOffset(new DateTime(2024, 8, 15)),
            Location = "The Grime Burger (Shoreditch London)",
            Name = "Double Grime Burger",
            Description = @"First bite impression: very large and messy. some of the meat fell out when i bit into it.
            The meat was very crumbly and other took all the flavor. It wasn't falvored very well either. A little dissapointing.
            It looked incredible as you'll see from the picture.",
            Rating = new decimal(3.5),
            GeoLocation = "n/a",
            Insta = "https://www.instagram.com/spitalfieldse1/"
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

            new  IngredientReview { ReviewId = Reviews.ElementAt(2).Id, IngredientsId = Ingredients.ElementAt(15).Id },
            new  IngredientReview { ReviewId = Reviews.ElementAt(2).Id, IngredientsId = Ingredients.ElementAt(1).Id },
            new  IngredientReview { ReviewId = Reviews.ElementAt(2).Id, IngredientsId = Ingredients.ElementAt(43).Id },
            new  IngredientReview { ReviewId = Reviews.ElementAt(2).Id, IngredientsId = Ingredients.ElementAt(4).Id },
            new  IngredientReview { ReviewId = Reviews.ElementAt(2).Id, IngredientsId = Ingredients.ElementAt((int)IngredientType.BriocheBun).Id },
        };
    }

    public static IEnumerable<Picture> SeedPictures(){
        return new List<Picture> (){
            new Picture { Id = 1, ReviewId = Reviews.ElementAt(2).Id,
             Url = "https://pub-06851190cddc4684902b556426d2e9a1.r2.dev/IMG_4685.jpg"},
            // new Picture { Id = 2, ReviewId = Reviews.ElementAt(3).Id, Url = "https://www.instagram.com/p/CM9J9J1n1Z2/" },
            // new Picture { Id = 3, ReviewId = Reviews.ElementAt(3).Id, Url = "https://www.instagram.com/p/CM9J9J1n1Z2/" },
        };
    }

    // TODO: should be able to use this with EF but for now this works. FIGURE OUT how to change the plura Ingredient[s]Id
    private class IngredientReview
    {
        public int ReviewId { get; set; }
        public int IngredientsId { get; set; }
    }
}

