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
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
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
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
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
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
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
                    SubMenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.MenuItemId);
                    table.ForeignKey(
                        name: "FK_MenuItems_Submenus_SubMenuId",
                        column: x => x.SubMenuId,
                        principalTable: "Submenus",
                        principalColumn: "SubmenuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedBy", "CreatedDate", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "Name", "SvgUrl" },
                values: new object[,]
                {
                    { new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/04.jpg", null, null, "Pizza & Pasta", "img/food-delivery/icons/pizza.svg" },
                    { new Guid("ae98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/01.jpg", null, null, "Grills & Steak", "img/food-delivery/icons/steak.svg" },
                    { new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dda"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/04.jpg", null, null, "Haute Cuisine", "img/food-delivery/icons/pizza.svg" },
                    { new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/01.jpg", null, null, "Chicken & Wings", "img/food-delivery/icons/chicken.svg" },
                    { new Guid("bf3f3002-7e53-441e-8b76-f6280be284aa"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/04.jpg", null, null, "Noodles", "img/food-delivery/icons/pizza.svg" },
                    { new Guid("ce98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/06.jpg", null, null, "Healthy food", "img/food-delivery/icons/healthy.svg" },
                    { new Guid("de98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/03.jpg", null, null, "Fish & Seafood", "img/food-delivery/icons/fish.svg" },
                    { new Guid("ee98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/05.jpg", null, null, "Coffee & Desserts", "img/food-delivery/icons/coffee.svg" },
                    { new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/01.jpg", null, null, "Burgers & Fries", "img/food-delivery/icons/burger.svg" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "CategoryId", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "LogoUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("1313179f-7837-473a-a4d5-a5571b43e6a6"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dda"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Doppio Zero" },
                    { new Guid("2313179f-1837-173a-a4d5-a5571b43e6a9"), new Guid("ae98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Mike's Heritage House" },
                    { new Guid("2313179f-1837-273a-a4d5-a5571b43e6a9"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dda"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Spiceburg Greenside" },
                    { new Guid("2313179f-1837-373a-a4d5-a5571b43e6a9"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dda"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Miyako Sushi" },
                    { new Guid("2313179f-1837-473a-a4d1-a5571b43e6a9"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dda"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Chop Stix" },
                    { new Guid("2313179f-1837-473a-a4d5-a5571b43e6a6"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dda"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Simply Asia" },
                    { new Guid("2313179f-1837-473a-a4d5-a5571b43e6a7"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dda"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Asian Twist" },
                    { new Guid("2313179f-1837-473a-a4d5-a5571b43e6a8"), new Guid("ae98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Thunder Gun" },
                    { new Guid("2313179f-1837-473a-a4d5-a5571b43e6a9"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dda"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Curry Up" },
                    { new Guid("2313179f-1837-573a-a4d5-a5571b43e6a9"), new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Topo Gigio" },
                    { new Guid("2313179f-1837-673a-a4d5-a5571b43e6a9"), new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Satori" },
                    { new Guid("2313179f-1837-773a-a4d5-a5571b43e6a9"), new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Pizza e Vino" },
                    { new Guid("2313179f-1837-873a-a4d5-a5571b43e6a9"), new Guid("de98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Jimmy's" },
                    { new Guid("2313179f-1837-973a-a4d5-a5571b43e6a9"), new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Pasta Worx" },
                    { new Guid("2313179f-2837-473a-a4d5-a5571b43e6a6"), new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Andiccio24" },
                    { new Guid("2313179f-3837-473a-a4d5-a5571b43e6a6"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Pedro's Chicken" },
                    { new Guid("2313179f-4837-473a-a4d5-a5571b43e6a6"), new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Pizza Perfect" },
                    { new Guid("2313179f-5837-473a-a4d5-a5571b43e6a6"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dda"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Pron" },
                    { new Guid("2313179f-6837-473a-a4d5-a5571b43e6a6"), new Guid("ce98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "The Fussy Vegan" },
                    { new Guid("2313179f-7837-473a-a4d5-a5571b43e6a1"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dda"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Tei Avon" },
                    { new Guid("2313179f-7837-473a-a4d5-a5571b43e6a2"), new Guid("ee98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "X&O" },
                    { new Guid("2313179f-7837-473a-a4d5-a5571b43e6a3"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dda"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Hao Ke Lai" },
                    { new Guid("2313179f-7837-473a-a4d5-a5571b43e6a4"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dda"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Momo Baohaus" },
                    { new Guid("2313179f-7837-473a-a4d5-a5571b43e6a5"), new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "La Padrino" },
                    { new Guid("2313179f-7837-473a-a4d5-a5571b43e6a6"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Mochachos" },
                    { new Guid("2313179f-8837-473a-a4d5-a5571b43e6a6"), new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Pizza Baby" },
                    { new Guid("6313179f-7837-473a-a4d5-b5571b43e6a6"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "KFC" },
                    { new Guid("6313179f-7837-473a-a4d5-c5571b43e6a6"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Chicken Licken" },
                    { new Guid("6313179f-7837-473a-a4d5-d5571b43e6a6"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nandos" },
                    { new Guid("6313179f-7837-473a-a4d5-e5571b43e6a6"), new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Roman's Pizza" },
                    { new Guid("6313179f-7837-473a-a4d5-f5571b43e6a6"), new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Debonair's Pizza" },
                    { new Guid("6313179f-7837-473a-b4d5-a5571b43e6a6"), new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "McDonald's" },
                    { new Guid("6313179f-7837-473a-c4d5-a5571b43e6a6"), new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Steers" },
                    { new Guid("6313179f-7837-473a-d4d5-a5571b43e6a6"), new Guid("de98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Fishaways" },
                    { new Guid("6313179f-7837-473a-e4d5-a5571b43e6a6"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Kung Fu Chicken" },
                    { new Guid("6313179f-7837-473a-f4d5-a5571b43e6a6"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Galito's" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "Name", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("2313179f-1837-173a-a2d5-a2571b43e6a9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "", new Guid("6313179f-7837-473a-a4d5-f5571b43e6a6") },
                    { new Guid("2313179f-1837-173a-a4d5-a1571b43e6a9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "", new Guid("6313179f-7837-473a-a4d5-b5571b43e6a6") },
                    { new Guid("2313179f-1837-173a-a4d5-a3571b43e6a9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "", new Guid("6313179f-7837-473a-b4d5-a5571b43e6a6") },
                    { new Guid("2313179f-1837-173a-a4d5-a4571b43e6a9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "", new Guid("2313179f-1837-873a-a4d5-a5571b43e6a9") },
                    { new Guid("2313179f-1837-173a-a4d5-a6571b43e6a9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "", new Guid("2313179f-1837-473a-a4d5-a5571b43e6a9") }
                });

            migrationBuilder.InsertData(
                table: "Submenus",
                columns: new[] { "SubmenuId", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "MenuId", "Name" },
                values: new object[,]
                {
                    { new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2313179f-1837-173a-a4d5-a1571b43e6a9"), "Buckets" },
                    { new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2313179f-1837-173a-a4d5-a1571b43e6a9"), "Box Meals" },
                    { new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2313179f-1837-173a-a4d5-a1571b43e6a9"), "Streetwise" },
                    { new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2313179f-1837-173a-a4d5-a1571b43e6a9"), "Drinks & Treats" },
                    { new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2313179f-1837-173a-a4d5-a1571b43e6a9"), "Sharing" },
                    { new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2313179f-1837-173a-a4d5-a1571b43e6a9"), "Wings & Snacks" },
                    { new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2313179f-1837-173a-a4d5-a1571b43e6a9"), "Burgers & Wraps" },
                    { new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2313179f-1837-173a-a4d5-a1571b43e6a9"), "Add Ons" }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemId", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "Name", "Price", "SubMenuId" },
                values: new object[,]
                {
                    { new Guid("04bdd615-4858-45bc-be07-be7e6e17ce96"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Nuggets, 1 Crunch Burger, 1 Small Chips and a Buddy Drink", null, null, null, "Nugget Box Buddy Meal", 79.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2") },
                    { new Guid("062fdec8-ebe9-47e7-b8b5-81ee8bb6f1be"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprite Sugar Buddy 440ml", null, null, null, "Sprite Sugar Buddy 440ml", 24.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4") },
                    { new Guid("087ca6bc-7788-4bde-a7d9-f2b3868f3434"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca-Cola Sugar Buddy 440ml", null, null, null, "Coca-Cola Sugar Buddy 440ml", 24.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4") },
                    { new Guid("0a6ecaed-708b-40c7-a9ec-3a8b59a37a6f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy KFC`s new Jalapeno loaded fries with brand new Hot * spicy sauce", null, null, null, "Jalapeno Loaded Fries", 32.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6") },
                    { new Guid("10da7fb5-44d1-4dce-b9d6-1350a5b2e649"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An icy sippable treat with Oreo bitz, and creamy soft-serve.", null, null, null, "Oreo Krusher", 42.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4") },
                    { new Guid("10fee9e5-123d-4b1a-b8b1-e22d76e69899"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chocolate Milkshake", null, null, null, "Chocolate Milkshake", 31.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4") },
                    { new Guid("122b61eb-2448-429c-99ba-519850610ec9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An icy sippable treat with Berry bitz, and creamy soft-serve.", null, null, null, "Verry Berry Krusher", 42.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4") },
                    { new Guid("156466e4-4cd2-403a-9e87-417f605d0516"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken, tender on the inside and crunchy on the outside.", null, null, null, "Large Pops", 54.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6") },
                    { new Guid("15e4cb8a-b838-4e99-a07a-cd8dd8a26cea"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A delicious chicken patty served with shredded lettuce & Colonel dressing on a snack bun.", null, null, null, "Snack Burger", 29.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7") },
                    { new Guid("197f4718-c66a-47f7-9bea-e4e0d5545ef6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken dunked in KFC’s famous honey, ginger and soy sauce!", null, null, null, "Dunked Pops", 36.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6") },
                    { new Guid("1acbcae5-6704-4014-8e98-3b42576e9560"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The game changer is here, and with a delicious spicy crunch fillet, tomato, lettuce and cheese with tangy dressing all wrapped up in a mini tortilla and grilled to perfection, meal time will never be the same again.", null, null, null, "Wrapsta", 42.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7") },
                    { new Guid("1d8eb75e-ffeb-4025-abf7-d0d3eed7870e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A delicious chicken patty served with shredded lettuce & Colonel dressing on a snack bun.", null, null, null, "Snack Burger", 29.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6") },
                    { new Guid("25359ba0-3fae-47dc-a334-dc84dce17d20"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 KFC famous Zinger Wings dunked in a delicious honey, ginger and soy sauce.", null, null, null, "10 Dunked Wings", 104.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6") },
                    { new Guid("295f429b-df19-4ff8-8497-15fff5f8dc1b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", null, null, null, "Small Chips", 16.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8") },
                    { new Guid("2b8eb1dc-39ef-47c2-aa57-7a96700789ec"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, "10 Hot Zinger Wings", 89.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6") },
                    { new Guid("2c1278b6-bedf-4464-a727-474870c05029"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy a piece of original recipe chicken, 2 zinger wings and a small scrumptious chips.", null, null, null, "Streetwise Bucket For One", 46.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3") },
                    { new Guid("2ec6d136-7430-49bc-a846-6790ce3e97de"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wrapsta, 1 Piece of Original Recipe Chicken, Small Chips & Buddy Drink", null, null, null, "Wrapsta Box Meal", 84.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2") },
                    { new Guid("2fa018d5-3a51-4382-a6d3-3d9115af914f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 KFC famous Zinger Wings dunked in a delicious honey, ginger and soy sauce.", null, null, null, "4 Dunked Wings", 54.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6") },
                    { new Guid("30875b45-bb04-4dfb-9d8b-a1fcf4361296"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new Burger standard…Boxed! The new Colonel burger, 1 piece of original recipe chicken, regular mash & gravy, chips & a buddy no sugar drink.", null, null, null, "Fully Loaded Box Meal", 115.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2") },
                    { new Guid("328e4b37-d311-4d38-8284-ee11ea080e3d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new Burger standard…Boxed! The Crispy Zinger burger, 1 piece of original recipe chicken, regular mash & gravy, chips & Buddy no sugar.", null, null, null, "Zinger Fully Loaded Buddy Box Meal", 115.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2") },
                    { new Guid("366f6bfb-7177-42ee-bb9b-fe3bf9bd0bc1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke No Sugar 1.5 Litre", null, null, null, "Coke No Sugar 1.5 Litre", 29.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4") },
                    { new Guid("3964cabb-1dd1-47df-b3d2-e4995c070963"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Try the new standard! The New Colonel burger, Our trademark real chicken fillet; A fresh Brioche bun, Creamy Colonel sauce and cheese on a fresh bed of lettuce & succulent tomatoes", null, null, null, "New Colonel Burger", 60.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7") },
                    { new Guid("3b1beae5-664a-4d23-99df-1e8a098980e9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy a delicious Crunch Burger an orginal receipe chicken piece with small chips and a buddy no sugar drink", null, null, null, "SW Bozza Crunch Burger Box Buddy", 71.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3") },
                    { new Guid("3c6881d0-fe52-4b77-875b-e89b51d2ff87"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", null, null, null, "Regular Chips", 26.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8") },
                    { new Guid("44658f51-6994-4d2f-b7bf-dcd58a936fd6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around 2 deliciously crispy new and improved chicken strips, shredded crisp lettuce, sliced tomato, topped with Colonel dressing and sweet chilli sauce.", null, null, null, "Sweet Chilli Twister", 66.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7") },
                    { new Guid("4ca1993e-a33f-44a2-9dcc-759c4ba4efea"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8pc Chicken, 2 snack burgers, 4 Zinger Wings, 2 Reg Coleslaw, 2 Reg chips", null, null, null, "8 Piece Family Treat", 274.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5") },
                    { new Guid("56bd0342-06ad-4ff9-97b6-464cf8afbe13"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milk shake milk shake shake shake", null, null, null, "Strawberry Milkshake", 31.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4") },
                    { new Guid("5815ed95-97d9-45ed-b4c6-7cab3215755b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, "24 Zinger Wings Bucket", 194.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5") },
                    { new Guid("5b42075d-a0ba-4553-8846-ec2a966c0d07"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pieces of Original Recipe Chicken with a portion of pap and gravy", null, null, null, "Streetwise Three with Pap", 72.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3") },
                    { new Guid("61ab9f1e-e7ef-4af7-941a-1f5d69ae7af0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 Pieces of Original Recipe chicken cooked to golden perfection and a large portion of chips or coleslaw.", null, null, null, "Streetwise Five", 121.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3") },
                    { new Guid("65541aa9-6390-4443-b943-8d0ea9d9e927"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, "24 Zinger Wings Bucket", 194.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6") },
                    { new Guid("68a5d943-dee2-4edd-bf73-ebd6fe6a47b7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pieces of original recipe chicken, a portion of small chips.", null, null, null, "Streetwise Three with Chips", 72.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3") },
                    { new Guid("70777092-3da3-48f4-9b50-79279fd4e55d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, null, null, "Cappy Juice 1.5 Litre", 44.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4") },
                    { new Guid("74a54ef1-9aea-4f26-bb83-6cbb6708bad0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 Piece Chicken", null, null, null, "1 Piece Chicken", 26.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8") },
                    { new Guid("7f4d0cec-8735-4720-8a8a-3bf637e3d364"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extra Hot & Spicy Zinger sauce on the side", null, null, null, "Sauce - Hot & Spicy", 0m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8") },
                    { new Guid("8551b1ac-1077-467d-8c32-d24d4f95d150"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A spicy, crunchy mini fillet with a slice of cheese and lettuce, covered in tangy dressing on a snack bun.", null, null, null, "Crunch Burger", 36.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7") },
                    { new Guid("88ce0271-5b2b-4dfb-a708-430d53bae7ea"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of creamy mash and our delicious gravy.", null, null, null, "Regular Mash & Gravy", 19.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8") },
                    { new Guid("92d00a5b-b785-4cb9-aea0-70fec977197c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around a delicious fillet zinger recipe - a slice of cheese, hash brown, crisp lettuce, fresh tomato and a dash of Colonel dressing.", null, null, null, "Zinger Boxmaster", 76.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7") },
                    { new Guid("961a8c20-1568-4f94-a07e-35602a25de43"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs and spices of Original Recipe® chicken, marinated and cooked to perfection.", null, null, null, "9 Piece Bucket", 182.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1") },
                    { new Guid("981e0990-ef7a-430a-900b-c7957a40b1bf"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around a delicious fillet original recipe - a slice of cheese, hash brown, crisp lettuce, fresh tomato and a dash of Colonel dressing.", null, null, null, "Colonel Boxmaster", 76.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7") },
                    { new Guid("9b0e9659-ec1a-4cee-9fa4-387fc909971b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 pieces of crispy, delicious golden brown Nuggets, paired with 1 delicious Colonel dipping sauce.", null, null, null, "9Pc Nuggets", 42.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6") },
                    { new Guid("9c88759a-f058-4147-a4cb-85cf3597678d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "21 Pieces of juicy chicken seasoned with the 11 secret herbs and spices of Original Recipe® chicken, marinated and cooked to perfection.", null, null, null, "21 Piece Bucket", 365.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1") },
                    { new Guid("a5198560-ccd3-4153-acb4-8f2e8e04b6f6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy 6 pieces of delicious original recipe chicken, 1 large chips, 1 regular coleslaw plus 2 regular mash and gravies.", null, null, null, "All In One Feast", 194.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5") },
                    { new Guid("a9735813-ff91-42e1-99b5-0804c894e680"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, "4 Zinger Wings", 48.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6") },
                    { new Guid("ae2f4bc4-9b76-4d95-90c2-c1f7a3d60f1e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of freshly prepared cabbage, onions and carrots in a delicious dressing", null, null, null, "Regular Coleslaw", 24.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8") },
                    { new Guid("b163c283-8557-45b8-950e-2b65b311692b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken that are tender on the inside and crunchy on the outside.", null, null, null, "Small Pops", 29.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6") },
                    { new Guid("b1b8b8ca-6457-4584-aaae-b206ba8481b7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oven baked, fresh mini loaf", null, null, null, "Mini Loaf", 14.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8") },
                    { new Guid("b44cac15-1158-4544-b6da-9f94b5d6dc84"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fanta Sugar Buddy 440ml", null, null, null, "Fanta Sugar Buddy 440ml", 24.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4") },
                    { new Guid("b876a9bf-c655-4f0b-aa1f-24e836915713"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Pieces of original recipe chicken cooked to golden perfection and a regular portion of pap & small gravy.", null, null, null, "Streetwise Two with Pap", 49.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3") },
                    { new Guid("bf02831b-3a89-4438-ab64-d9bad998b5ae"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke No Sugar Buddy 440ml", null, null, null, "Coke No Sugar Buddy 440ml", 22.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4") },
                    { new Guid("c53e8503-65ce-49dd-a137-e59a9dbf763a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get yourself a Streetwise 1, with a Buddy no sugar free drink", null, null, null, "SW Bozza Streetwise 1 Buddy", 52.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3") },
                    { new Guid("cb1afe33-b05b-4b6f-918b-841f9a12963b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10pc Chicken, 2 snack burgers, 4 Zinger Wings, 2 Reg Coleslaw, 2 Reg chips", null, null, null, "10 Piece Family Treat", 316.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5") },
                    { new Guid("cdee9122-fbe8-4a20-94e7-5f2d2fdf2c73"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs & spices.", null, null, null, "15 Piece Bucket", 279.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1") },
                    { new Guid("d05bb775-3cb2-44f0-af96-435d895e0dc0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Pieces of Original Recipe Chicken and Small Chips or Coleslaw.", null, null, null, "Streetwise Two with Chips", 49.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3") },
                    { new Guid("d0e7ff2f-b159-4e6b-bc83-79d296ddd18a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around 2 deliciously crispy chicken strips, shredded crisp lettuce, sliced tomato and a dash of Colonel dressing.", null, null, null, "Classic Twister", 66.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7") },
                    { new Guid("d1de3f40-a36b-4a97-be0d-08d16d96b86d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy 4 pieces of original recipe chicken, 2 small chips, 1 small pops & 2 buddy no sugar drinks.", null, null, null, "2 Can Dine Buddy", 164.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5") },
                    { new Guid("d38121a0-0696-4fcd-9f6e-c3d7366366cc"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get yourself a Streetwise 5, with 2 Buddy No Sugar", null, null, null, "SW Bozza Streetwise 5 Buddy", 143.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3") },
                    { new Guid("d78be622-f004-4a6d-a0f7-b0fad0714791"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces of crispy, delicious golden brown Nuggets, paired with 1 delicious Colonel dipping sauce.", null, null, null, "6Pc Nuggets", 36.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6") },
                    { new Guid("daa02cf3-9cde-41be-be44-f9a53b978f9d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new standard in burgers! 2 Spicy, crunchy mini fillets with 2 cheese slices, lettuce & tomato covered in tangy dressing on a burger bun", null, null, null, "New Double Crunch Burger", 68.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7") },
                    { new Guid("e065f58d-1308-4109-9dde-98d4e2049605"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bonaqua Still Spring Water 500ml", null, null, null, "Bonaqua Still Spring Water 500ml", 19.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4") },
                    { new Guid("e4e806b1-9d9b-423a-8d77-10cd527165fc"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke 1.5 Litre Bottle", null, null, null, "Coke 1.5 Litre Bottle", 32.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4") },
                    { new Guid("e6f508a5-0db3-4928-b08f-e826c346f4d2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of creamy mash and our delicious gravy.", null, null, null, "Large Mash & Gravy", 27.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8") },
                    { new Guid("e7a2aa34-1de1-4f74-be0e-50a3989dba8b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crunch Burger, 1 Piece of Original Recipe Chicken, 2 Zinger Wings, Small Chips & Buddy Drink", null, null, null, "All Star Box Meal Buddy", 94.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2") },
                    { new Guid("e87f9c52-9db5-4e63-84e8-371388d5b485"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken that are tender on the inside and crunchy on the outside. Served with a generous sprinkle of fruit chutney flavour.", null, null, null, "Sprinkle Pops", 54.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6") },
                    { new Guid("eacdf9d7-0558-4f97-b227-29f879f302cb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Try the new standard! The New Crispy Zinger burger, Our trademark real chicken fillet; A fresh Brioche bun, New Hot & Spicy sauce and cheese on a fresh bed of lettuce & succulent tomatoes", null, null, null, "New Zinger Burger", 60.90m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7") },
                    { new Guid("ec3412a5-3c4f-4505-a28f-ab766d4d3877"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", null, null, null, "Large Chips", 0m, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_SubMenuId",
                table: "MenuItems",
                column: "SubMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_RestaurantId",
                table: "Menus",
                column: "RestaurantId",
                unique: true);

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
