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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    logoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Menu",
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
                    table.PrimaryKey("PK_Menu", x => x.MenuId);
                    table.ForeignKey(
                        name: "FK_Menu_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Submenu",
                columns: table => new
                {
                    SubmenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submenu", x => x.SubmenuId);
                    table.ForeignKey(
                        name: "FK_Submenu_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    MenuItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_MenuItem", x => x.MenuItemId);
                    table.ForeignKey(
                        name: "FK_MenuItem_Submenu_SubMenuId",
                        column: x => x.SubMenuId,
                        principalTable: "Submenu",
                        principalColumn: "SubmenuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedBy", "CreatedDate", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "Name", "SvgUrl" },
                values: new object[,]
                {
                    { new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/04.jpg", null, null, "Pizza", "img/food-delivery/icons/pizza.svg" },
                    { new Guid("ae98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/01.jpg", null, null, "Grills & Steak", "img/food-delivery/icons/steak.svg" },
                    { new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dda"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/04.jpg", null, null, "Mediterranean", "img/food-delivery/icons/pizza.svg" },
                    { new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/01.jpg", null, null, "Chicken & Wings", "img/food-delivery/icons/chicken.svg" },
                    { new Guid("bf3f3002-7e53-441e-8b76-f6280be284aa"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/02.jpg", null, null, "Pasta", "img/food-delivery/icons/noodles.svg" },
                    { new Guid("ce98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/06.jpg", null, null, "Healthy", "img/food-delivery/icons/healthy.svg" },
                    { new Guid("de98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/03.jpg", null, null, "Fish & Seafood", "img/food-delivery/icons/fish.svg" },
                    { new Guid("ea98f549-e710-5e9f-aa15-18c2392a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/05.jpg", null, null, "Indian", "img/food-delivery/icons/coffee.svg" },
                    { new Guid("ee98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/05.jpg", null, null, "Coffee & Desserts", "img/food-delivery/icons/coffee.svg" },
                    { new Guid("ee98f549-e790-5e9f-aa15-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/04.jpg", null, null, "Asian", "img/food-delivery/icons/pizza.svg" },
                    { new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img/food-delivery/category/01.jpg", null, null, "Burgers", "img/food-delivery/icons/burger.svg" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "CategoryId", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "Name", "logoUrl" },
                values: new object[,]
                {
                    { new Guid("1313179f-7837-473a-a4d5-a5571b43e6a6"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dda"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Doppio Zero", null },
                    { new Guid("2313179f-1837-173a-a4d5-a5571b43e6a9"), new Guid("ae98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Mike's Heritage House", null },
                    { new Guid("2313179f-1837-273a-a4d5-a5571b43e6a9"), new Guid("ea98f549-e710-5e9f-aa15-18c2392a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Spiceburg Greenside", null },
                    { new Guid("2313179f-1837-373a-a4d5-a5571b43e6a9"), new Guid("ee98f549-e790-5e9f-aa15-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Miyako Sushi", null },
                    { new Guid("2313179f-1837-473a-a4d1-a5571b43e6a9"), new Guid("ee98f549-e790-5e9f-aa15-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Chop Stix", null },
                    { new Guid("2313179f-1837-473a-a4d5-a5571b43e6a6"), new Guid("ee98f549-e790-5e9f-aa15-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Simply Asia", null },
                    { new Guid("2313179f-1837-473a-a4d5-a5571b43e6a7"), new Guid("ee98f549-e790-5e9f-aa15-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Asian Twist", null },
                    { new Guid("2313179f-1837-473a-a4d5-a5571b43e6a8"), new Guid("ae98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Thunder Gun", null },
                    { new Guid("2313179f-1837-473a-a4d5-a5571b43e6a9"), new Guid("ea98f549-e710-5e9f-aa15-18c2392a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Curry Up", null },
                    { new Guid("2313179f-1837-573a-a4d5-a5571b43e6a9"), new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Topo Gigio", null },
                    { new Guid("2313179f-1837-673a-a4d5-a5571b43e6a9"), new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Satori", null },
                    { new Guid("2313179f-1837-773a-a4d5-a5571b43e6a9"), new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Pizza e Vino", null },
                    { new Guid("2313179f-1837-873a-a4d5-a5571b43e6a9"), new Guid("de98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Jimmy's", null },
                    { new Guid("2313179f-1837-973a-a4d5-a5571b43e6a9"), new Guid("bf3f3002-7e53-441e-8b76-f6280be284aa"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Pasta Worx", null },
                    { new Guid("2313179f-2837-473a-a4d5-a5571b43e6a6"), new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Andiccio24", null },
                    { new Guid("2313179f-3837-473a-a4d5-a5571b43e6a6"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Pedro's Chicken", null },
                    { new Guid("2313179f-4837-473a-a4d5-a5571b43e6a6"), new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Pizza Perfect", null },
                    { new Guid("2313179f-5837-473a-a4d5-a5571b43e6a6"), new Guid("ee98f549-e790-5e9f-aa15-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Pron", null },
                    { new Guid("2313179f-6837-473a-a4d5-a5571b43e6a6"), new Guid("ce98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "The Fussy Vegan", null },
                    { new Guid("2313179f-7837-473a-a4d5-a5571b43e6a1"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dda"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Tei Avon", null },
                    { new Guid("2313179f-7837-473a-a4d5-a5571b43e6a2"), new Guid("ee98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "X&O", null },
                    { new Guid("2313179f-7837-473a-a4d5-a5571b43e6a3"), new Guid("ee98f549-e790-5e9f-aa15-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Hao Ke Lai", null },
                    { new Guid("2313179f-7837-473a-a4d5-a5571b43e6a4"), new Guid("ee98f549-e790-5e9f-aa15-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Momo Baohaus", null },
                    { new Guid("2313179f-7837-473a-a4d5-a5571b43e6a5"), new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "La Padrino", null },
                    { new Guid("2313179f-7837-473a-a4d5-a5571b43e6a6"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Mochachos", null },
                    { new Guid("2313179f-8837-473a-a4d5-a5571b43e6a6"), new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Pizza Baby", null },
                    { new Guid("6313179f-7837-473a-a4d5-b5571b43e6a6"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "KFC", null },
                    { new Guid("6313179f-7837-473a-a4d5-c5571b43e6a6"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Chicken Licken", null },
                    { new Guid("6313179f-7837-473a-a4d5-d5571b43e6a6"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Nandos", null },
                    { new Guid("6313179f-7837-473a-a4d5-e5571b43e6a6"), new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Roman's Pizza", null },
                    { new Guid("6313179f-7837-473a-a4d5-f5571b43e6a6"), new Guid("6313179f-7837-473a-a4d5-a5571b44e6a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Debonair's Pizza", null },
                    { new Guid("6313179f-7837-473a-b4d5-a5571b43e6a6"), new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "McDonald's", null },
                    { new Guid("6313179f-7837-473a-c4d5-a5571b43e6a6"), new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Steers", null },
                    { new Guid("6313179f-7837-473a-d4d5-a5571b43e6a6"), new Guid("de98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Fishaways", null },
                    { new Guid("6313179f-7837-473a-e4d5-a5571b43e6a6"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Kung Fu Chicken", null },
                    { new Guid("6313179f-7837-473a-f4d5-a5571b43e6a6"), new Guid("be98f549-e790-4e9f-aa16-18c2292a2ee9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Galito's", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Menu_RestaurantId",
                table: "Menu",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_SubMenuId",
                table: "MenuItem",
                column: "SubMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_CategoryId",
                table: "Restaurants",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Submenu_MenuId",
                table: "Submenu",
                column: "MenuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItem");

            migrationBuilder.DropTable(
                name: "Submenu");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
