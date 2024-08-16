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
new Ingredient { Id = (int)IngredientType.BlackAngus, Name = "Black Angus", Icon = "cow" },
new Ingredient { Id = (int)IngredientType.SteakSauce, Name = "Stack Sauce", Icon = "liquid-spot" },
new Ingredient { Id = (int)IngredientType.Fries, Name = "Fries", Icon = "new-box" },
new Ingredient { Id = (int)IngredientType.Chillies, Name = "Chillies", Icon = "chili-hot-outline" },
new Ingredient { Id = (int)IngredientType.FriedJalapenos, Name = "Fried Jalapenos", Icon = "chili-hot-outline" },
new Ingredient { Id = (int)IngredientType.RedOnions, Name = "Red Onions", Icon = "new-box" },
new Ingredient { Id = (int)IngredientType.GroundRibEye, Name = "Ground Rib-Eye", Icon = "cow" },
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
        },
                new Review(){
            Id = 4,
            Date =  new DateTimeOffset(new DateTime(2024, 4, 9)),
            Location = "MEATliqour",
            Name = "Green Chili Double",
            Description = @"a bit on the small side. messy to eat. solid but not amazing. i’ve been here before and only realized after i was on the way. the place is located in what feels like a neighborhood lol. 
            Can’t put my finger on what i’d improve but it does leave you wanting a bit more. maybe it’s the size. smash patties were cooked medium rare and it was juicy. 
            maybe i’m being hard on it because the burger from burgers and beyond is better and they’re very close to each other location wise. order the green chile fries to match. 
            was less impressed by that.  the nacho cheese was a bit much. but they were tasty.
             think the price during lunch is reasonable so i give it a little bum because of that.
             address: 15 Hoxton Market, London N1 6HG, United Kingdom",
            Rating = new decimal(4.5),
            GeoLocation = "n/a",
            Insta = ""
        },
        new Review(){
            Id = 5,
            Date =  new DateTimeOffset(new DateTime(2024, 4, 9)),
            Location = "Smokey Boys",
            Name = "Smokey Bad Boy",
            Description = @"solid burger. fresh ingredients. i forgot to add an egg. meat was pretty dry.
             very spicy which i like. didn’t have any woah factor. 
            for the ingredients listed i expected more.
             the bad boy sauce i think over powered the favor.",
            Rating = new decimal(3.5),
            Price = new decimal(16.77),
            GeoLocation = "n/a",
            Insta = ""
        },
                new Review(){
            Id = 6,
            Date =  new DateTimeOffset(new DateTime(2024, 4, 18)),
            Location = "LA Central Burger",
            Name = "Double smash (Black Angus)",
            Description = @"egg was over cooked. tons of pickles. 
            perfect brioche bun. meat was exceptional. probably sauced",
            Rating = new decimal(4.5),
            Price = new decimal(0),
            GeoLocation = "n/a",
            Insta = ""
        },
            new Review(){
            Id = 7,
            Date =  new DateTimeOffset(new DateTime(2024, 4, 25)),
            Location = "Ground Burger (Lisbon)",
            Name = "Chili Con Carne",
            Description = @"I would have to say almost perfect. i don’t feel like i can give a perfect rating but this is damn near close. 
            meat was cooked perfectly (medium rare). added an egg which was also cooked prefect. 
            bacon wasn’t crispy but that could be due to the chili. japenqos were sweet than spicy.
             overall i’m very impressed. only criticism is that when i cut it.
             the second half didn’t have as much meat. could of been a poor knife job on my part",
            Rating = new decimal(5),
            Price = new decimal(32.96),
            GeoLocation = "n/a",
            Insta = ""
        },
        new Review(){
            Id = 8,
            Date =  new DateTimeOffset(new DateTime(2024, 4, 27)),
            Location = "Ground Burger (Time Out Market: Lisbon)",
            Name = "Double Cheese",
            Description = @"having a hard time rating this. since the chili burger was amazing. this was extremely disappointing.
             meat was cooked well done. and since it was 70% of the burger it didn’t really help the situation.
              egg was also over cooked. i went during lunch time so maybe the crowd reduced the quality.
            also come to the conclusion i don’t like doubles unless they’re smash patty’s.
             just too much meat to bun for it to be enjoyable otherwise.
             also 24 euros is a bit of a buzz kill",
            Rating = new decimal(4),
            Price = new decimal(26.00),
            GeoLocation = "n/a",
            Insta = ""
        },
                new Review(){
            Id = 9,
            Date =  new DateTimeOffset(new DateTime(2024, 4, 26)),
            Location = "To.b (Lisbon)",
            Name = "Hot",
            Description = @"I added bacon. first bite i had a very fresh taste in my mouth.
             normally don’t do lettuce but it was nice on this burger.
              hot is definitely not proper heat. mild at best.
               very solid. meat was cooked medium/medium rare without requesting it.
             got sweet potato chips. they’re what you’d expect. price 15 euros",
            Rating = new decimal(4.5),
            Price = new decimal(16.50),
            GeoLocation = "n/a",
            Insta = ""
        },
        new Review(){
            Id = 10,
            Date =  new DateTimeOffset(new DateTime(2024, 4, 28)),
            Location = "Nathan’s (Miami Airport)",
            Name = "Double Cheese",
            Description = @"I knew it wouldn’t be good, still managed even failed to meet my low expectations.
             meat was dry and chewy. i didn’t even bother to eat the bun. it was an egg bun i think. very dense.
             funny enough the ketchup made it more editable. american cheese, ketchup, raw white onions",
            Rating = new decimal(1.0),
            Price = new decimal(0),
            GeoLocation = "n/a",
            Insta = ""
        },
        new Review(){
            Id = 11,
            Date =  new DateTimeOffset(new DateTime(2024, 8, 10)),
            Location = "Burgers and Beyond (Shoreditch London)",
            Name = "The Bougie Burher",
            Description = @"First impression: Saucy not in a good best way. 
            The sauce caused the bun to become soggy and it didn't hold up well when biting. 
            Next time get the sauce and manasise on the side. Meat was well cooked,
            Ingredients: Dry Aged Beef Patties, Cold Smoked American Cheese, Steak Sauce 2.0, Marrownaise, Beef Fat Onions",
            Rating = new decimal(5),
            Price = new decimal(0),
            GeoLocation = "n/a",
            Insta = ""
        },
                new Review(){
            Id = 12,
            Date =  new DateTimeOffset(new DateTime(2024, 8, 11)),
            Location = "Honest Burger (London)",
            Name = "Smashed By Honest",
            Description = @"crispy with an explosion of sayory favor. Only thing is I wish it was bigger.
             Luckily i ordered another one",
            Rating = new decimal(5),
            Price = new decimal(0),
            GeoLocation = "n/a",
            Insta = "",
        },
            new Review(){
            Id = 13,
            Date =  new DateTimeOffset(new DateTime(2024, 8, 11)),
            Location = "Honest Burger (London)",
            Name = "Chili Burger",
            Description = "First bite: tasted fresh. On the smaller side of things",
            Rating = new decimal(5),
            Price = new decimal(0),
            GeoLocation = "n/a",
            Insta = "",
        },
            new Review(){
            Id = 14,
            Date =  new DateTimeOffset(new DateTime(2024, 8, 14)),
            Location = "Five guys (London)",
            Name = "Double Cheese",
            Description = @"First bite: exactly what you'd expect from a smashed burger. 
            I always added bacon, japs, mushrooms and oions. Tasted very fresh. I was satisfied by the end of it.
             only small issue is it wasn't that hot. it was midnight so i assume that had a little to do with it.",
            Rating = new decimal(4),
            Price = new decimal(0),
            GeoLocation = "n/a",
            Insta = "",
        },
            new Review(){
            Id = 15,
            Date =  new DateTimeOffset(new DateTime(2024, 8, 5)),
            Location = "Bj's (Rancho Cucamonga)",
            Name = "Crispy Jalapeno Burger",
            Description = @"One of my favorite chain restuarant burger. Brings back memories of having them with my mom in florida.
            Very good burger. Right amount of spice. Meat was cooked prefect for medium rare.",
            Rating= new decimal(5),
            Price = new decimal(0),
            GeoLocation = "n/a",
            Insta = "",
        },
                    new Review(){
            Id = 16,
            Date =  new DateTimeOffset(new DateTime(2024, 8, 5)),
            Location = "Outpost (Cabo San Lucas)",
            Name = "Op Burger",
            Description = @"meat was cooked perfectly for medium rare. seasoned well. maybe a bit too much lettuce but it was fresh and added a nice crispy crunch. 
            bun covered the burger perfectly. i was able to eat it without it falling apart. bacon was cooked well. had a little crunch to it. 
            ingredients: ground rib eye patty*, mozzarella cheese, bacon, lettuce
            included potato wedges. Address: Blvd. Paseo de la Marina S/N, Centro, 23450 Cabo San Lucas, B.C.S., Mexico",
            Rating= new decimal(5),
            Price = new decimal(17.50),
            GeoLocation = "n/a",
            Insta = "https://www.instagram.com/outpostcabo?igsh=cjc3eDhkNHl2N29h",
        },
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

            // smoke boys
            new IngredientReview {ReviewId = Reviews.ElementAt(4).Id,
            IngredientsId = (int)IngredientType.BeefPatty},
            new IngredientReview {ReviewId = Reviews.ElementAt(4).Id,
            IngredientsId = (int)IngredientType.American},
            new IngredientReview {ReviewId = Reviews.ElementAt(4).Id,
            IngredientsId = (int)IngredientType.Jalapenos},
            new IngredientReview {ReviewId = Reviews.ElementAt(4).Id,
            IngredientsId = (int)IngredientType.Chillies},
            new IngredientReview {ReviewId = Reviews.ElementAt(4).Id,
            IngredientsId = (int)IngredientType.SpecialSauce},
            new IngredientReview {ReviewId = Reviews.ElementAt(4).Id,
            IngredientsId = (int)IngredientType.BriocheBun},

            // nathans
            new IngredientReview {ReviewId = Reviews.ElementAt(9).Id,
            IngredientsId = (int)IngredientType.BeefPatty},
            new IngredientReview {ReviewId = Reviews.ElementAt(9).Id,
            IngredientsId = (int)IngredientType.American},
            new IngredientReview {ReviewId = Reviews.ElementAt(9).Id,
            IngredientsId = (int)IngredientType.Ketchup},
            new IngredientReview {ReviewId = Reviews.ElementAt(9).Id,
            IngredientsId = (int)IngredientType.Onion},

            new IngredientReview {ReviewId = Reviews.ElementAt(10).Id,
            IngredientsId = (int)IngredientType.BeefPatty},
             new IngredientReview {ReviewId = Reviews.ElementAt(10).Id,
            IngredientsId = (int)IngredientType.American},
             new IngredientReview {ReviewId = Reviews.ElementAt(10).Id,
            IngredientsId = (int)IngredientType.SteakSauce},
            new IngredientReview {ReviewId = Reviews.ElementAt(10).Id,
            IngredientsId = (int)IngredientType.Mayonnaise},
            new IngredientReview {ReviewId = Reviews.ElementAt(10).Id,
            IngredientsId = (int)IngredientType.CaramelizedOnions},

            new IngredientReview {ReviewId = Reviews.ElementAt(11).Id,
            IngredientsId = (int)IngredientType.BeefPatty},
             new IngredientReview {ReviewId = Reviews.ElementAt(11).Id,
            IngredientsId = (int)IngredientType.American},
             new IngredientReview {ReviewId = Reviews.ElementAt(11).Id,
            IngredientsId = (int)IngredientType.Onion},
            new IngredientReview {ReviewId = Reviews.ElementAt(11).Id,
            IngredientsId = (int)IngredientType.Pickles},
            new IngredientReview {ReviewId = Reviews.ElementAt(11).Id,
            IngredientsId = (int)IngredientType.Mustard},
             new IngredientReview {ReviewId = Reviews.ElementAt(11).Id,
            IngredientsId = (int)IngredientType.Mayo},

             new IngredientReview {ReviewId = Reviews.ElementAt(12).Id,
            IngredientsId = (int)IngredientType.BeefPatty},
             new IngredientReview {ReviewId = Reviews.ElementAt(12).Id,
            IngredientsId = (int)IngredientType.Cheddar},
             new IngredientReview {ReviewId = Reviews.ElementAt(12).Id,
            IngredientsId = (int)IngredientType.Bacon},
            new IngredientReview {ReviewId = Reviews.ElementAt(12).Id,
            IngredientsId = (int)IngredientType.HotSauce},
            new IngredientReview {ReviewId = Reviews.ElementAt(12).Id,
            IngredientsId = (int)IngredientType.Fries},
             new IngredientReview {ReviewId = Reviews.ElementAt(12).Id,
            IngredientsId = (int)IngredientType.Lettuce},
             new IngredientReview {ReviewId = Reviews.ElementAt(12).Id,
            IngredientsId = (int)IngredientType.Jalapenos},

            new IngredientReview {ReviewId = Reviews.ElementAt(13).Id,
            IngredientsId = (int)IngredientType.American},
             new IngredientReview {ReviewId = Reviews.ElementAt(13).Id,
            IngredientsId = (int)IngredientType.Bacon},
             new IngredientReview {ReviewId = Reviews.ElementAt(13).Id,
            IngredientsId = (int)IngredientType.Mushrooms},
            new IngredientReview {ReviewId = Reviews.ElementAt(13).Id,
            IngredientsId = (int)IngredientType.Onion},
            new IngredientReview {ReviewId = Reviews.ElementAt(13).Id,
            IngredientsId = (int)IngredientType.Jalapenos},

            //bj's
            new IngredientReview {ReviewId = Reviews.ElementAt(14).Id,
            IngredientsId = (int)IngredientType.FriedJalapenos},
            new IngredientReview {ReviewId = Reviews.ElementAt(14).Id,
            IngredientsId = (int)IngredientType.PepperJack},
            new IngredientReview {ReviewId = Reviews.ElementAt(14).Id,
            IngredientsId = (int)IngredientType.Mayonnaise},
            new IngredientReview {ReviewId = Reviews.ElementAt(14).Id,
            IngredientsId = (int)IngredientType.Onion},
            new IngredientReview {ReviewId = Reviews.ElementAt(14).Id,
            IngredientsId = (int)IngredientType.RedOnions},

            //op burger
               new IngredientReview {ReviewId = Reviews.ElementAt(15).Id,
            IngredientsId = (int)IngredientType.GroundRibEye},
            new IngredientReview {ReviewId = Reviews.ElementAt(15).Id,
            IngredientsId = (int)IngredientType.Mozzarella},
            new IngredientReview {ReviewId = Reviews.ElementAt(15).Id,
            IngredientsId = (int)IngredientType.Lettuce},
            new IngredientReview {ReviewId = Reviews.ElementAt(15).Id,
            IngredientsId = (int)IngredientType.Bacon},
        };
    }

    public static IEnumerable<Picture> SeedPictures()
    {
        return new List<Picture>(){
            new Picture { Id = 1, ReviewId = Reviews.ElementAt(2).Id,
             Url = "https://pub-06851190cddc4684902b556426d2e9a1.r2.dev/IMG_4685.jpg"},
            new Picture { Id = 2, ReviewId = Reviews.ElementAt(15).Id,
             Url = "https://pub-06851190cddc4684902b556426d2e9a1.r2.dev/IMG_4561.jpeg"},
               new Picture { Id = 3, ReviewId = Reviews.ElementAt(15).Id,
             Url = "https://pub-06851190cddc4684902b556426d2e9a1.r2.dev/IMG_4638.jpeg"},
                            new Picture { Id = 4, ReviewId = Reviews.ElementAt(15).Id,
             Url = "https://pub-06851190cddc4684902b556426d2e9a1.r2.dev/IMG_4639.jpeg"},
new Picture { Id = 5, ReviewId = Reviews.ElementAt(15).Id,
             Url = "https://pub-06851190cddc4684902b556426d2e9a1.r2.dev/2L3A9333.CR3.jpg"},
        };
    }

    // TODO: should be able to use this with EF but for now this works. FIGURE OUT how to change the plura Ingredient[s]Id
    private class IngredientReview
    {
        public int ReviewId { get; set; }
        public int IngredientsId { get; set; }
    }
}

