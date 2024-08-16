using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BodyByBurgersInfoApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeoLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Insta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IngredientReview",
                columns: table => new
                {
                    IngredientsId = table.Column<int>(type: "int", nullable: false),
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientReview", x => new { x.IngredientsId, x.ReviewId });
                    table.ForeignKey(
                        name: "FK_IngredientReview_Ingredient_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientReview_Review_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Review",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Picture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Picture_Review_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Review",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "Id", "Icon", "Name" },
                values: new object[,]
                {
                    { 1, "leaf", "Lettuce" },
                    { 2, "new-box", "Tomato" },
                    { 3, "new-box", "Onion" },
                    { 4, "cheese", "Cheese" },
                    { 5, "new-box", "Pickles" },
                    { 6, "pig-variant-outline", "Bacon" },
                    { 7, "new-box", "Ketchup" },
                    { 8, "new-box", "Mustard" },
                    { 9, "new-box", "Mayonnaise" },
                    { 10, "cow", "Beef Patty" },
                    { 11, "chicken", "Chicken Patty" },
                    { 12, "leaf", "Veggie Patty" },
                    { 13, "egg-fried", "Fried Egg" },
                    { 14, "cheese", "Cheddar" },
                    { 15, "cheese", "Gouda" },
                    { 16, "cheese", "American" },
                    { 17, "cheese", "Mozzarella" },
                    { 18, "cheese", "Swiss" },
                    { 19, "cheese", "Pepper Jack" },
                    { 20, "bread-slice-outline", "Brioche Bun" },
                    { 21, "bread-slice-outline", "Sesame Bun" },
                    { 22, "bread-slice-outline", "Pretzel Bun" },
                    { 23, "bread-slice-outline", "Ciabatta Bun" },
                    { 24, "bread-slice-outline", "Gluten Free Bun" },
                    { 25, "bread-slice-outline", "Wheat Bun" },
                    { 26, "liquid-spot", "Mayo" },
                    { 27, "liquid-spot", "Hot Sauce" },
                    { 28, "liquid-spot", "BBQ Sauce" },
                    { 29, "liquid-spot", "Ranch" },
                    { 30, "liquid-spot", "Buffalo Sauce" },
                    { 31, "liquid-spot", "Honey Mustard" },
                    { 32, "liquid-spot", "Chipotle Mayo" },
                    { 33, "liquid-spot", "Garlic Aioli" },
                    { 34, "liquid-spot", "Truffle Aioli" },
                    { 35, "peanut-outline", "Peanut Butter" },
                    { 36, "jellyfish-outline", "Jelly" },
                    { 37, "pig-variant-outline", "Bacon Jam" },
                    { 38, "pig-variant-outline", "Pulled Pork" },
                    { 39, "new-box", "Onion Rings" },
                    { 40, "new-box", "Fried Pickles" },
                    { 41, "chili-hot-outline", "Jalapenos" },
                    { 42, "new-box", "Avocado" },
                    { 43, "new-box", "Mushrooms" },
                    { 44, "new-box", "Caramelized Onions" },
                    { 45, "cow", "Wagyu Beef" },
                    { 46, "star", "Special Sauce" },
                    { 47, "cow", "Black Angus" },
                    { 48, "liquid-spot", "Stack Sauce" },
                    { 49, "new-box", "Fries" },
                    { 50, "chili-hot-outline", "Chillies" },
                    { 51, "chili-hot-outline", "Fried Jalapenos" },
                    { 52, "new-box", "Red Onions" },
                    { 53, "cow", "Ground Rib-Eye" }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Date", "Description", "GeoLocation", "Insta", "Location", "Name", "Price", "Rating" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "I added an egg and bacon. bacon wasn’t crispy. egg wasn’t over easy which is a shame. \n            probably 4 stars worthy at the restaurant. \n            https://www.facebook.com/burgerboss.br", "n/a", "n/a", "Burger Boss", "Burger Boss", 8m, 3.5m },
                    { 2, new DateTimeOffset(new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "bun toasted sesame seed. bacon was cooked perfectly.\n            ordered medium - was more medium well. overall very good burger. probably better as a single.\n            maybe slightly less mayo but it was a very good burger special butter mayo.", "n/a", "n/a", "Burgers and Beyond  (Shoreditch London)", "Butter Burger (double)", 0m, 5m },
                    { 3, new DateTimeOffset(new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "First bite impression: very large and messy. some of the meat fell out when i bit into it.\n            The meat was very crumbly and other took all the flavor. It wasn't falvored very well either. A little dissapointing.\n            It looked incredible as you'll see from the picture.", "n/a", "https://www.instagram.com/spitalfieldse1/", "The Grime Burger (Shoreditch London)", "Double Grime Burger", 0m, 3.5m },
                    { 4, new DateTimeOffset(new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "a bit on the small side. messy to eat. solid but not amazing. i’ve been here before and only realized after i was on the way. the place is located in what feels like a neighborhood lol. \n            Can’t put my finger on what i’d improve but it does leave you wanting a bit more. maybe it’s the size. smash patties were cooked medium rare and it was juicy. \n            maybe i’m being hard on it because the burger from burgers and beyond is better and they’re very close to each other location wise. order the green chile fries to match. \n            was less impressed by that.  the nacho cheese was a bit much. but they were tasty.\n             think the price during lunch is reasonable so i give it a little bum because of that.\n             address: 15 Hoxton Market, London N1 6HG, United Kingdom", "n/a", "", "MEATliqour", "Green Chili Double", 0m, 4.5m },
                    { 5, new DateTimeOffset(new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "solid burger. fresh ingredients. i forgot to add an egg. meat was pretty dry.\n             very spicy which i like. didn’t have any woah factor. \n            for the ingredients listed i expected more.\n             the bad boy sauce i think over powered the favor.", "n/a", "", "Smokey Boys", "Smokey Bad Boy", 16.77m, 3.5m },
                    { 6, new DateTimeOffset(new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "egg was over cooked. tons of pickles. \n            perfect brioche bun. meat was exceptional. probably sauced", "n/a", "", "LA Central Burger", "Double smash (Black Angus)", 0m, 4.5m },
                    { 7, new DateTimeOffset(new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "I would have to say almost perfect. i don’t feel like i can give a perfect rating but this is damn near close. \n            meat was cooked perfectly (medium rare). added an egg which was also cooked prefect. \n            bacon wasn’t crispy but that could be due to the chili. japenqos were sweet than spicy.\n             overall i’m very impressed. only criticism is that when i cut it.\n             the second half didn’t have as much meat. could of been a poor knife job on my part", "n/a", "", "Ground Burger (Lisbon)", "Chili Con Carne", 32.96m, 5m },
                    { 8, new DateTimeOffset(new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "having a hard time rating this. since the chili burger was amazing. this was extremely disappointing.\n             meat was cooked well done. and since it was 70% of the burger it didn’t really help the situation.\n              egg was also over cooked. i went during lunch time so maybe the crowd reduced the quality.\n            also come to the conclusion i don’t like doubles unless they’re smash patty’s.\n             just too much meat to bun for it to be enjoyable otherwise.\n             also 24 euros is a bit of a buzz kill", "n/a", "", "Ground Burger (Time Out Market: Lisbon)", "Double Cheese", 26m, 4m },
                    { 9, new DateTimeOffset(new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "I added bacon. first bite i had a very fresh taste in my mouth.\n             normally don’t do lettuce but it was nice on this burger.\n              hot is definitely not proper heat. mild at best.\n               very solid. meat was cooked medium/medium rare without requesting it.\n             got sweet potato chips. they’re what you’d expect. price 15 euros", "n/a", "", "To.b (Lisbon)", "Hot", 16.5m, 4.5m },
                    { 10, new DateTimeOffset(new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "I knew it wouldn’t be good, still managed even failed to meet my low expectations.\n             meat was dry and chewy. i didn’t even bother to eat the bun. it was an egg bun i think. very dense.\n             funny enough the ketchup made it more editable. american cheese, ketchup, raw white onions", "n/a", "", "Nathan’s (Miami Airport)", "Double Cheese", 0m, 1m },
                    { 11, new DateTimeOffset(new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "First impression: Saucy not in a good best way. \n            The sauce caused the bun to become soggy and it didn't hold up well when biting. \n            Next time get the sauce and manasise on the side. Meat was well cooked,\n            Ingredients: Dry Aged Beef Patties, Cold Smoked American Cheese, Steak Sauce 2.0, Marrownaise, Beef Fat Onions", "n/a", "", "Burgers and Beyond (Shoreditch London)", "The Bougie Burher", 0m, 5m },
                    { 12, new DateTimeOffset(new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "crispy with an explosion of sayory favor. Only thing is I wish it was bigger.\n             Luckily i ordered another one", "n/a", "", "Honest Burger (London)", "Smashed By Honest", 0m, 5m },
                    { 13, new DateTimeOffset(new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "First bite: tasted fresh. On the smaller side of things", "n/a", "", "Honest Burger (London)", "Chili Burger", 0m, 5m },
                    { 14, new DateTimeOffset(new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "First bite: exactly what you'd expect from a smashed burger. \n            I always added bacon, japs, mushrooms and oions. Tasted very fresh. I was satisfied by the end of it.\n             only small issue is it wasn't that hot. it was midnight so i assume that had a little to do with it.", "n/a", "", "Five guys (London)", "Double Cheese", 0m, 4m },
                    { 15, new DateTimeOffset(new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "One of my favorite chain restuarant burger. Brings back memories of having them with my mom in florida.\n            Very good burger. Right amount of spice. Meat was cooked prefect for medium rare.", "n/a", "", "Bj's (Rancho Cucamonga)", "Crispy Jalapeno Burger", 0m, 5m },
                    { 16, new DateTimeOffset(new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "meat was cooked perfectly for medium rare. seasoned well. maybe a bit too much lettuce but it was fresh and added a nice crispy crunch. \n            bun covered the burger perfectly. i was able to eat it without it falling apart. bacon was cooked well. had a little crunch to it. \n            ingredients: ground rib eye patty*, mozzarella cheese, bacon, lettuce\n            included potato wedges. Address: Blvd. Paseo de la Marina S/N, Centro, 23450 Cabo San Lucas, B.C.S., Mexico", "n/a", "https://www.instagram.com/outpostcabo?igsh=cjc3eDhkNHl2N29h", "Outpost (Cabo San Lucas)", "Op Burger", 17.5m, 5m }
                });

            migrationBuilder.InsertData(
                table: "IngredientReview",
                columns: new[] { "IngredientsId", "ReviewId" },
                values: new object[,]
                {
                    { 1, 13 },
                    { 1, 16 },
                    { 2, 3 },
                    { 3, 10 },
                    { 3, 12 },
                    { 3, 14 },
                    { 3, 15 },
                    { 4, 1 },
                    { 5, 3 },
                    { 5, 12 },
                    { 6, 1 },
                    { 6, 13 },
                    { 6, 14 },
                    { 6, 16 },
                    { 7, 10 },
                    { 8, 12 },
                    { 9, 11 },
                    { 9, 15 },
                    { 10, 5 },
                    { 10, 10 },
                    { 10, 11 },
                    { 10, 12 },
                    { 10, 13 },
                    { 14, 1 },
                    { 14, 2 },
                    { 14, 13 },
                    { 16, 3 },
                    { 16, 5 },
                    { 16, 10 },
                    { 16, 11 },
                    { 16, 12 },
                    { 16, 14 },
                    { 17, 16 },
                    { 19, 15 },
                    { 20, 5 },
                    { 21, 3 },
                    { 26, 12 },
                    { 27, 13 },
                    { 41, 5 },
                    { 41, 13 },
                    { 41, 14 },
                    { 43, 14 },
                    { 44, 3 },
                    { 44, 11 },
                    { 46, 5 },
                    { 48, 11 },
                    { 49, 13 },
                    { 50, 5 },
                    { 51, 15 },
                    { 52, 15 },
                    { 53, 16 }
                });

            migrationBuilder.InsertData(
                table: "Picture",
                columns: new[] { "Id", "ReviewId", "Url" },
                values: new object[] { 1, 3, "https://pub-06851190cddc4684902b556426d2e9a1.r2.dev/IMG_4685.jpg" });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientReview_ReviewId",
                table: "IngredientReview",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Picture_ReviewId",
                table: "Picture",
                column: "ReviewId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientReview");

            migrationBuilder.DropTable(
                name: "Picture");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Review");
        }
    }
}
