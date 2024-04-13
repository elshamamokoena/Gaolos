using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gaolos.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SvgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    RestaurantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.RestaurantId);
                    table.ForeignKey(
                        name: "FK_Restaurants_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestaurantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                    table.ForeignKey(
                        name: "FK_Menus_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Menus_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Submenus",
                columns: table => new
                {
                    SubmenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submenus", x => x.SubmenuId);
                    table.ForeignKey(
                        name: "FK_Submenus_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    MenuItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubmenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.MenuItemId);
                    table.ForeignKey(
                        name: "FK_MenuItems_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuItems_Submenus_SubmenuId",
                        column: x => x.SubmenuId,
                        principalTable: "Submenus",
                        principalColumn: "SubmenuId");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedBy", "CreatedDate", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "Name", "ParentCategoryId", "SvgUrl" },
                values: new object[,]
                {
                    { new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/04.jpg", null, null, "Pizza & Pasta", null, "img/food-delivery/icons/pizza.svg" },
                    { new Guid("ae98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/01.jpg", null, null, "Grills & Steak", null, "img/food-delivery/icons/steak.svg" },
                    { new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dda"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/04.jpg", null, null, "Haute Cuisine", null, "img/food-delivery/icons/pizza.svg" },
                    { new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/01.jpg", null, null, "Chicken & Wings", null, "img/food-delivery/icons/chicken.svg" },
                    { new Guid("bf3f3002-7e53-441e-8b76-f6280be284aa"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/04.jpg", null, null, "Noodles", null, "img/food-delivery/icons/pizza.svg" },
                    { new Guid("ce98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/06.jpg", null, null, "Healthy food", null, "img/food-delivery/icons/healthy.svg" },
                    { new Guid("de98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/03.jpg", null, null, "Fish & Seafood", null, "img/food-delivery/icons/fish.svg" },
                    { new Guid("ee98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/05.jpg", null, null, "Coffee & Desserts", null, "img/food-delivery/icons/coffee.svg" },
                    { new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/01.jpg", null, null, "Burgers & Fries", null, "img/food-delivery/icons/burger.svg" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "CategoryId", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "LogoUrl", "Name", "Tags" },
                values: new object[,]
                {
                    { new Guid("1313179f-7837-473a-a4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Doppio Zero", "Italian, Vegan, Vegetarian, Pizza, Pasta, Burgers, Grill, Tapas, Woodfired, Healthy, Salad, Bakery, Breakfast, Calamari, Seafood, Chicken, Wraps, Poke, Mediterranean, Sandwiches, Dessert, Coffee, Health Drinks, Kids, Milkshake, Chips, Fruit" },
                    { new Guid("2313179f-1837-173a-a4d5-a5571b43e6a9"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Mike's Heritage House", "" },
                    { new Guid("2313179f-1837-273a-a4d5-a5571b43e6a9"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Spiceburg Greenside", "" },
                    { new Guid("2313179f-1837-373a-a4d5-a5571b43e6a9"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Miyako Sushi", "" },
                    { new Guid("2313179f-1837-473a-a4d1-a5571b43e6a9"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Chop Stix", "" },
                    { new Guid("2313179f-1837-473a-a4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Simply Asia", "Asian, Thai, Chinese, Japanese, Noodles, Sushi, Soup, Fried, Spicy, Healthy, Low Carb, Light Meals, Salad, Lunch, Dinner, Juice, Chinese, Asian, Sushi, Soup, Fried, Japanese, Noodles, Spicy, Traditional" },
                    { new Guid("2313179f-1837-473a-a4d5-a5571b43e6a7"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Asian Twist", "" },
                    { new Guid("2313179f-1837-473a-a4d5-a5571b43e6a8"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Thunder Gun", "" },
                    { new Guid("2313179f-1837-473a-a4d5-a5571b43e6a9"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Curry Up", "" },
                    { new Guid("2313179f-1837-573a-a4d5-a5571b43e6a9"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Topo Gigio", "" },
                    { new Guid("2313179f-1837-673a-a4d5-a5571b43e6a9"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Satori", "" },
                    { new Guid("2313179f-1837-773a-a4d5-a5571b43e6a9"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Pizza e Vino", "" },
                    { new Guid("2313179f-1837-873a-a4d5-a5571b43e6a9"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Jimmy's", "" },
                    { new Guid("2313179f-1837-973a-a4d5-a5571b43e6a9"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Pasta Worx", "" },
                    { new Guid("2313179f-2837-473a-a4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Andiccio24", "Pizza, Pasta, Salad, Soup, Healthy, Smoothies, Dessert, Milkshake, Homemade, Oven Baked, Italian, Ice Cream, Contemporary, Wheat and Gluten free, Vegan, Mediterranean" },
                    { new Guid("2313179f-3837-473a-a4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Pedro's Chicken", "Chicken, Spicy, Light Meals, Salad, Lunch, Dinner, Juice, Portuguese, African, Spicy, Halaal, Middle Eastern, Mediterranean, Healthy, Low Carb" },
                    { new Guid("2313179f-4837-473a-a4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Pizza Perfect", "Pizza, Pasta, Salad, Dessert, Lunch, Fast Food, Spicy, Mediterranean, Light Meals, Dinner, Chicken Wings, Kids, Vegetarian" },
                    { new Guid("2313179f-5837-473a-a4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Pron", "" },
                    { new Guid("2313179f-6837-473a-a4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "The Fussy Vegan", "" },
                    { new Guid("2313179f-7837-473a-a4d5-a5571b43e6a1"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Tei Avon", "" },
                    { new Guid("2313179f-7837-473a-a4d5-a5571b43e6a2"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "X&O", "" },
                    { new Guid("2313179f-7837-473a-a4d5-a5571b43e6a3"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Hao Ke Lai", "" },
                    { new Guid("2313179f-7837-473a-a4d5-a5571b43e6a4"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Momo Baohaus", "" },
                    { new Guid("2313179f-7837-473a-a4d5-a5571b43e6a5"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "La Padrino", "" },
                    { new Guid("2313179f-7837-473a-a4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Mochachos", "Burgers, Fries, Salad, Dessert, Chicken, Milkshake, Ribs, Ice Cream, Fast Food, Kids, Healthy, Chips, Vegetarian, Grill, Lunch, Dinner, Mexican, Burrito, Prego, Halaal" },
                    { new Guid("2313179f-8837-473a-a4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Pizza Baby", "" },
                    { new Guid("6313179f-7837-473a-a4d5-b5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "KFC", "Chicken, Chicken Wings, Burgers, Wraps, Fast Food, Dessert, American, Spicy, Light Meals, Juice, Halaal, Breakfast," },
                    { new Guid("6313179f-7837-473a-a4d5-c5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Chicken Licken", "Chicken, Burgers, Chicken Wings, Spicy, Light Meals, Salad, Fast Food, Lunch, Dinner, Fries, Fried" },
                    { new Guid("6313179f-7837-473a-a4d5-d5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nandos", "Chicken, Burgers, Chicken Wings, Fast Food, Light Meals, Portuguese, Salad, Spicy, Dessert, South African, Dinner, Chips, Juice, Middle Eastern" },
                    { new Guid("6313179f-7837-473a-a4d5-e5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Roman's Pizza", "Pizza, Pasta, Salad, Dessert, Lunch, Fast Food, Spicy, Mediterranean, American, Dinner" },
                    { new Guid("6313179f-7837-473a-a4d5-f5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Debonair's Pizza", "Pizza, Fast Food, Italian, Chicken Wings, Dessert, Vegetarian, Halaal" },
                    { new Guid("6313179f-7837-473a-b4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "McDonald's", "Burgers, Fries, Fast Food, American, Breakfast, Dessert, Salad, Chicken, Juice, Halaal, Lunch, Dinner, Cafe, Coffee, Milkshake, Wraps" },
                    { new Guid("6313179f-7837-473a-c4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Steers", "Burgers, Fries, Salad, Dessert, Chicken, Milkshake, Ribs, Ice Cream, Fast Food, Kids, Healthy, Chips, Vegetarian" },
                    { new Guid("6313179f-7837-473a-d4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Fishaways", "Fish, Seafood, Fast Food, Halaal, Chips, Lunch, Dinner, Salad, Dessert, Juice, Healthy, Light Meals, Seafood, Grilled, Sushi, Mediterranean, Low Carb" },
                    { new Guid("6313179f-7837-473a-e4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Kung Fu Chicken", "Chicken, Fast Food, Spicy, Light Meals, Salad, Lunch, Dinner, Juice, Chinese, Asian, Sushi, Soup, Fried, Japanese, Noodles, Spicy" },
                    { new Guid("6313179f-7837-473a-f4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Galito's", "Chicken, Spicy, Light Meals, Salad, Lunch, Dinner, Juice, Portuguese, African, Spicy, Halaal, Middle Eastern, Mediterranean, Healthy, Low Carb" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "CategoryId", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "Name", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Buckets", new Guid("6313179f-7837-473a-a4d5-b5571b43e6a6") },
                    { new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Box Meals", new Guid("6313179f-7837-473a-a4d5-b5571b43e6a6") },
                    { new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Streetwise", new Guid("6313179f-7837-473a-a4d5-b5571b43e6a6") },
                    { new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Drnks & Treats", new Guid("6313179f-7837-473a-a4d5-b5571b43e6a6") },
                    { new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Sharing Meals", new Guid("6313179f-7837-473a-a4d5-b5571b43e6a6") },
                    { new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Wings & Snacks", new Guid("6313179f-7837-473a-a4d5-b5571b43e6a6") },
                    { new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Burgers & Wraps", new Guid("6313179f-7837-473a-a4d5-b5571b43e6a6") },
                    { new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Add-Ons", new Guid("6313179f-7837-473a-a4d5-b5571b43e6a6") }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemId", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "MenuId", "Name", "Price", "SubmenuId" },
                values: new object[,]
                {
                    { new Guid("03054d70-b145-4f42-b325-757c7aa19a6e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy KFC`s new Jalapeno loaded fries with brand new Hot * spicy sauce", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Jalapeno Loaded Fries", 32.90m, null },
                    { new Guid("0d020310-9a67-4cb7-84a8-b08a49e09e6c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 Piece Chicken", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "1 Piece Chicken", 26.90m, null },
                    { new Guid("100a22ca-0cb4-4150-8902-b58ddba03f4b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "10 Hot Zinger Wings", 89.90m, null },
                    { new Guid("166f48d6-af40-4f5e-be21-1b4292e5324c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken dunked in KFC’s famous honey, ginger and soy sauce!", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Dunked Pops", 36.90m, null },
                    { new Guid("1bac6015-9f05-429a-9a1b-4641086fdfd8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Try the new standard! The New Crispy Zinger burger, Our trademark real chicken fillet; A fresh Brioche bun, New Hot & Spicy sauce and cheese on a fresh bed of lettuce & succulent tomatoes", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Zinger Burger", 60.90m, null },
                    { new Guid("1c44bfde-681c-461c-bcac-16dc89b80500"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An icy sippable treat with Berry bitz, and creamy soft-serve.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Verry Berry Krusher", 42.90m, null },
                    { new Guid("2013179f-1037-173a-a4d5-a6571b43e6a9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "21 Pieces of juicy chicken seasoned with the 11 secret herbs and spices of Original Recipe® chicken, marinated and cooked to perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1"), "21 Piece Bucket", 365.90m, null },
                    { new Guid("26f0af2d-d383-4156-84db-bf3a55e67da5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 Pieces of Original Recipe chicken cooked to golden perfection and a large portion of chips or coleslaw.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Five", 121.90m, null },
                    { new Guid("2a54fb5c-a4a3-47f4-9eb1-e1a250b6e7ce"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crunch Burger, 1 Piece of Original Recipe Chicken, 2 Zinger Wings, Small Chips & Buddy Drink", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "All Star Box Meal Buddy", 94.90m, null },
                    { new Guid("2a752252-8d99-4f65-9ee0-07def28f6e1a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken that are tender on the inside and crunchy on the outside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Small Pops", 29.90m, null },
                    { new Guid("2d930bd8-9519-4bf9-bca4-742c36893884"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A spicy, crunchy mini fillet with a slice of cheese and lettuce, covered in tangy dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Crunch Burger", 36.90m, null },
                    { new Guid("3012a3bc-83c1-487e-96e2-f8bdbedde6ec"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10pc Chicken, 2 snack burgers, 4 Zinger Wings, 2 Reg Coleslaw, 2 Reg chips", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "10 Piece Family Treat", 316.90m, null },
                    { new Guid("31ddb551-3b27-442b-b11f-6a8c89aa9208"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new Burger standard…Boxed! The new Colonel burger, 1 piece of original recipe chicken, regular mash & gravy, chips & a buddy no sugar drink.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Fully Loaded Box Meal", 115.90m, null },
                    { new Guid("3b709331-8946-43cd-8361-275219cb4edd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken that are tender on the inside and crunchy on the outside. Served with a generous sprinkle of fruit chutney flavour.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Sprinkle Pops", 54.90m, null },
                    { new Guid("3be3dc73-61a3-4360-a988-bde01d6baa22"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A delicious chicken patty served with shredded lettuce & Colonel dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Snack Burger", 29.90m, null },
                    { new Guid("3dc1e482-bfbf-4f58-ae3c-24b01963c491"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pieces of Original Recipe Chicken with a portion of pap and gravy", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Three with Pap", 72.90m, null },
                    { new Guid("407e8594-1596-4794-9911-e950d38d5f79"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprite Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Sprite Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("43df9da3-9a59-43c4-851c-22068e66ada2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8pc Chicken, 2 snack burgers, 4 Zinger Wings, 2 Reg Coleslaw, 2 Reg chips", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "8 Piece Family Treat", 274.90m, null },
                    { new Guid("48e5c32f-fc92-4a79-b55d-c25d63704aa2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A delicious chicken patty served with shredded lettuce & Colonel dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Snack Burger", 29.90m, null },
                    { new Guid("535366b8-9497-47e5-acf6-609ccbf9ab2d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extra Hot & Spicy Zinger sauce on the side", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Sauce - Hot & Spicy", 0m, null },
                    { new Guid("5549b0e1-fa0f-4b05-aa47-acdf79e5d114"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs and spices of Original Recipe® chicken, marinated and cooked to perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1"), "9 Piece Bucket", 182.90m, null },
                    { new Guid("56079f42-47f1-4ab1-9c14-f3c3ff401e1a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "24 Zinger Wings Bucket", 194.90m, null },
                    { new Guid("57b4e402-456c-48fd-a721-1965bc48ec38"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get yourself a Streetwise 5, with 2 Buddy No Sugar", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Streetwise 5 Buddy", 143.90m, null },
                    { new Guid("590d7fdf-993d-46e1-ba74-fd245c30806c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get yourself a Streetwise 1, with a Buddy no sugar free drink", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Streetwise 1 Buddy", 52.90m, null },
                    { new Guid("63419633-de0d-477b-a75d-fc1e00d98b0e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around a delicious fillet original recipe - a slice of cheese, hash brown, crisp lettuce, fresh tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Colonel Boxmaster", 76.90m, null },
                    { new Guid("6357def7-47e1-4787-8827-f02385176512"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken, tender on the inside and crunchy on the outside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Large Pops", 54.90m, null },
                    { new Guid("6b31164f-60cf-4385-bced-00cbefd9077d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of creamy mash and our delicious gravy.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Large Mash & Gravy", 27.90m, null },
                    { new Guid("6c5f837e-bdb2-41f5-8938-d171c51c73b3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Pieces of Original Recipe Chicken and Small Chips or Coleslaw.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Two with Chips", 49.90m, null },
                    { new Guid("70358445-94d1-4b0c-8f10-d276cc4c003e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy 6 pieces of delicious original recipe chicken, 1 large chips, 1 regular coleslaw plus 2 regular mash and gravies.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "All In One Feast", 194.90m, null },
                    { new Guid("708cdddf-e83a-4305-b0c4-5298f8749bff"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around a delicious fillet zinger recipe - a slice of cheese, hash brown, crisp lettuce, fresh tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Zinger Boxmaster", 76.90m, null },
                    { new Guid("71b2b1a4-2c0c-408d-9a7e-e80cd57aa25b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milk shake milk shake shake shake", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Strawberry Milkshake", 31.90m, null },
                    { new Guid("75e54f4d-def9-4658-b54d-54cf1dbed47f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new standard in burgers! 2 Spicy, crunchy mini fillets with 2 cheese slices, lettuce & tomato covered in tangy dressing on a burger bun", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Double Crunch Burger", 68.90m, null },
                    { new Guid("781578b8-eb4f-4285-bbcd-96ffd6d06a38"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pieces of original recipe chicken, a portion of small chips.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Three with Chips", 72.90m, null },
                    { new Guid("797d386b-d3fc-4af5-a9d4-6b492904eb5a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Cappy Juice 1.5 Litre", 44.90m, null },
                    { new Guid("7a0325ad-782d-46c1-819b-fdc1fa79aa8b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy a delicious Crunch Burger an orginal receipe chicken piece with small chips and a buddy no sugar drink", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Crunch Burger Box Buddy", 71.90m, null },
                    { new Guid("7e65f38f-0b30-4b76-8c81-9c33a2eb0c8c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Chips", 26.90m, null },
                    { new Guid("83078139-a02b-44ba-bcdd-bff9c587fc39"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wrapsta, 1 Piece of Original Recipe Chicken, Small Chips & Buddy Drink", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Wrapsta Box Meal", 84.90m, null },
                    { new Guid("876ef9b5-43f2-477a-a55f-30678be18424"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 KFC famous Zinger Wings dunked in a delicious honey, ginger and soy sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "10 Dunked Wings", 104.90m, null },
                    { new Guid("89ccc7f8-eeb5-4e30-9fd6-4a0c46b698a4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Nuggets, 1 Crunch Burger, 1 Small Chips and a Buddy Drink", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Nugget Box Buddy Meal", 79.90m, null },
                    { new Guid("8c4153eb-f99f-4a08-9115-88bfd34971b6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Try the new standard! The New Colonel burger, Our trademark real chicken fillet; A fresh Brioche bun, Creamy Colonel sauce and cheese on a fresh bed of lettuce & succulent tomatoes", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Colonel Burger", 60.90m, null },
                    { new Guid("98765138-4366-4299-8915-cc3c23a2b2a7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Large Chips", 0m, null },
                    { new Guid("993a78ce-c2ca-4a9c-a6f3-5d0cfe94a93c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new Burger standard…Boxed! The Crispy Zinger burger, 1 piece of original recipe chicken, regular mash & gravy, chips & Buddy no sugar.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Zinger Fully Loaded Buddy Box Meal", 115.90m, null },
                    { new Guid("99ae4772-f83a-4d42-8079-8c739b9baa29"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces of crispy, delicious golden brown Nuggets, paired with 1 delicious Colonel dipping sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "6Pc Nuggets", 36.90m, null },
                    { new Guid("9a8271f2-46f9-426c-9e1e-90a94802a51b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of freshly prepared cabbage, onions and carrots in a delicious dressing", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Coleslaw", 24.90m, null },
                    { new Guid("a1c1ff7b-998e-4400-84ac-762854c1fbd9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fanta Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Fanta Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("a3e2814d-8f68-4d03-abf3-57ee4b4c5343"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 pieces of crispy, delicious golden brown Nuggets, paired with 1 delicious Colonel dipping sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "9Pc Nuggets", 42.90m, null },
                    { new Guid("a47d9271-fb58-4401-8096-e97ef066a5db"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The game changer is here, and with a delicious spicy crunch fillet, tomato, lettuce and cheese with tangy dressing all wrapped up in a mini tortilla and grilled to perfection, meal time will never be the same again.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Wrapsta", 42.90m, null },
                    { new Guid("a5bc5302-069a-4e4a-9569-4238b41f3841"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca-Cola Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coca-Cola Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("ab9a94a7-2784-40d8-9b11-86bb77a91bc7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke 1.5 Litre Bottle", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke 1.5 Litre Bottle", 32.90m, null },
                    { new Guid("ac3da0de-16bd-472e-b69d-1b10d3367b58"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Pieces of original recipe chicken cooked to golden perfection and a regular portion of pap & small gravy.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Two with Pap", 49.90m, null },
                    { new Guid("b11ddd59-228b-4b15-8658-968bffb88b14"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around 2 deliciously crispy chicken strips, shredded crisp lettuce, sliced tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Classic Twister", 66.90m, null },
                    { new Guid("b325348d-b514-40ac-8b67-40705ac7b12e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Small Chips", 16.90m, null },
                    { new Guid("b777d480-4335-4ee4-8c98-b48636dc83f6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "24 Zinger Wings Bucket", 194.90m, null },
                    { new Guid("bf4014a2-8d68-4bdc-a336-c242d8db62cb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chocolate Milkshake", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Chocolate Milkshake", 31.90m, null },
                    { new Guid("bfa530e0-f382-4f72-a99c-b7c4f8335efb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around 2 deliciously crispy new and improved chicken strips, shredded crisp lettuce, sliced tomato, topped with Colonel dressing and sweet chilli sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Sweet Chilli Twister", 66.90m, null },
                    { new Guid("c801865e-be40-441d-9fa4-37b30e7ab303"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 KFC famous Zinger Wings dunked in a delicious honey, ginger and soy sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "4 Dunked Wings", 54.90m, null },
                    { new Guid("ca6314f9-d1ef-4140-9e5f-c67bb12d9f6a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oven baked, fresh mini loaf", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Mini Loaf", 14.90m, null },
                    { new Guid("ca66e71b-a268-4ba9-b94b-6a704dde02f9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy 4 pieces of original recipe chicken, 2 small chips, 1 small pops & 2 buddy no sugar drinks.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "2 Can Dine Buddy", 164.90m, null },
                    { new Guid("cbe0e75c-a248-44c4-be83-03ef77198f9e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke No Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke No Sugar Buddy 440ml", 22.90m, null },
                    { new Guid("ccf0404a-aec5-4afd-912f-407befc5b0e1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "4 Zinger Wings", 48.90m, null },
                    { new Guid("cf156523-c4ee-4f5b-a2ba-f8933cee7566"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy a piece of original recipe chicken, 2 zinger wings and a small scrumptious chips.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Bucket For One", 46.90m, null },
                    { new Guid("ee4883e6-161d-42a1-9bea-ded392c24a7d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An icy sippable treat with Oreo bitz, and creamy soft-serve.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Oreo Krusher", 42.90m, null },
                    { new Guid("ef3db1e5-ef1d-4bcf-b662-bab31656c965"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of creamy mash and our delicious gravy.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Mash & Gravy", 19.90m, null },
                    { new Guid("f1f9a016-d9ab-4e69-b3e0-9079dc5ea35e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs & spices.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1"), "15 Piece Bucket", 279.90m, null },
                    { new Guid("f3ccfe61-425b-4770-afb0-98c0ea02b379"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bonaqua Still Spring Water 500ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Bonaqua Still Spring Water 500ml", 19.90m, null },
                    { new Guid("fa0ff96a-b13f-410e-b46a-b05b62df17e3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke No Sugar 1.5 Litre", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke No Sugar 1.5 Litre", 29.90m, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_MenuId",
                table: "MenuItems",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_SubmenuId",
                table: "MenuItems",
                column: "SubmenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_CategoryId",
                table: "Menus",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_RestaurantId",
                table: "Menus",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_CategoryId",
                table: "Restaurants",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Submenus_MenuId",
                table: "Submenus",
                column: "MenuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Submenus");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
