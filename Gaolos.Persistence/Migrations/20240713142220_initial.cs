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
                name: "Addresses",
                columns: table => new
                {
                    DeliveryAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Suburb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isPrimary = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.DeliveryAddressId);
                });

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    BasketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CouponId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.BasketId);
                });

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
                name: "Coupons",
                columns: table => new
                {
                    CouponId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AlreadyUsed = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.CouponId);
                });

            migrationBuilder.CreateTable(
                name: "CreditCards",
                columns: table => new
                {
                    CreditCardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expiry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CVV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardHolderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isPrimary = table.Column<bool>(type: "bit", nullable: false),
                    CardType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCards", x => x.CreditCardId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderPlaced = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderPaid = table.Column<bool>(type: "bit", nullable: false),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Delivery = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardExpiration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CvvCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
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

            migrationBuilder.CreateTable(
                name: "BasketLines",
                columns: table => new
                {
                    BasketLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BasketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketLines", x => x.BasketLineId);
                    table.ForeignKey(
                        name: "FK_BasketLines_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "BasketId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketLines_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItems",
                        principalColumn: "MenuItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderLines",
                columns: table => new
                {
                    OrderLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLines", x => x.OrderLineId);
                    table.ForeignKey(
                        name: "FK_OrderLines_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItems",
                        principalColumn: "MenuItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderLines_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedBy", "CreatedDate", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "Name", "ParentCategoryId", "SvgUrl" },
                values: new object[,]
                {
                    { new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/04.jpg", null, null, "Pizza & Pasta", null, "img/food-delivery/icons/pizza.svg" },
                    { new Guid("ae98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/08.jpeg", null, null, "Grills & Steak", null, "img/food-delivery/icons/steak.svg" },
                    { new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dda"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/10.jpg", null, null, "Haute Cuisine", null, "img/food-delivery/icons/cuisine.svg" },
                    { new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/07.jpg", null, null, "Chicken & Wings", null, "img/food-delivery/icons/chicken.svg" },
                    { new Guid("bf3f3002-7e53-441e-8b76-f6280be284aa"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/02.jpg", null, null, "Noodles", null, "img/food-delivery/icons/noodles.svg" },
                    { new Guid("ce98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/06.jpg", null, null, "Healthy food", null, "img/food-delivery/icons/healthy.svg" },
                    { new Guid("de98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/09.jpg", null, null, "Fish & Seafood", null, "img/food-delivery/icons/fish.svg" },
                    { new Guid("ee98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/05.jpg", null, null, "Coffee & Desserts", null, "img/food-delivery/icons/coffee.svg" },
                    { new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/01.jpg", null, null, "Burgers & Fries", null, "img/food-delivery/icons/burger.svg" }
                });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "CouponId", "AlreadyUsed", "Code", "CreatedBy", "CreatedDate", "Discount", "LastModifiedBy", "LastModifiedDate" },
                values: new object[,]
                {
                    { new Guid("316f2a9a-c49b-466a-b9b1-d21f856a1ee4"), false, "AlmostFree", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, null, null },
                    { new Guid("b1ff0e3a-c946-4ba9-a3d0-03c12528051f"), false, "Awesome", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, null, null },
                    { new Guid("f5f05bd4-e2fc-45fd-835e-686c82c79765"), false, "BeNice", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, null, null }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "CategoryId", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "LogoUrl", "Name", "Tags" },
                values: new object[,]
                {
                    { new Guid("1313179f-7837-473a-a4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "img/food-delivery/restaurants/18.jpg", null, null, "img/food-delivery/restaurants/logos/22.png", "Doppio Zero", "Italian, Vegan, Vegetarian, Pizza, Pasta, Burgers, Grill, Tapas, Woodfired, Healthy, Salad, Bakery, Breakfast, Calamari, Seafood, Chicken, Wraps, Poke, Mediterranean, Sandwiches, Dessert, Coffee, Health Drinks, Kids, Milkshake, Chips, Fruit, Haute" },
                    { new Guid("2313179f-1837-473a-a4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "img/food-delivery/restaurants/20.jpeg", null, null, "img/food-delivery/restaurants/logos/24.png", "Simply Asia", "Asian, Thai, Chinese, Japanese, Noodles, Sushi, Soup, Fried, Spicy, Healthy, Low Carb, Light Meals, Salad, Lunch, Dinner, Juice, Chinese, Asian, Sushi, Soup, Fried, Japanese, Noodles, Spicy, Traditional" },
                    { new Guid("2313179f-2837-473a-a4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "img/food-delivery/restaurants/21.jpeg", null, null, "img/food-delivery/restaurants/logos/25.png", "Andiccio24", "Pizza, Pasta, Salad, Soup, Healthy, Smoothies, Dessert, Milkshake, Homemade, Oven Baked, Italian, Ice Cream, Contemporary, Wheat and Gluten free, Vegan, Mediterranean" },
                    { new Guid("2313179f-3837-473a-a4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "img/food-delivery/restaurants/22.jpeg", null, null, "img/food-delivery/restaurants/logos/26.png", "Pedro's Chicken", "Chicken, Spicy, Light Meals, Salad, Lunch, Dinner, Juice, Portuguese, African, Spicy, Halaal, Middle Eastern, Mediterranean, Healthy, Low Carb" },
                    { new Guid("2313179f-4837-473a-a4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "img/food-delivery/restaurants/23.jpg", null, null, "img/food-delivery/restaurants/logos/27.png", "Pizza Perfect", "Pizza, Pasta, Salad, Dessert, Lunch, Fast Food, Spicy, Mediterranean, Light Meals, Dinner, Chicken Wings, Kids, Vegetarian" },
                    { new Guid("2313179f-5837-473a-a4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "img/food-delivery/restaurants/24.jpg", null, null, "img/food-delivery/restaurants/logos/28.png", "Pron", "Chinese, Asian, Fried, Healthy, Tapas, Noodles, Spicy" },
                    { new Guid("2313179f-6837-473a-a4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "img/food-delivery/restaurants/25.jpeg", null, null, "img/food-delivery/restaurants/logos/29.png", "The Fussy Vegan", "Breakfast, Burgers, Burrito, Dessert, Healthy, Sandwiches, Plant-Based, Health Drinks, Health, Vegan" },
                    { new Guid("2313179f-7837-473a-a4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "img/food-delivery/restaurants/19.jpeg", null, null, "img/food-delivery/restaurants/logos/23.png", "Mochachos", "Burgers, Fries, Salad, Dessert, Chicken, Milkshake, Ribs, Ice Cream, Fast Food, Kids, Healthy, Chips, Vegetarian, Grill, Lunch, Dinner, Mexican, Burrito, Prego, Halaal" },
                    { new Guid("2313179f-8837-473a-a4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "img/food-delivery/restaurants/26.jpg", null, null, "img/food-delivery/restaurants/logos/30.png", "Pizza Baby", "Pasta, Pizza, Salad, Italian, Fast Food, Dessert, Healthy, Chicken, Non-Alcoholic, Vegetarian" },
                    { new Guid("6313179f-7837-473a-a4d5-b5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "img/food-delivery/restaurants/02.jpg", null, null, "img/food-delivery/restaurants/logos/04.png", "KFC", "Chicken, Chicken Wings, Burgers, Wraps, Fast Food, Dessert, American, Spicy, Light Meals, Juice, Halaal, Breakfast," },
                    { new Guid("6313179f-7837-473a-a4d5-c5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "img/food-delivery/restaurants/10.jpg", null, null, "img/food-delivery/restaurants/logos/14.png", "Chicken Licken", "Chicken, Burgers, Chicken Wings, Spicy, Light Meals, Salad, Fast Food, Lunch, Dinner, Fries, Fried" },
                    { new Guid("6313179f-7837-473a-a4d5-d5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "img/food-delivery/restaurants/11.jpeg", null, null, "img/food-delivery/restaurants/logos/15.png", "Nandos", "Chicken, Burgers, Chicken Wings, Fast Food, Light Meals, Portuguese, Salad, Spicy, Dessert, South African, Dinner, Chips, Juice, Middle Eastern" },
                    { new Guid("6313179f-7837-473a-a4d5-e5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "img/food-delivery/restaurants/12.jpg", null, null, "img/food-delivery/restaurants/logos/16.png", "Roman's Pizza", "Pizza, Pasta, Salad, Dessert, Lunch, Fast Food, Spicy, Mediterranean, American, Dinner" },
                    { new Guid("6313179f-7837-473a-a4d5-f5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "img/food-delivery/restaurants/13.jpg", null, null, "img/food-delivery/restaurants/logos/17.png", "Debonair's Pizza", "Pizza, Fast Food, Italian, Chicken Wings, Dessert, Vegetarian, Halaal" },
                    { new Guid("6313179f-7837-473a-b4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "img/food-delivery/restaurants/01.jpg", null, null, "img/food-delivery/restaurants/logos/01.png", "McDonald's", "Burgers, Fries, Fast Food, American, Breakfast, Dessert, Salad, Chicken, Juice, Halaal, Lunch, Dinner, Cafe, Coffee, Milkshake, Wraps" },
                    { new Guid("6313179f-7837-473a-c4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "img/food-delivery/restaurants/14.jpg", null, null, "img/food-delivery/restaurants/logos/18.png", "Steers", "Burgers, Fries, Salad, Dessert, Chicken, Milkshake, Ribs, Ice Cream, Fast Food, Kids, Healthy, Chips, Vegetarian" },
                    { new Guid("6313179f-7837-473a-d4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "img/food-delivery/restaurants/15.jpg", null, null, "img/food-delivery/restaurants/logos/19.png", "Fishaways", "Fish, Seafood, Fast Food, Halaal, Chips, Lunch, Dinner, Salad, Dessert, Juice, Healthy, Light Meals, Seafood, Grilled, Sushi, Mediterranean, Low Carb" },
                    { new Guid("6313179f-7837-473a-e4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "img/food-delivery/restaurants/16.jpeg", null, null, "img/food-delivery/restaurants/logos/20.png", "Kung Fu Chicken", "Chicken, Fast Food, Spicy, Light Meals, Salad, Lunch, Dinner, Juice, Chinese, Asian, Sushi, Soup, Fried, Japanese, Noodles, Spicy" },
                    { new Guid("6313179f-7837-473a-f4d5-a5571b43e6a6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "img/food-delivery/restaurants/17.jpeg", null, null, "img/food-delivery/restaurants/logos/21.png", "Galito's", "Chicken, Spicy, Light Meals, Salad, Lunch, Dinner, Juice, Portuguese, African, Spicy, Halaal, Middle Eastern, Mediterranean, Healthy, Low Carb" }
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
                    { new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Add-Ons", new Guid("6313179f-7837-473a-a4d5-b5571b43e6a6") },
                    { new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Platters", new Guid("6313179f-7837-473a-a4d5-d5571b43e6a6") },
                    { new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "When you need a little snack", null, null, null, "Original Slyders", new Guid("6313179f-7837-473a-a4d5-c5571b43e6a6") },
                    { new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "When you want more for everyone", null, null, null, "Meals", new Guid("6313179f-7837-473a-a4d5-c5571b43e6a6") },
                    { new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "When the craving's got you", null, null, null, " Just Hotwings", new Guid("6313179f-7837-473a-a4d5-c5571b43e6a6") },
                    { new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "When you need some soul food", null, null, null, "Soulicious", new Guid("6313179f-7837-473a-a4d5-c5571b43e6a6") },
                    { new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "When a sister needs some soul", null, null, null, "Soul Sister Specials", new Guid("6313179f-7837-473a-a4d5-c5571b43e6a6") },
                    { new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "When you just can't resist", null, null, null, "Just Chicken", new Guid("6313179f-7837-473a-a4d5-c5571b43e6a6") },
                    { new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "When it's almost mahala", null, null, null, "Easy Bucks", new Guid("6313179f-7837-473a-a4d5-c5571b43e6a6") },
                    { new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "When you're in the mood for a burger", null, null, null, "Just Chick'n Burgers", new Guid("6313179f-7837-473a-a4d5-c5571b43e6a6") },
                    { new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "When you're hungry at heart", null, null, null, "Top Deluxe", new Guid("6313179f-7837-473a-a4d5-c5571b43e6a6") },
                    { new Guid("2014179f-1037-173a-a4d5-a6571b43e6a9"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "When you need nuggets to feed your soul", null, null, null, "Soul Bites", new Guid("6313179f-7837-473a-a4d5-c5571b43e6a6") }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemId", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "MenuId", "Name", "Price", "SubmenuId" },
                values: new object[,]
                {
                    { new Guid("000caff1-b740-43ca-8c9f-121e88c3bc7f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Pieces of original recipe chicken cooked to golden perfection and a regular portion of pap & small gravy.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Two with Pap", 49.90m, null },
                    { new Guid("08229f99-2e65-42f0-ac67-4db9d90415eb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new standard in burgers! 2 Spicy, crunchy mini fillets with 2 cheese slices, lettuce & tomato covered in tangy dressing on a burger bun", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Double Crunch Burger", 68.90m, null },
                    { new Guid("0a71b070-9295-4901-83f8-ed1bc2cc6356"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 SoulBites®", "https://chickenlicken.co.za/assets/uploads/products/menu/123_soulbites-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a9"), "Soul Bites", 38.00m, null },
                    { new Guid("0a988e10-dd46-4400-8965-01e2ea043902"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chocolate Milkshake", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Chocolate Milkshake", 31.90m, null },
                    { new Guid("0b855bc3-3e56-4fbc-a0ea-4bfc3b8bf18e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + a portion of Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/50_soulsister-circle2ce-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Deluxe", 62.00m, null },
                    { new Guid("117eb428-d8cc-428d-b340-42e5e868c2a7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 Hotwings® + a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/14_hotwings-soul-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Soul", 50.00m, null },
                    { new Guid("132cc373-3414-4793-8216-7bd1b94dbb05"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of freshly prepared cabbage, onions and carrots in a delicious dressing", "https://images.ctfassets.net/0p42pznmbeec/1LvCxHqjAFXs2XFgAbQpnG/44719dee762ff4f7106e33d8c4f300f9/ABC2225-reg_coleslaw.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Coleslaw", 24.90m, null },
                    { new Guid("144afa99-78d2-4386-93a2-e1d825838583"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken, tender on the inside and crunchy on the outside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Large Pops", 54.90m, null },
                    { new Guid("145ccc45-2196-4817-9928-ab97bf40d9d0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 SoulBites® + a portion of Soul Fries™ + a sachet of either \r\n\r\nUncle Jessups Ketchup®, SoulFire® sauce or Soulfirennaise™  sauce", "https://chickenlicken.co.za/assets/uploads/products/menu/125_soulbites-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Soul Bites Snack", 30.00m, null },
                    { new Guid("16d3384e-fc27-4744-bccd-fcef44f34c62"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken that are tender on the inside and crunchy on the outside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Small Pops", 29.90m, null },
                    { new Guid("176a24c9-8706-4f9e-9ec9-e8573821364c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Square chick’n burger on a toasted square bun with SOULFIRENAISE™ sauce and a pickle", "https://chickenlicken.co.za/assets/uploads/products/menu/39_1-slyder-chilli.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Slyder Chilli", 14.00m, null },
                    { new Guid("1792aabe-a64f-42a1-b0e2-df42dbfde379"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/55_just-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 2", 39.00m, null },
                    { new Guid("185526c5-f8f7-45a5-b1cf-4a6a7a2a1b42"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pieces of Original Recipe Chicken with a portion of pap and gravy", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Three with Pap", 72.90m, null },
                    { new Guid("1aefe4f0-9b80-4f7a-8918-fbe1f83b5c52"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Hotwings", "https://chickenlicken.co.za/assets/uploads/products/menu/3_hotwings-circle12ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "12 Hotwings", 84.00m, null },
                    { new Guid("1eb20dcf-91b9-4e47-b2a0-f2df0a6c204f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half Platter", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/f93c9cbe-5f94-4bb4-a937-811c28bd88df", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Big on veg platter", 640.00m, null },
                    { new Guid("2013179f-1037-173a-a4d5-a6571b43e6a9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "21 Pieces of juicy chicken seasoned with the 11 secret herbs and spices of Original Recipe® chicken, marinated and cooked to perfection.", "https://images.ctfassets.net/0p42pznmbeec/6eaDUybzXwyTZS51VNINU3/ed40587af0f56e4f8b753f4352a02f09/66752_-_E-Commerce_21_pc_Bucket_1200x900.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1"), "21 Piece Bucket", 365.90m, null },
                    { new Guid("2154e265-9bb3-4c1f-afdb-67c04acc217c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Chicken Bresteaks® + lettuce + a slice of cheese\r\n\r\n+ 3 pickles + Dreamy Creamy® sauce\r\n\r\non a toasted sesame bun", "https://chickenlicken.co.za/assets/uploads/products/menu/13_big-john-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Big John", 42.00m, null },
                    { new Guid("246a785f-4e5b-42af-ab08-8690ef76b73f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 SoulBites®", "https://chickenlicken.co.za/assets/uploads/products/menu/124_soulbites-circle9ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a9"), "Soul Bites Max", 45.00m, null },
                    { new Guid("25ef12e9-e3c2-4686-bbd2-220c77057c95"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8pc Chicken, 2 snack burgers, 4 Zinger Wings, 2 Reg Coleslaw, 2 Reg chips", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "8 Piece Family Treat", 274.90m, null },
                    { new Guid("267a7385-75c6-46f8-8545-b19a6be41af6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken fillet + lettuce + tomato\r\n\r\n+ Soulfirenaise™ sauce on a toasted sesame bun", "https://chickenlicken.co.za/assets/uploads/products/menu/10_love-me-hot-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Hot", 37.00m, null },
                    { new Guid("2a052608-c395-4106-8077-bdc3295fdab0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Hotwings® + a Slider®\r\n\r\n+ a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/47_soul-mix-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Soul Mix Snack", 30.00m, null },
                    { new Guid("2abdf6f0-dca8-40cd-8eba-b16501466333"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke 1.5 Litre Bottle", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke 1.5 Litre Bottle", 32.90m, null },
                    { new Guid("2af24aa1-871a-4f39-9a1e-e48ff85c8cb6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/60_chicken-inn-circle9ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Chicken Inn", 150.00m, null },
                    { new Guid("2c94e3b5-d152-428d-b8d0-15b1f6674d72"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes a regular Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/28_big-john-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Big John Top Deluxe", 72.00m, null },
                    { new Guid("2fdb9bce-c38c-4cf3-a6bd-90b37fd1ddf8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crunch Burger, 1 Piece of Original Recipe Chicken, 2 Zinger Wings, Small Chips & Buddy Drink", "https://images.ctfassets.net/0p42pznmbeec/2tpR61h0KxupmA8U024fwu/55f538f6ae4384b9bbdf598435d6ea53/ABC1696-all_star_box_buddy.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "All Star Box Meal Buddy", 94.90m, null },
                    { new Guid("33f75396-8ca1-4329-8325-fb1bbc79c019"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "24 Zinger Wings Bucket", 194.90m, null },
                    { new Guid("350b8f99-a41c-4b03-94bc-46188c9e36e9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "24 Zinger Wings Bucket", 194.90m, null },
                    { new Guid("35f7084a-c08b-4db3-8c8d-9841c753d68c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 KFC famous Zinger Wings dunked in a delicious honey, ginger and soy sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "4 Dunked Wings", 54.90m, null },
                    { new Guid("3a7e839f-4d6a-4a1a-85fb-35addc23ccf1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Cappy Juice 1.5 Litre", 44.90m, null },
                    { new Guid("3b5824c1-8ddd-419f-91ab-72e326d3ca33"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes a regular Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/29_love-me-tender-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Tender Top Deluxe", 70.00m, null },
                    { new Guid("3bdd47d8-6a01-4af3-9ef5-2189692986ab"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fanta Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Fanta Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("3beca58c-e91a-4206-82b2-ae6df0cca9d5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new Burger standard…Boxed! The new Colonel burger, 1 piece of original recipe chicken, regular mash & gravy, chips & a buddy no sugar drink.", "https://images.ctfassets.net/0p42pznmbeec/31yPC9ryh5KT1pOdwEOOzG/d1e2df6fc99eaf513f84b63f7d475f58/65129_kfc_-_FLBM_cheese_buddy_1200x900.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Fully Loaded Box Meal", 115.90m, null },
                    { new Guid("3da86c05-78d0-4c36-8a44-1f486d28468e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken fillet + lettuce + tomato\r\n\r\n+ Dreamy Creamy® sauce on a toasted sesame bun", "https://chickenlicken.co.za/assets/uploads/products/menu/7_love-me-tender-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Tender", 37.00m, null },
                    { new Guid("3ef125c7-a0ca-4b5b-a915-11a78c133a11"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Square chick’n burger on a toasted square bun with DREAMY CREAMY® sauce and a pickle", "https://chickenlicken.co.za/assets/uploads/products/menu/33_1-slyder-original.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Slyder Original", 14.00m, null },
                    { new Guid("3fd9f184-3510-4e41-8fd9-c61e0c0b7217"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/56_just-circle3ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 3", 60.00m, null },
                    { new Guid("41c7baec-8e3d-44c3-92fc-386ca080e3f2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new Burger standard…Boxed! The Crispy Zinger burger, 1 piece of original recipe chicken, regular mash & gravy, chips & Buddy no sugar.", "https://images.ctfassets.net/0p42pznmbeec/3spYrESfEqEyv4TaIwhQnZ/e315445416a59f4ba60acf90090482dd/62279_WickedZinger_SF_-_1200x900.png?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Zinger Fully Loaded Buddy Box Meal", 115.90m, null },
                    { new Guid("4310749e-bcd4-4ac9-9c7e-81827edf7b9c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Try the new standard! The New Colonel burger, Our trademark real chicken fillet; A fresh Brioche bun, Creamy Colonel sauce and cheese on a fresh bed of lettuce & succulent tomatoes", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Colonel Burger", 60.90m, null },
                    { new Guid("43585f6a-bf9f-4167-96b4-59146b6f1c00"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes a regular Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/30_love-me-tender-cheese-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Tender Cheese Top Deluxe", 72.00m, null },
                    { new Guid("440dcaca-12c5-42ce-850f-846aec369025"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken dunked in KFC’s famous honey, ginger and soy sauce!", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Dunked Pops", 36.90m, null },
                    { new Guid("48569339-0d8e-40f8-a7a6-3b92aba7433e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around 2 deliciously crispy chicken strips, shredded crisp lettuce, sliced tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Classic Twister", 66.90m, null },
                    { new Guid("4d160a0d-fbfb-4647-bb49-aa49684633e4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke No Sugar 1.5 Litre", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke No Sugar 1.5 Litre", 29.90m, null },
                    { new Guid("52a4c6b2-0b54-4b4c-b614-b6f9648c0157"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/58_just-circle5ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 5", 99.00m, null },
                    { new Guid("5374022e-eaec-473c-a4fb-67c379823c69"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wrapsta, 1 Piece of Original Recipe Chicken, Small Chips & Buddy Drink", "https://images.ctfassets.net/0p42pznmbeec/2snvT5LNlzizE6TGQ9KN4F/3f5c8ebf26502ad1bdf5a1cc456ccfc0/ABC1723-wrapsta_box_buddy.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Wrapsta Box Meal", 84.90m, null },
                    { new Guid("5626e3be-8c8b-4bc3-8711-6df435dc52de"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs & spices.", "https://images.ctfassets.net/0p42pznmbeec/WKTb7n2vvpdYR1v8mvXX0/4d01e6a6cf892c116f2e82bdd4b64b6a/66752_-_E-Commerce_15_pc_Bucket_1200x900.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1"), "15 Piece Bucket", 279.90m, null },
                    { new Guid("57539c74-a662-416b-ad1f-3f1f6e87623e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The game changer is here, and with a delicious spicy crunch fillet, tomato, lettuce and cheese with tangy dressing all wrapped up in a mini tortilla and grilled to perfection, meal time will never be the same again.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Wrapsta", 42.90m, null },
                    { new Guid("588ab626-40ae-4470-90ef-31d50f18885b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Popcorn Chicken® in a shaker cup\r\n\r\n+ 2 sachets SoulFire® sauce or\r\n\r\n2 sachets of Uncle Jessup’s® Ketchup\r\n\r\nto shake up the taste!", "https://chickenlicken.co.za/assets/uploads/products/menu/45_popcorn-chicken-shaker.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Popcorn Chicken Shaker", 30.00m, null },
                    { new Guid("5cdb9724-211c-43f4-aeaa-417a8ab56cb9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy a piece of original recipe chicken, 2 zinger wings and a small scrumptious chips.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Bucket For One", 46.90m, null },
                    { new Guid("5e226abb-8431-4fc3-9e41-a0c70c686996"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/59_just-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 6", 120.00m, null },
                    { new Guid("617640c8-a71d-441c-8e1f-61670b2b4990"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", "https://images.ctfassets.net/0p42pznmbeec/23emjPvgiS9FE3xT6UiBa/9a5d9ceffa02d18a26679472e7f62cfc/CHI1001-reg_chips.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Chips", 26.90m, null },
                    { new Guid("663d76bd-b0d3-46e8-855a-68003db7a8bb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of creamy mash and our delicious gravy.", "https://images.ctfassets.net/0p42pznmbeec/16hT15F1AVhciJyE32xbGE/f83f8d8d906a2593420739e995086bc4/MAG1003-reg_mash___gravy.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Large Mash & Gravy", 27.90m, null },
                    { new Guid("6933e89f-54ce-4864-95a2-09fbb32dd4a0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "21 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/62_family-barrel-circle21ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Family Barrel", 300.00m, null },
                    { new Guid("696832c3-6236-4585-986c-389e520073d8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8 Hotwings + toast + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/66_hotwings-meal-max-circle8ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Hotwings Meal Max", 90.00m, null },
                    { new Guid("72d76cad-800f-4f6d-9c29-74e9231bd828"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken that are tender on the inside and crunchy on the outside. Served with a generous sprinkle of fruit chutney flavour.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Sprinkle Pops", 54.90m, null },
                    { new Guid("730a3fb4-f191-430f-b0fd-593d4712ad24"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 Hotwings® + a portion of Soul Fries™ + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/16_hotwings-circle6ce-max.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Max", 69.00m, null },
                    { new Guid("73bcb565-0dd2-4622-ab90-cfbf49db1703"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An icy sippable treat with Oreo bitz, and creamy soft-serve.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Oreo Krusher", 42.90m, null },
                    { new Guid("75926d8f-48b8-4403-8afe-0bc3dbdef7bb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "4 Zinger Wings", 48.90m, null },
                    { new Guid("759f7631-aad0-4b71-9d6e-45f124426e44"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 pieces SoulFire® chicken + 1 sachet SoulFire® sauce", "https://chickenlicken.co.za/assets/uploads/products/menu/19_rock-my-soul-circle3cew-straight.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul 3 Straight", 57.00m, null },
                    { new Guid("75e78e68-fc65-40ae-8d9b-79c959f0ffe7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 Hotwings", "https://chickenlicken.co.za/assets/uploads/products/menu/98_hotwings-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "6 Hotwings", 42.00m, null },
                    { new Guid("7aa6a8fb-c719-4cb0-9478-03f23f11104a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken fillet + lettuce + tomato\r\n\r\n+ Soulfirenaise™ sauce + a slice of cheese\r\n\r\non a toasted sesame bun", "https://chickenlicken.co.za/assets/uploads/products/menu/12_love-me-hot-cheese-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Hot Cheese Burger", 40.00m, null },
                    { new Guid("7b6987e1-fbd4-40b9-bf23-04fa8863ded5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", "https://images.ctfassets.net/0p42pznmbeec/5Zt1jvrey6zim41HKaarJr/6c4e0a08f94a83f04ad98dc130ce67e1/CHI1002-lrg_chips.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Large Chips", 0m, null },
                    { new Guid("7cd36f88-9553-4ae6-bcff-43d4c2ca00d4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy KFC`s new Jalapeno loaded fries with brand new Hot * spicy sauce", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Jalapeno Loaded Fries", 32.90m, null },
                    { new Guid("7ffd840c-320a-4df3-a525-cbf11a18cea4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pulled Chicken Wraps (cut into 6), 3 Chicken Wraps (cut into 6), 2 Sharing Wedges, 16 Winglets, 2 Flame-grilled Mielies cut into 3 (6 portions). Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/ccc05d6a-734b-4fec-bbc7-50a7da7ad2da", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Hands-on delicious platter", 640.00m, null },
                    { new Guid("81cd7903-6b6c-402e-89c4-aef5a487c4f6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around 2 deliciously crispy new and improved chicken strips, shredded crisp lettuce, sliced tomato, topped with Colonel dressing and sweet chilli sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Sweet Chilli Twister", 66.90m, null },
                    { new Guid("82db9376-ad09-413c-8b7b-f706c025d101"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "10 Hot Zinger Wings", 89.90m, null },
                    { new Guid("861eb833-77a7-4c16-869a-5b5e4e59b792"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Square chick’n burgers on toasted square buns with DREAMY CREAMY® sauce and a pickle", "https://chickenlicken.co.za/assets/uploads/products/menu/34_2-slyders-original.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "2 Original Slyders", 27.00m, null },
                    { new Guid("868a345e-7671-4279-9427-65bd4535ec72"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milk shake milk shake shake shake", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Strawberry Milkshake", 31.90m, null },
                    { new Guid("8713d4ea-17f6-44db-8cc8-cb559ebe44a5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Two full chickens (cut into 16), 16 Winglets, 2 Flame-grilled Mielies cut into 3 (6 portions), 2 Sharing Wedges. Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/fa60cb07-3c21-4718-8f02-cb91fd83319b", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Peri-er Platter", 640.00m, null },
                    { new Guid("878cfc7e-e95e-49c8-bce1-d84f7493ebd8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces + 2 regular Soul Fries™\r\n\r\n+ 2 regular Soulslaw® / Achaar / Tomato Salsa\r\n\r\n+ 2 Licken Loafs®", "https://chickenlicken.co.za/assets/uploads/products/menu/24_family-full-house-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Family Full House", 143.00m, null },
                    { new Guid("87b856b3-e0bf-40d2-86be-68eccefb5806"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca-Cola Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coca-Cola Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("896eb24e-0eff-4325-ba16-f0d8fd6d1759"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bonaqua Still Spring Water 500ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Bonaqua Still Spring Water 500ml", 19.90m, null },
                    { new Guid("8ad6aaa2-72b3-4384-af74-f0f8818cef38"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8 pieces + 2 regular Soul Fries™\r\n\r\n+ 2 regular Soulslaw® / Achaar / Tomato Salsa\r\n\r\n+ 2 Licken Loafs®", "https://chickenlicken.co.za/assets/uploads/products/menu/25_family-full-house-circle8ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Family Full House", 173.00m, null },
                    { new Guid("8ba32bc0-0c10-4b42-be64-6db7275b6089"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extra Hot & Spicy Zinger sauce on the side", "https://images.ctfassets.net/0p42pznmbeec/bEZLbUGmprwC7wW3i0GsS/73b63ef3ac73d2e805688b74cdbc31c0/Hot_n_Spicy_sauce_-_1200x900.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Sauce - Hot & Spicy", 0m, null },
                    { new Guid("8d5fab19-0ed6-43a6-b691-f6576f3041ba"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8 Hotwings + toast + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/65_hotwings-meal-circle8ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Hotwings Meal", 86.00m, null },
                    { new Guid("8f7beac2-86f6-47d9-a7ec-e6d77139662b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 pieces of crispy, delicious golden brown Nuggets, paired with 1 delicious Colonel dipping sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "9Pc Nuggets", 42.90m, null },
                    { new Guid("8fe16d32-6405-4f8b-9f62-6944b5a27213"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + toast + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/64_lunch-meal-max.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Lunch Meal Max", 76.00m, null },
                    { new Guid("9044fe46-cb01-4a6f-9d43-40a69de8f388"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprite Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Sprite Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("94ed9037-c40e-4500-b585-a8b50a375b67"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 piece", "https://chickenlicken.co.za/assets/uploads/products/menu/54_just-circle1ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 1", 20.00m, null },
                    { new Guid("950ce23b-e75f-4908-b8c3-874c541c474d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "36 Hotwings", "https://chickenlicken.co.za/assets/uploads/products/menu/5_hotwings-circle36ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "36 Hotwings", 231.00m, null },
                    { new Guid("9555f82c-6921-49e2-8931-e66291c8f2ed"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 KFC famous Zinger Wings dunked in a delicious honey, ginger and soy sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "10 Dunked Wings", 104.90m, null },
                    { new Guid("9a34a920-50a6-475e-8f01-7ab128ac4ec3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10pc Chicken, 2 snack burgers, 4 Zinger Wings, 2 Reg Coleslaw, 2 Reg chips", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "10 Piece Family Treat", 316.90m, null },
                    { new Guid("9cc0b7d0-de68-4d8a-95ad-608fecbd669e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 Hotwings® + a portion of Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/15_hotwings-circle6ce-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Deluxe", 67.00m, null },
                    { new Guid("9ec62bc7-b117-4215-873d-0825436d5480"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "  Square chick’n burger on a toasted square bun with DREAMY CREAMY® sauce and a pickle and cheese", "https://chickenlicken.co.za/assets/uploads/products/menu/36_1-slyder-cheese.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Cheese Slyder", 16.00m, null },
                    { new Guid("9f19d17f-6159-442b-95ea-b57d6da0f39b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Hotwings® + a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/46_hotwings-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Hotwings Snack", 30.00m, null },
                    { new Guid("a0d4e71f-30db-41ff-baf4-cdcfb803520e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A generous sharing platter of 4 succulent Flame-grilled Shisanyama Chicken Sosaties and 20 Winglets, served with 2 portions of our Sharing Wedges, 2 Garlic Rolls and our special PERinase dip.", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/3d93a55d-440a-407c-8b7b-97cc1e6c510a", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Cabo Sosatie Snack Platter", 349.00m, null },
                    { new Guid("a3165ea9-a70c-41ba-a847-5cc93a377850"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pieces of original recipe chicken, a portion of small chips.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Three with Chips", 72.90m, null },
                    { new Guid("a3eb1d99-7c45-42ef-abad-ad69fb88824b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + a portion of Soul Fries™ + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/51_soulsister-circle2ce-max.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Max", 65.00m, null },
                    { new Guid("a5de3d61-6012-4b0f-b605-2b26608e6818"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 pieces SoulFire® chicken + a portion of Soul Fries™\r\n\r\n+ 1 sachet SoulFire® sauce ", "https://chickenlicken.co.za/assets/uploads/products/menu/20_rock-my-soul-circle3ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul 3 Combo", 60.00m, null },
                    { new Guid("a94c8475-55c5-4245-8c2c-d629aacf2e6b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke No Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke No Sugar Buddy 440ml", 22.90m, null },
                    { new Guid("a9907044-29fb-4d23-a723-88aa616b53d5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Nuggets, 1 Crunch Burger, 1 Small Chips and a Buddy Drink", "https://images.ctfassets.net/0p42pznmbeec/1L5C3sZ1MmaHtuQLewHqYa/5e4ecba1d83ade38d554eba1a7431551/ABC2120-nugget_box_buddy_1.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Nugget Box Buddy Meal", 79.90m, null },
                    { new Guid("a9dc10c2-2d45-4f5d-8dc6-1713c8afc9b2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around a delicious fillet zinger recipe - a slice of cheese, hash brown, crisp lettuce, fresh tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Zinger Boxmaster", 76.90m, null },
                    { new Guid("abba6c2a-0759-45a5-a9f2-fb33b69f963b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes a regular Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/31_love-me-hot-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Hot Top Deluxe", 70.00m, null },
                    { new Guid("b0371534-fbf4-4568-b335-f94f92014b20"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "16 Hotwings® + 2 regular Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/17_hotwings-party-circle16ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Party", 132.00m, null },
                    { new Guid("b140d833-28fd-4425-99f7-0173f8bfcc24"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + a Licken Loaf", "https://chickenlicken.co.za/assets/uploads/products/menu/129_soulsister-2-vibe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Vibe", 40.00m, null },
                    { new Guid("b1b6476f-d489-40b6-8f64-e955603c16db"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get yourself a Streetwise 5, with 2 Buddy No Sugar", "https://images.ctfassets.net/0p42pznmbeec/2uwM3hjbse4hzaZv6d5peO/576343077547dc714bf02883a79589f6/ICM1009-streetwise_5_chips.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Streetwise 5 Buddy", 143.90m, null },
                    { new Guid("b28ccabb-38b6-4103-8d4c-77d7a225c523"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Veg Burgers, 2 Halloumi & Roast Veg Wraps, 2 Halloumi & Roast Veg Pitas, 2 Sharing Wedges, 4 Flame-grilled Mielies cut into 3 (12 portions). Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/3b7bc5aa-eb6c-4f3b-a289-ae9669f410dd", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Veggie veggie nice platter", 640.00m, null },
                    { new Guid("b3340c12-2fa7-4f41-a8e7-ff0526cff861"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 pieces + a portion of Soul Fries™ + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/53_soulsister-party-circle5ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Party", 112.00m, null },
                    { new Guid("b36a36ed-e17c-462c-bc6e-95babaf7edc4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 Hotwings® + a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/18_feed-my-craving-circle10ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Feed My Craving", 79.00m, null },
                    { new Guid("b47be2fb-c975-4129-894f-48562de99efe"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 Piece Chicken", "https://images.ctfassets.net/0p42pznmbeec/2XhP71I12p5tncjyX1P81w/d94f9543674f4728165031f42dcb2653/ALA1001-1pc_cob.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "1 Piece Chicken", 26.90m, null },
                    { new Guid("b863ef05-6c9d-498b-8316-b9365fa345a0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/57_just-circle4ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 4", 80.00m, null },
                    { new Guid("b86858cb-6f64-4005-9c02-1beb55ff3e77"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken fillet + lettuce + tomato\r\n\r\n+ Dreamy Creamy® sauce + a slice of cheese\r\n\r\non a toasted sesame bun", "https://chickenlicken.co.za/assets/uploads/products/menu/9_love-me-tender-cheese-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Tender Cheese Burger", 40.00m, null },
                    { new Guid("bb3d3b08-8d9a-4bff-a8ca-13fc581215b6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get yourself a Streetwise 1, with a Buddy no sugar free drink", "https://images.ctfassets.net/0p42pznmbeec/3QpxFh5qLJj5GT8dEMW3iZ/3acbea341f4c8d3162163373ff8ed48f/COM2029-streetwise_bucket_for_1.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Streetwise 1 Buddy", 52.90m, null },
                    { new Guid("c0822b42-a5aa-4487-be28-68e3c2a1faef"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", "https://images.ctfassets.net/0p42pznmbeec/4J7RauzcyD6KkQu9Qhpp28/da6827d46db9161d26ae26c874be5123/ABC1247-sml_chips.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Small Chips", 16.90m, null },
                    { new Guid("c108f937-e0bd-4b9b-be3e-fc67f68ab330"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A delicious chicken patty served with shredded lettuce & Colonel dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Snack Burger", 29.90m, null },
                    { new Guid("c14de0f4-6942-43bc-8922-b0d51ead81cc"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "One and a 1/2 full chickens ( cut into 12), 2 Flame-grilled Mielies cut into 3 (6 portions), 4 Kids Burgers, 2 Sharing Wedges. Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/5182f543-741a-4317-a731-e8098a228c37", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "More to share platter", 640.00m, null },
                    { new Guid("c313ad68-5211-4a39-bfdd-c3bb1eadd286"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An icy sippable treat with Berry bitz, and creamy soft-serve.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Verry Berry Krusher", 42.90m, null },
                    { new Guid("c32e5bc2-ad1c-4aad-bd07-5582284f336f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around a delicious fillet original recipe - a slice of cheese, hash brown, crisp lettuce, fresh tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Colonel Boxmaster", 76.90m, null },
                    { new Guid("c3aab55c-5ab6-45fc-9cb9-9ba9f3cf02c0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy 6 pieces of delicious original recipe chicken, 1 large chips, 1 regular coleslaw plus 2 regular mash and gravies.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "All In One Feast", 194.90m, null },
                    { new Guid("cae83128-6f19-4f51-8197-9ea231718839"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs and spices of Original Recipe® chicken, marinated and cooked to perfection.", "https://images.ctfassets.net/0p42pznmbeec/2ZE6o3XzzI7YzGsVVT4ubY/e95c55d0c1b050b91a2b070a5ad1b32e/9_piece_bucket.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1"), "9 Piece Bucket", 182.90m, null },
                    { new Guid("cff4c488-336d-4a87-90fa-516ebe458973"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy 4 pieces of original recipe chicken, 2 small chips, 1 small pops & 2 buddy no sugar drinks.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "2 Can Dine Buddy", 164.90m, null },
                    { new Guid("d018e40f-e7d4-4537-9239-4ab62f39b6cf"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/61_family-bucket-circle15ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Family Bucket", 230.00m, null },
                    { new Guid("d2a85f64-2a2a-46cb-b45d-bc61aa014ea6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Hotwings® + 4 Sliders®\r\n\r\n+ 2 regular Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/23_soul-mates-classic-party.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soul Mates Classic Party", 145.00m, null },
                    { new Guid("d51e0a7e-cb07-4e62-8f8a-6b2939319d2d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 Piece + 4 Hotwing®s + 1 Licken Loaf", "https://chickenlicken.co.za/assets/uploads/products/menu/128_soul-square-meal-.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soul Square Meal", 50.00m, null },
                    { new Guid("d766a38a-4b4f-4dd3-995c-e640b2feb9ab"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Original Slyders® + a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/44_slyder-snack-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Slyder Snack", 30.00m, null },
                    { new Guid("dc89da39-144f-4b07-84b0-9bdd6d2e202b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Love Me Tender® Burger + a regular Soul Fries™\r\n\r\n+ 2 Hotwings® + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/22_soulman-load-up.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soulman Load Up", 80.00m, null },
                    { new Guid("dcd5c428-abe3-49d5-97c4-0b300415da9a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + toast + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/63_lunch-meal.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Lunch Meal", 73.00m, null },
                    { new Guid("e0a31a3f-7217-4370-a3c1-d07a1789d6a3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A spicy, crunchy mini fillet with a slice of cheese and lettuce, covered in tangy dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Crunch Burger", 36.90m, null },
                    { new Guid("e1da75fb-9677-494e-82f2-40e984f45c9e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of creamy mash and our delicious gravy.", "https://images.ctfassets.net/0p42pznmbeec/16hT15F1AVhciJyE32xbGE/f83f8d8d906a2593420739e995086bc4/MAG1003-reg_mash___gravy.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Mash & Gravy", 19.90m, null },
                    { new Guid("e2cbf650-8c97-48df-99df-85a5e3a6e50e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Pieces of Original Recipe Chicken and Small Chips or Coleslaw.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Two with Chips", 49.90m, null },
                    { new Guid("e3a642ba-4ef3-4adf-93b2-83816c3fff53"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oven baked, fresh mini loaf", "https://images.ctfassets.net/0p42pznmbeec/2X0ukPSNX6j4kHDE2o2mGa/e910e8f156eb5ca37642fb19944603a0/MIS1001-1_mini_loaf.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Mini Loaf", 14.90m, null },
                    { new Guid("e522cd94-7f8e-4920-893f-b4fd71429366"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 pieces + a portion of Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/52_soulsister-party-circle4ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Party", 84.00m, null },
                    { new Guid("eb0b5b2c-2caa-4773-8474-bc7afa1b1234"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Try the new standard! The New Crispy Zinger burger, Our trademark real chicken fillet; A fresh Brioche bun, New Hot & Spicy sauce and cheese on a fresh bed of lettuce & succulent tomatoes", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Zinger Burger", 60.90m, null },
                    { new Guid("ebacf111-8ac1-4ab7-953e-99ac690ca8f6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes a regular Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/32_love-me-hot-cheese-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Hot Cheese Top Deluxe", 72.00m, null },
                    { new Guid("f3902e0d-224d-45a9-9a2f-9951b21d56bd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A delicious chicken patty served with shredded lettuce & Colonel dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Snack Burger", 29.90m, null },
                    { new Guid("f430c03c-68bb-425a-88b3-e80ba2e4d209"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy a delicious Crunch Burger an orginal receipe chicken piece with small chips and a buddy no sugar drink", "https://images.ctfassets.net/0p42pznmbeec/3QpxFh5qLJj5GT8dEMW3iZ/3acbea341f4c8d3162163373ff8ed48f/COM2029-streetwise_bucket_for_1.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Crunch Burger Box Buddy", 71.90m, null },
                    { new Guid("f532c172-d914-4e2d-a040-3af58eefd55d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 Pieces of Original Recipe chicken cooked to golden perfection and a large portion of chips or coleslaw.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Five", 121.90m, null },
                    { new Guid("f8322e94-9ed9-4151-bf87-16604dec56ba"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces SoulFire® chicken + 1 regular Soul Fries™\r\n\r\n+ 2 sachets SoulFire® sauce", "https://chickenlicken.co.za/assets/uploads/products/menu/21_rock-my-soul-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul", 105.00m, null },
                    { new Guid("fa757fc4-874c-46c4-8e81-e8db719ea8c5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Hotwings", "https://chickenlicken.co.za/assets/uploads/products/menu/4_hotwings-circle24ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "24 Hotwings", 168.00m, null },
                    { new Guid("ff975b6c-7ef9-4638-81e3-764ed53cd3fa"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/49_soulsister-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister", 43.00m, null },
                    { new Guid("ffd360ff-d732-40f5-8918-80e73e63f951"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces of crispy, delicious golden brown Nuggets, paired with 1 delicious Colonel dipping sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "6Pc Nuggets", 36.90m, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketLines_BasketId",
                table: "BasketLines",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketLines_MenuItemId",
                table: "BasketLines",
                column: "MenuItemId");

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
                name: "IX_OrderLines_MenuItemId",
                table: "OrderLines",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_OrderId",
                table: "OrderLines",
                column: "OrderId");

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
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "BasketLines");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "CreditCards");

            migrationBuilder.DropTable(
                name: "OrderLines");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Orders");

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
