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
                    { 46, "star", "Special Sauce" }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Date", "Description", "GeoLocation", "Insta", "Location", "Name", "Price", "Rating" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "I added an egg and bacon. bacon wasn’t crispy. egg wasn’t over easy which is a shame. \n            probably 4 stars worthy at the restaurant. \n            https://www.facebook.com/burgerboss.br", "n/a", "n/a", "Burger Boss", "Burger Boss", 8m, 3.5m },
                    { 2, new DateTimeOffset(new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "bun toasted sesame seed. bacon was cooked perfectly.\n            ordered medium - was more medium well. overall very good burger. probably better as a single.\n            maybe slightly less mayo but it was a very good burger special butter mayo.", "n/a", "n/a", "Burgers and Beyond  (Shoreditch London)", "Butter Burger (double)", 0m, 5m },
                    { 3, new DateTimeOffset(new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "First bite impression: very large and messy. some of the meat fell out when i bit into it.\n            The meat was very crumbly and other took all the flavor. It wasn't falvored very well either. A little dissapointing.\n            It looked incredible as you'll see from the picture.", "n/a", "https://www.instagram.com/spitalfieldse1/", "The Grime Burger (Shoreditch London)", "Double Grime Burger", 0m, 3.5m }
                });

            migrationBuilder.InsertData(
                table: "IngredientReview",
                columns: new[] { "IngredientsId", "ReviewId" },
                values: new object[,]
                {
                    { 2, 3 },
                    { 4, 1 },
                    { 5, 3 },
                    { 6, 1 },
                    { 14, 1 },
                    { 14, 2 },
                    { 16, 3 },
                    { 21, 3 },
                    { 44, 3 }
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
