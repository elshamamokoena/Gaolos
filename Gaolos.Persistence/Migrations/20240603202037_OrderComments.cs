using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gaolos.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class OrderComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: new Guid("2afbc152-e4b2-4c08-a3e8-9e3211c67b41"));

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: new Guid("327bbc2a-e99d-474a-ad86-e3dde176c3f7"));

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: new Guid("b87bd520-edcf-4240-90db-95ca87e16c54"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0247e3b3-fe42-49d8-a863-723a88c7154a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0286643e-8dc0-4515-98de-a88b093fe818"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("04e9cf37-f542-4c3a-9d12-dbeccfdadd86"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("09305997-0177-41e7-ba03-4b1bc86442bd"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0bacb4d1-8a47-4358-b5b7-1352add99924"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0d48707a-6256-4430-8610-be6a00267da7"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0e03179e-ec52-4420-89e1-b4840b2e5202"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("112e81b4-c574-4442-892c-95da93fdfe5d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("13153eb1-f78d-4e7a-b388-b733ceddb051"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("13645000-1437-4fff-a88a-254eb2b6c2e1"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1411656c-94cf-4ab7-876e-c86202d83bfd"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("154422c5-dff8-409a-b189-027c815eb2c8"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1a034165-1bbb-4338-be50-354cd59ea1ff"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1b0d0769-69a4-49d4-b02b-cec635e0bdfb"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1d98393a-05e4-4483-acb4-314c63ed52cd"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1e178aee-cbe8-4a7b-acd6-0d67bf43cee5"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1fa45802-11f9-4df7-8359-7211cb391b2c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("210421fd-217c-4e74-b96e-73d4d7738883"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("21865590-96a4-4686-b30c-e9f11b688df9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("21dda534-89d9-437c-9f6b-7f6c9a00e2d9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2259d288-b2fd-46a1-a58e-1aa8b8042e68"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("23838f86-6c39-4777-b468-13edd25e3335"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("273f9cf2-0d48-4261-beae-dc0b30224de5"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2850c91a-e5b1-4cd9-92f7-46347e5ce401"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("28f0f5d1-91a7-4b13-82bc-67c446e0ac6a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("29243265-6ce1-4310-aa6c-42abafd56204"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2acf6fba-3891-4108-8dbf-fad5d543d1da"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2cc834e5-003d-49be-b29e-1be844ad7dc0"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2d01a444-577a-4ed4-8608-1d9c91db04e3"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2ee24eb1-6a64-4caf-819d-f3cd746e4a88"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2f79f60e-2118-4cdb-973a-54e970324070"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3304d555-18ca-4041-b1c8-4a24c282e4a5"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("379aa7c0-4964-4d1f-8fdd-3f3192141eec"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("37d3a78f-5b8b-4c1c-a1b6-de6a3a7fc083"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("38a9ec26-7503-4c8d-8d00-2a8f97fcc19f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("392bb106-bf64-49be-80b2-a65d9b7adaa8"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3bc09da6-0b8e-4077-b79f-d3930f5edfc0"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3dc10b63-0658-4f04-a035-b27110731fd1"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3dd23154-4f97-449d-bb88-a2f36f34b42b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3e4a769d-b1d0-40f6-b2ab-89cd0bce9866"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3efae7bf-7668-4e2b-98df-9d64bbc0622e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3f602136-bf5c-41be-a090-a4ee60cb069c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("440f7220-0e67-4925-8110-d28404ccf61f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("455b49c1-b2eb-45bd-9f7f-7668b9940d52"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("467a44a6-9aa3-4456-8fb8-837edde09854"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("491366c4-5748-4afd-81ab-1abcc7622f40"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("49f34a14-dc0a-49ff-b633-0f1e801c4497"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4d3804a7-f0b8-42a5-a596-606151c319fd"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4e6d5cc2-e737-49a2-991c-7e93f2af824e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4ec7c3c4-02d3-44ca-bb14-69a13bb84ec1"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("505456e6-04e0-4143-aa88-2b1c9b4dec0e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5467b379-c517-4c8c-b448-530c2bda9926"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5644c3fb-659a-4ec5-8b05-6933e612a9dc"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5a9b51ed-11e3-49f2-8fc1-6544b4284ca5"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5b5c8a1a-2549-4d92-843c-6ff3ca5191bf"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5bb4f358-1878-48fa-b455-d52a85c7302b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5c95a096-f542-47be-8b82-fa4dbcb27d31"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5dcc6dc9-ed11-4798-a80c-b2a414c06fed"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5e76d819-251e-43d5-a0c2-dcf034aab3b2"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("63a71cfa-d493-4f96-a621-ca00ddd68bfb"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("664bfe90-7f9b-48b5-a7ab-5e949e9a7d52"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("6859b58a-d7ab-45c9-9d40-864ad1292706"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("69a573d4-b453-493d-875f-4d7ae3d47a54"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("6c532763-bea9-4bf1-850a-980a81f43979"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("6f006dda-28f7-4665-9963-a0ced843ec3c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("70b4de48-1036-41a5-b153-162d5151fcfa"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7224f4f0-2707-45d3-a6cd-6e9319746262"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("74bc3fc1-4717-42d3-9fed-2f2bfcd03e40"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7554bab4-56ad-4b6b-90b7-ea8d822f1a73"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("775b9142-227a-4d78-a0aa-bce7c1410d28"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("795a38a2-6288-4a2d-83fa-990e366da095"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7a2c8a96-0d0a-48ef-a84e-9b9782f1d17e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("87c8e714-f26f-4c2e-a883-9b29db665601"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("88f4f718-61c9-4957-a310-e4af6d7fe62a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8ec62b04-d8ea-418e-b640-ffa6871cb451"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8fa5d297-6547-4648-9d14-8a5a1ece3df1"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8ff77ae1-efe4-434a-ab0a-c5a25ddf9365"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("90e63ff7-bf33-42ac-b666-34a353d4c6fe"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("9260c506-9932-4af8-8ab2-680a10ceee44"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("93c84859-6969-4fa1-ad0e-3dbff0d39567"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("9455e1c6-be3e-4ac2-b5be-d27f64239f8e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("9479e26f-d2b5-49fd-a9a7-cf45b2c12ad9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("9524ea8e-beac-4e99-bf8d-ace72944b6c6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("99f5a6e0-28cb-4f89-97cc-4da1fefd005a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a04d1358-1ed2-42fa-b9dc-8e6007692642"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a0953255-bc9e-4805-9a94-eca614764b5f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a6eda0d0-f6fb-424c-a49a-fd1fb9d2ac4d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a78b6ebf-c647-445b-bbf8-ac492a3a13e0"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b076883f-cc58-43ba-9d86-9aba1a070204"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b0a2aae6-2803-4d35-89ce-cba0361ee394"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b7b2c9b8-1623-46bb-a547-05861f32d860"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b9557427-6f82-49fd-bbb6-24a854aa156f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c0044d94-f0fd-4d5b-a0fa-d6bb94a13ea3"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c04f15f8-c0be-4cbf-88fd-3554a1a8a02d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c14c8fb0-57d5-4043-93dd-1e229865b578"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c1e9487f-8eb4-4c4b-a4d1-cee6ad2691fb"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c681124d-b05c-48d4-972d-b96a6b014813"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c94f6ba1-fde2-42d4-b5f6-83f216004bac"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c9eb8c19-87b3-49c8-9f52-ac3a72dc9772"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("cdb05fa1-9848-42bf-8038-e277b3821768"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ce0db374-7a99-4c1b-bd20-38daae6b243a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ce43fcde-a9c4-46db-864a-19e2107ef936"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d23ae495-38bb-4890-b157-4d4c602413bd"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d9147e67-5f01-4c57-b2d3-ffb43278cf91"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("da861254-b881-4447-8496-048ef306386e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("dc1747fb-b263-4ee9-907b-1c38d4c99045"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e01fafdf-fb41-4f0a-a4e0-5687a28bf441"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e1b250f0-0507-4c5e-8c22-c386fdfef42a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e277292a-e320-40c3-bbd7-8e3445ecc3c4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e433aa34-3fae-426f-95e1-7ea1d8846f00"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e44d02d6-3946-45c6-8081-31267caf12a8"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e621bbe4-8034-401c-bc0b-660554870846"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e71d5f77-e985-44d0-bd30-2025a6f20aa7"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e7720612-e6f8-426d-ab2e-3718a9ba592e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e788a0df-73f0-4910-b42b-7b653d1687a3"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("eafe1383-75ec-45d0-ae8a-fd5a020f79aa"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ec7b1bf1-c972-4ab5-8e56-b36294b93cb7"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ed20bf1c-e1e3-4780-bdf1-b2871f9dab98"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("efb81fc3-21f5-4abd-8a0f-f00035ae4c0c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f25d2992-a308-47e5-ae84-62e9b1538aa6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f31c40e5-c0c5-4d8e-aaa2-23bfd3b37156"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f817e76a-eabb-4132-b743-64b6700b8ee4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f9c537f4-1ae2-4f58-9ead-37eabae42304"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("fb3cc5f4-a074-4d2a-bf9d-96359d37dfa7"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("fb8be3b9-fd0c-4fa1-ade8-daf14022bd11"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("fbe92a1d-747a-41b9-9cc8-2e9ad4fc573a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("fdc446f9-2d05-4407-8f2c-14418a57afcf"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("fdc6115f-5883-48bd-81b4-db27adf496f4"));

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "CouponId", "AlreadyUsed", "Code", "CreatedBy", "CreatedDate", "Discount", "LastModifiedBy", "LastModifiedDate" },
                values: new object[,]
                {
                    { new Guid("0985e612-3670-4063-b606-98e6a98f55fd"), false, "Awesome", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, null, null },
                    { new Guid("8ee2cafe-3cc3-47ad-8bac-3a7b3ffa8b73"), false, "AlmostFree", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, null, null },
                    { new Guid("c9eb7763-e297-4b0e-9923-ddb291b64d48"), false, "BeNice", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, null, null }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemId", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "MenuId", "Name", "Price", "SubmenuId" },
                values: new object[,]
                {
                    { new Guid("0079e925-4e6d-422e-952e-b5af391a7fd8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of creamy mash and our delicious gravy.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Large Mash & Gravy", 27.90m, null },
                    { new Guid("0215a35a-99b3-4d9d-963c-dc6c2bc03fc6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/12_love-me-hot-cheese-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Hot Cheese Burger", 40.00m, null },
                    { new Guid("0230824d-fc03-41e4-abad-83973e1d6ed1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/36_1-slyder-cheese.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Slyder", 16.00m, null },
                    { new Guid("0235bdb1-3b6f-4af6-845a-5bfdf86b3c0b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Lunch Meal Max", 76.00m, null },
                    { new Guid("0308e5dd-0f92-44f7-9285-cfabb833559d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/22_soulman-load-up.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soulman Load Up", 80.00m, null },
                    { new Guid("03883249-3bab-4162-9b40-82a12c84c98a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Nuggets, 1 Crunch Burger, 1 Small Chips and a Buddy Drink", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Nugget Box Buddy Meal", 79.90m, null },
                    { new Guid("0533bb0a-4c44-4b0c-94cd-0fa49614107d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke 1.5 Litre Bottle", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke 1.5 Litre Bottle", 32.90m, null },
                    { new Guid("056e7a3c-3c77-4f76-bdda-3683cbcdd4c1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Lunch Meal", 73.00m, null },
                    { new Guid("07af8c76-cbd2-4e74-a689-0f36b9d6f73c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around a delicious fillet zinger recipe - a slice of cheese, hash brown, crisp lettuce, fresh tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Zinger Boxmaster", 76.90m, null },
                    { new Guid("1254f13a-dab4-4265-91a0-2974f5824430"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of creamy mash and our delicious gravy.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Mash & Gravy", 19.90m, null },
                    { new Guid("13b87f79-f36d-4352-936d-567a30efe924"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke No Sugar 1.5 Litre", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke No Sugar 1.5 Litre", 29.90m, null },
                    { new Guid("1490dd52-6737-446a-ba3c-2b3373d6cdbb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/32_love-me-hot-cheese-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Hot", 72.00m, null },
                    { new Guid("14ca04b5-84a1-4cdf-9455-1663e66f0a04"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/33_1-slyder-original.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Slyder", 14.00m, null },
                    { new Guid("164b47cc-0c6e-485d-ac14-253db512378a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy a delicious Crunch Burger an orginal receipe chicken piece with small chips and a buddy no sugar drink", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Crunch Burger Box Buddy", 71.90m, null },
                    { new Guid("1895062e-e460-4591-a342-68aa5fa4037f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "6 Hotwings", 42.00m, null },
                    { new Guid("18c58add-f4ea-4dd2-a485-8c488f14b7e8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/47_soul-mix-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Soul Mix Snack", 30.00m, null },
                    { new Guid("1a5116de-7dbd-4725-ab51-39a2717b2629"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oven baked, fresh mini loaf", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Mini Loaf", 14.90m, null },
                    { new Guid("1ae8c6a5-d3f4-454b-bcc9-049f643b512c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chocolate Milkshake", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Chocolate Milkshake", 31.90m, null },
                    { new Guid("1e7adf52-6227-42ed-9eb4-c653aab369b0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/13_big-john-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Big John", 42.00m, null },
                    { new Guid("1f648b92-cc45-4c6c-bf6a-44a5614ef644"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 pieces of crispy, delicious golden brown Nuggets, paired with 1 delicious Colonel dipping sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "9Pc Nuggets", 42.90m, null },
                    { new Guid("20f38b7c-79f8-4b3e-82b3-3587fa2d4e29"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 KFC famous Zinger Wings dunked in a delicious honey, ginger and soy sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "10 Dunked Wings", 104.90m, null },
                    { new Guid("2165feab-89ba-40a2-ace0-2929b1dc5e8b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pulled Chicken Wraps (cut into 6), 3 Chicken Wraps (cut into 6), 2 Sharing Wedges, 16 Winglets, 2 Flame-grilled Mielies cut into 3 (6 portions). Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/ccc05d6a-734b-4fec-bbc7-50a7da7ad2da", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Hands-on delicious platter", 640.00m, null },
                    { new Guid("21c57e0c-d8ae-43d2-8a88-ea17c73a17eb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca-Cola Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coca-Cola Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("225277b8-f727-42e1-b8d1-034ff0894686"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/9_love-me-tender-cheese-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Tender Cheese Burger", 40.00m, null },
                    { new Guid("24bcba9b-d2bd-4865-91ed-241d6e832b7e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new standard in burgers! 2 Spicy, crunchy mini fillets with 2 cheese slices, lettuce & tomato covered in tangy dressing on a burger bun", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Double Crunch Burger", 68.90m, null },
                    { new Guid("27976634-cda7-47f4-bfce-784882525da4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Pieces of original recipe chicken cooked to golden perfection and a regular portion of pap & small gravy.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Two with Pap", 49.90m, null },
                    { new Guid("280050a2-b359-4906-b7c4-938553460c6d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/23_soul-mates-classic-party.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soul Mates Classic Party", 145.00m, null },
                    { new Guid("2aa9f87a-843a-4831-affb-761ea9ccad09"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Large Chips", 0m, null },
                    { new Guid("2dddac38-ef7c-4cd7-9e96-420f9289db81"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wrapsta, 1 Piece of Original Recipe Chicken, Small Chips & Buddy Drink", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Wrapsta Box Meal", 84.90m, null },
                    { new Guid("303e2c71-75cc-495f-9f40-0a8e9e79ad57"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/10_love-me-hot-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Hot", 37.00m, null },
                    { new Guid("3534efd1-3f74-4dd7-8372-31c87ddafe2c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/25_family-full-house-circle8ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Family Full House", 173.00m, null },
                    { new Guid("37c912b6-a4e4-4dcf-8937-e5e301b58e52"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Hotwings Meal", 86.00m, null },
                    { new Guid("3818e430-f928-4fc3-a1d3-8b586b9dc602"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken that are tender on the inside and crunchy on the outside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Small Pops", 29.90m, null },
                    { new Guid("3c1906a4-5518-43e8-9f71-8be8d085ea7e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/29_love-me-tender-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Tender", 70.00m, null },
                    { new Guid("3ce27cd1-069e-42c2-b4b5-eaa859e47752"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/31_love-me-hot-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Hot", 70.00m, null },
                    { new Guid("3d01b18c-5df2-40bf-98da-8e68e185924e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "12 Hotwings", 84.00m, null },
                    { new Guid("3e4e2045-1e16-479d-991c-bf096cc80b70"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/55_just-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 2", 39.00m, null },
                    { new Guid("3ea70a58-0f9a-4175-90f2-9b41a07c8fbf"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 Pieces of Original Recipe chicken cooked to golden perfection and a large portion of chips or coleslaw.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Five", 121.90m, null },
                    { new Guid("3f912a7d-d3c2-4e23-9b19-7625bafcd872"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "4 Zinger Wings", 48.90m, null },
                    { new Guid("400fa591-047e-4f11-ba0f-b5b947b892de"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/44_slyder-snack-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Slyder Snack", 30.00m, null },
                    { new Guid("41250542-5e81-45e5-a9bf-bfb38b413c2e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A spicy, crunchy mini fillet with a slice of cheese and lettuce, covered in tangy dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Crunch Burger", 36.90m, null },
                    { new Guid("426f6e2f-c453-4684-bb85-30170f148d97"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy 6 pieces of delicious original recipe chicken, 1 large chips, 1 regular coleslaw plus 2 regular mash and gravies.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "All In One Feast", 194.90m, null },
                    { new Guid("43fe7f73-72d6-45dd-ad4b-19ffc092f9ea"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/49_soulsister-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister", 43.00m, null },
                    { new Guid("44464ecb-0f1e-4569-a27f-1f1f4eec1671"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "24 Zinger Wings Bucket", 194.90m, null },
                    { new Guid("44faaec1-00db-44e8-8a70-107756ec3665"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An icy sippable treat with Berry bitz, and creamy soft-serve.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Verry Berry Krusher", 42.90m, null },
                    { new Guid("46859dfa-a4cb-4900-bc33-c7ac0685d071"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Small Chips", 16.90m, null },
                    { new Guid("4692a810-5076-4d5a-bfe3-cf317f0afc43"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken that are tender on the inside and crunchy on the outside. Served with a generous sprinkle of fruit chutney flavour.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Sprinkle Pops", 54.90m, null },
                    { new Guid("4ad1d33b-b912-4648-a924-2f6fcd697d64"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy 4 pieces of original recipe chicken, 2 small chips, 1 small pops & 2 buddy no sugar drinks.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "2 Can Dine Buddy", 164.90m, null },
                    { new Guid("4e920b30-081c-4c78-a9ae-96867f3a5ace"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "One and a 1/2 full chickens ( cut into 12), 2 Flame-grilled Mielies cut into 3 (6 portions), 4 Kids Burgers, 2 Sharing Wedges. Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/5182f543-741a-4317-a731-e8098a228c37", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "More to share platter", 640.00m, null },
                    { new Guid("522be571-3be3-4837-8bec-aa2ce8d39ef4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new Burger standard…Boxed! The new Colonel burger, 1 piece of original recipe chicken, regular mash & gravy, chips & a buddy no sugar drink.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Fully Loaded Box Meal", 115.90m, null },
                    { new Guid("5352771e-ccbb-4d31-b837-3344b0cf3252"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "24 Zinger Wings Bucket", 194.90m, null },
                    { new Guid("55785b38-8728-4d4c-a632-f44f39f33950"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A generous sharing platter of 4 succulent Flame-grilled Shisanyama Chicken Sosaties and 20 Winglets, served with 2 portions of our Sharing Wedges, 2 Garlic Rolls and our special PERinase dip.", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/3d93a55d-440a-407c-8b7b-97cc1e6c510a", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Cabo Sosatie Snack Platter", 349.00m, null },
                    { new Guid("55ec087c-af85-4520-b62f-3ef473b4cc38"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs and spices of Original Recipe® chicken, marinated and cooked to perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1"), "9 Piece Bucket", 182.90m, null },
                    { new Guid("58c56959-3aab-479a-a763-a3a73946f0cd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around 2 deliciously crispy new and improved chicken strips, shredded crisp lettuce, sliced tomato, topped with Colonel dressing and sweet chilli sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Sweet Chilli Twister", 66.90m, null },
                    { new Guid("5cfb949a-e383-4b20-b555-d55d396b592d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/16_hotwings-circle6ce-max.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Max", 69.00m, null },
                    { new Guid("5d534710-fa87-435e-a9ca-7395bcaa97ff"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/51_soulsister-circle2ce-max.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Max", 65.00m, null },
                    { new Guid("5e55fa22-f206-4366-8a1b-e3072a32d9bb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An icy sippable treat with Oreo bitz, and creamy soft-serve.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Oreo Krusher", 42.90m, null },
                    { new Guid("62af7dae-5761-444c-8062-e74cff04bd0f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Pieces of Original Recipe Chicken and Small Chips or Coleslaw.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Two with Chips", 49.90m, null },
                    { new Guid("62dda5a6-45c5-4370-96b2-f6358262a1bf"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/129_soulsister-2-vibe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Vibe", 40.00m, null },
                    { new Guid("63604835-8680-4f4f-953c-d28267820dc7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The game changer is here, and with a delicious spicy crunch fillet, tomato, lettuce and cheese with tangy dressing all wrapped up in a mini tortilla and grilled to perfection, meal time will never be the same again.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Wrapsta", 42.90m, null },
                    { new Guid("650dde64-3612-44e1-8a6a-c38b08660917"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/50_soulsister-circle2ce-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Deluxe", 62.00m, null },
                    { new Guid("68aec1c6-07d6-4145-8b38-bc3055753c81"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/62_family-barrel-circle21ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Family Barrel", 300.00m, null },
                    { new Guid("6a18cbfd-8d48-438a-b8b5-b76d01d0b35a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces of crispy, delicious golden brown Nuggets, paired with 1 delicious Colonel dipping sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "6Pc Nuggets", 36.90m, null },
                    { new Guid("6b847f03-6035-4232-b4d4-fab5ed56cdd9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new Burger standard…Boxed! The Crispy Zinger burger, 1 piece of original recipe chicken, regular mash & gravy, chips & Buddy no sugar.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Zinger Fully Loaded Buddy Box Meal", 115.90m, null },
                    { new Guid("6bd3641b-5a17-42c5-b06d-410f10f6c0ac"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "24 Hotwings", 168.00m, null },
                    { new Guid("6bf01073-d623-445f-bcd4-7a992cf8d6d6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/28_big-john-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Big John", 72.00m, null },
                    { new Guid("746527da-8f9e-4cbd-8fce-6cccc4a6a2ce"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/24_family-full-house-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Family Full House", 143.00m, null },
                    { new Guid("7655f41d-8ede-48df-bdd8-df5afba4c077"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Cappy Juice 1.5 Litre", 44.90m, null },
                    { new Guid("767ed313-5617-494c-8f28-62467486f679"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Chips", 26.90m, null },
                    { new Guid("77176bad-7238-49b6-8eed-417b0329678b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/54_just-circle1ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 1", 20.00m, null },
                    { new Guid("773b6e71-2492-41b9-80ef-2be8c865efdf"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pieces of original recipe chicken, a portion of small chips.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Three with Chips", 72.90m, null },
                    { new Guid("7d86862b-ef8c-4f79-96b6-67f90468a0b3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/45_popcorn-chicken-shaker.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Popcorn Chicken Shaker", 30.00m, null },
                    { new Guid("7e0a1a7c-f47b-4ed2-932a-df8d1045a068"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul 3 Straight", 57.00m, null },
                    { new Guid("7ef44a91-f65d-475a-821e-010c29789628"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A delicious chicken patty served with shredded lettuce & Colonel dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Snack Burger", 29.90m, null },
                    { new Guid("7f786963-8bc6-4569-8d88-81a2dc18bebf"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/39_1-slyder-chilli.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Slyder", 14.00m, null },
                    { new Guid("804713ee-369b-4ac7-979b-9a6188c64383"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/21_rock-my-soul-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul", 105.00m, null },
                    { new Guid("81e7be69-f693-4f1d-9295-085abe90a5ed"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/7_love-me-tender-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Tender", 37.00m, null },
                    { new Guid("831c2f8e-53b9-49c8-ac21-a4d14e1a5ada"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/34_2-slyders-original.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "2 Slyders", 27.00m, null },
                    { new Guid("85eeed0a-df43-482c-bd66-44c9e3dbd2f7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/59_just-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 6", 120.00m, null },
                    { new Guid("8758881d-f28f-4122-98f0-fe53a8807d9d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bonaqua Still Spring Water 500ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Bonaqua Still Spring Water 500ml", 19.90m, null },
                    { new Guid("8a55df9f-e715-46e2-a461-613ed1d38931"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy KFC`s new Jalapeno loaded fries with brand new Hot * spicy sauce", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Jalapeno Loaded Fries", 32.90m, null },
                    { new Guid("8cc0e7b4-9ff8-43a1-8c12-b9e072f58b86"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul 3 Combo", 60.00m, null },
                    { new Guid("951c56b7-8f2d-4fce-9d40-bb7961f7adc0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8pc Chicken, 2 snack burgers, 4 Zinger Wings, 2 Reg Coleslaw, 2 Reg chips", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "8 Piece Family Treat", 274.90m, null },
                    { new Guid("9718f1a5-8601-4e4c-a7aa-f0379d78d48a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/18_feed-my-craving-circle10ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Feed My Craving", 79.00m, null },
                    { new Guid("9a0fd440-95c4-44b0-abb4-5bb1a1f34f46"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/15_hotwings-circle6ce-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Deluxe", 67.00m, null },
                    { new Guid("a17eaef1-11ae-4ef0-b85a-fc2d502f4a59"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/58_just-circle5ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 5", 99.00m, null },
                    { new Guid("a2a99af9-7509-40b8-8014-cc39d3c88b05"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Veg Burgers, 2 Halloumi & Roast Veg Wraps, 2 Halloumi & Roast Veg Pitas, 2 Sharing Wedges, 4 Flame-grilled Mielies cut into 3 (12 portions). Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/3b7bc5aa-eb6c-4f3b-a289-ae9669f410dd", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Veggie veggie nice platter", 640.00m, null },
                    { new Guid("a65e9964-d601-41e0-8d98-8b732b3a2211"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A delicious chicken patty served with shredded lettuce & Colonel dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Snack Burger", 29.90m, null },
                    { new Guid("a8ba564e-960d-4aae-8013-7df997d84bfb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half Platter", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/f93c9cbe-5f94-4bb4-a937-811c28bd88df", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Big on veg platter", 640.00m, null },
                    { new Guid("aa105b4e-88cb-452c-97f7-a72986f90e14"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/46_hotwings-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Hotwings Snack", 30.00m, null },
                    { new Guid("ad55184b-c876-4ed2-8f84-79bc53d822d6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Two full chickens (cut into 16), 16 Winglets, 2 Flame-grilled Mielies cut into 3 (6 portions), 2 Sharing Wedges. Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/fa60cb07-3c21-4718-8f02-cb91fd83319b", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Peri-er Platter", 640.00m, null },
                    { new Guid("add9d4ce-c798-4c21-9fa4-855c1e2cf435"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get yourself a Streetwise 1, with a Buddy no sugar free drink", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Streetwise 1 Buddy", 52.90m, null },
                    { new Guid("b0c7d44c-616c-4332-a27e-ac8173a2bf40"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/124_soulbites-circle9ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a9"), "Soul Bites Max", 45.00m, null },
                    { new Guid("b353d52e-af10-4607-8cd6-c02641dcf5a5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/52_soulsister-party-circle4ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Party", 84.00m, null },
                    { new Guid("b4d0319b-ea9a-4a35-b3cc-12c0b25286f0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Try the new standard! The New Colonel burger, Our trademark real chicken fillet; A fresh Brioche bun, Creamy Colonel sauce and cheese on a fresh bed of lettuce & succulent tomatoes", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Colonel Burger", 60.90m, null },
                    { new Guid("b5ad60b0-9ae8-4419-b77e-eed90bca74e3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/125_soulbites-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Soul Bites Snack", 30.00m, null },
                    { new Guid("b68031f6-6ede-486e-a7eb-ca6391003b0d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken dunked in KFC’s famous honey, ginger and soy sauce!", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Dunked Pops", 36.90m, null },
                    { new Guid("b88815ea-4360-468c-92f0-2eb9dcfb1755"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10pc Chicken, 2 snack burgers, 4 Zinger Wings, 2 Reg Coleslaw, 2 Reg chips", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "10 Piece Family Treat", 316.90m, null },
                    { new Guid("bb29f930-9f1c-4f1d-9ad4-dec056a7d36c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/53_soulsister-party-circle5ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Party", 112.00m, null },
                    { new Guid("bcb42f38-8624-464f-8019-8a7b9fde109c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/57_just-circle4ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 4", 80.00m, null },
                    { new Guid("bd632613-e7a9-4879-881a-4af2fffb78de"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get yourself a Streetwise 5, with 2 Buddy No Sugar", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Streetwise 5 Buddy", 143.90m, null },
                    { new Guid("bffe58df-b6c1-4174-8dca-77f8ec94d5ee"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crunch Burger, 1 Piece of Original Recipe Chicken, 2 Zinger Wings, Small Chips & Buddy Drink", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "All Star Box Meal Buddy", 94.90m, null },
                    { new Guid("c3cd7f2a-ff8a-41b1-ae95-150c7c8ec2cf"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Hotwings Meal Max", 90.00m, null },
                    { new Guid("c403583f-c1c9-46e1-aab8-9b79c9a8bc33"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/17_hotwings-party-circle16ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Party", 132.00m, null },
                    { new Guid("c498d2e1-3149-4cdf-8d25-627fee492f91"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs & spices.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1"), "15 Piece Bucket", 279.90m, null },
                    { new Guid("c6d05247-eb51-4143-99bd-1e2dd3fb701e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 Piece Chicken", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "1 Piece Chicken", 26.90m, null },
                    { new Guid("c6d5d1ad-861c-4a81-a2f6-5438ee8709c3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprite Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Sprite Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("c79631b2-0d89-4159-9471-34e0965cb9f4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken, tender on the inside and crunchy on the outside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Large Pops", 54.90m, null },
                    { new Guid("ca50b83e-4989-420a-929d-7f05adfa0998"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around a delicious fillet original recipe - a slice of cheese, hash brown, crisp lettuce, fresh tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Colonel Boxmaster", 76.90m, null },
                    { new Guid("caf96148-401f-454e-b9e0-72a1d2f52e43"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/60_chicken-inn-circle9ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Chicken Inn", 150.00m, null },
                    { new Guid("cc5d333f-9a49-4cb5-a1bd-bf03d5072855"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 KFC famous Zinger Wings dunked in a delicious honey, ginger and soy sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "4 Dunked Wings", 54.90m, null },
                    { new Guid("ccb8172c-48ed-4641-a5d0-029eefd44b95"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fanta Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Fanta Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("d463663c-7c65-429c-8553-fc0b860111a1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/56_just-circle3ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 3", 60.00m, null },
                    { new Guid("d548080f-7953-4623-bbae-1f2141ccea19"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "36 Hotwings", 231.00m, null },
                    { new Guid("d627ec45-c9c7-42b8-9a63-a61631dd2e8e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "10 Hot Zinger Wings", 89.90m, null },
                    { new Guid("d9b6c19f-1ecb-4bcf-ac63-6fc5c7f62ad6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Soul", 50.00m, null },
                    { new Guid("def4a316-1241-4244-8a69-f8507e29b6ee"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/61_family-bucket-circle15ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Family Bucket", 230.00m, null },
                    { new Guid("e02b40eb-f85c-4af3-84b0-4a2e62c8c155"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy a piece of original recipe chicken, 2 zinger wings and a small scrumptious chips.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Bucket For One", 46.90m, null },
                    { new Guid("e044582a-c8f8-4cc4-b135-5e39f5f4b64f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/30_love-me-tender-cheese-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Tender", 72.00m, null },
                    { new Guid("e09aa359-6cad-4fdc-9bef-33837b6dde98"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milk shake milk shake shake shake", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Strawberry Milkshake", 31.90m, null },
                    { new Guid("e752ce3d-c979-4925-bc87-2a0ca1c67336"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soul Square Meal", 50.00m, null },
                    { new Guid("e7a6b421-6568-4363-a0d3-7776ca7364c2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extra Hot & Spicy Zinger sauce on the side", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Sauce - Hot & Spicy", 0m, null },
                    { new Guid("ea117ce4-5eca-4f22-a12e-513433a99380"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/123_soulbites-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a9"), "Soul Bites", 38.00m, null },
                    { new Guid("ee272664-06d3-46b7-bfc6-4d5818286a9b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of freshly prepared cabbage, onions and carrots in a delicious dressing", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Coleslaw", 24.90m, null },
                    { new Guid("f5ea883f-b816-44d6-b9ff-fbfde4dfa801"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Try the new standard! The New Crispy Zinger burger, Our trademark real chicken fillet; A fresh Brioche bun, New Hot & Spicy sauce and cheese on a fresh bed of lettuce & succulent tomatoes", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Zinger Burger", 60.90m, null },
                    { new Guid("f85c0fc7-9fa2-4310-b193-3b2d0befa85b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke No Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke No Sugar Buddy 440ml", 22.90m, null },
                    { new Guid("f8e5f58e-7f90-49c6-a4ae-026d717fd5ff"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around 2 deliciously crispy chicken strips, shredded crisp lettuce, sliced tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Classic Twister", 66.90m, null },
                    { new Guid("fb24d8e8-381b-47d2-b612-a5770ff6e0bf"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pieces of Original Recipe Chicken with a portion of pap and gravy", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Three with Pap", 72.90m, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: new Guid("0985e612-3670-4063-b606-98e6a98f55fd"));

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: new Guid("8ee2cafe-3cc3-47ad-8bac-3a7b3ffa8b73"));

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: new Guid("c9eb7763-e297-4b0e-9923-ddb291b64d48"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0079e925-4e6d-422e-952e-b5af391a7fd8"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0215a35a-99b3-4d9d-963c-dc6c2bc03fc6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0230824d-fc03-41e4-abad-83973e1d6ed1"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0235bdb1-3b6f-4af6-845a-5bfdf86b3c0b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0308e5dd-0f92-44f7-9285-cfabb833559d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("03883249-3bab-4162-9b40-82a12c84c98a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0533bb0a-4c44-4b0c-94cd-0fa49614107d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("056e7a3c-3c77-4f76-bdda-3683cbcdd4c1"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("07af8c76-cbd2-4e74-a689-0f36b9d6f73c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1254f13a-dab4-4265-91a0-2974f5824430"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("13b87f79-f36d-4352-936d-567a30efe924"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1490dd52-6737-446a-ba3c-2b3373d6cdbb"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("14ca04b5-84a1-4cdf-9455-1663e66f0a04"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("164b47cc-0c6e-485d-ac14-253db512378a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1895062e-e460-4591-a342-68aa5fa4037f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("18c58add-f4ea-4dd2-a485-8c488f14b7e8"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1a5116de-7dbd-4725-ab51-39a2717b2629"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1ae8c6a5-d3f4-454b-bcc9-049f643b512c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1e7adf52-6227-42ed-9eb4-c653aab369b0"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1f648b92-cc45-4c6c-bf6a-44a5614ef644"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("20f38b7c-79f8-4b3e-82b3-3587fa2d4e29"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2165feab-89ba-40a2-ace0-2929b1dc5e8b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("21c57e0c-d8ae-43d2-8a88-ea17c73a17eb"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("225277b8-f727-42e1-b8d1-034ff0894686"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("24bcba9b-d2bd-4865-91ed-241d6e832b7e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("27976634-cda7-47f4-bfce-784882525da4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("280050a2-b359-4906-b7c4-938553460c6d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2aa9f87a-843a-4831-affb-761ea9ccad09"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2dddac38-ef7c-4cd7-9e96-420f9289db81"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("303e2c71-75cc-495f-9f40-0a8e9e79ad57"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3534efd1-3f74-4dd7-8372-31c87ddafe2c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("37c912b6-a4e4-4dcf-8937-e5e301b58e52"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3818e430-f928-4fc3-a1d3-8b586b9dc602"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3c1906a4-5518-43e8-9f71-8be8d085ea7e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3ce27cd1-069e-42c2-b4b5-eaa859e47752"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3d01b18c-5df2-40bf-98da-8e68e185924e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3e4e2045-1e16-479d-991c-bf096cc80b70"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3ea70a58-0f9a-4175-90f2-9b41a07c8fbf"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3f912a7d-d3c2-4e23-9b19-7625bafcd872"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("400fa591-047e-4f11-ba0f-b5b947b892de"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("41250542-5e81-45e5-a9bf-bfb38b413c2e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("426f6e2f-c453-4684-bb85-30170f148d97"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("43fe7f73-72d6-45dd-ad4b-19ffc092f9ea"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("44464ecb-0f1e-4569-a27f-1f1f4eec1671"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("44faaec1-00db-44e8-8a70-107756ec3665"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("46859dfa-a4cb-4900-bc33-c7ac0685d071"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4692a810-5076-4d5a-bfe3-cf317f0afc43"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4ad1d33b-b912-4648-a924-2f6fcd697d64"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4e920b30-081c-4c78-a9ae-96867f3a5ace"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("522be571-3be3-4837-8bec-aa2ce8d39ef4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5352771e-ccbb-4d31-b837-3344b0cf3252"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("55785b38-8728-4d4c-a632-f44f39f33950"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("55ec087c-af85-4520-b62f-3ef473b4cc38"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("58c56959-3aab-479a-a763-a3a73946f0cd"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5cfb949a-e383-4b20-b555-d55d396b592d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5d534710-fa87-435e-a9ca-7395bcaa97ff"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5e55fa22-f206-4366-8a1b-e3072a32d9bb"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("62af7dae-5761-444c-8062-e74cff04bd0f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("62dda5a6-45c5-4370-96b2-f6358262a1bf"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("63604835-8680-4f4f-953c-d28267820dc7"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("650dde64-3612-44e1-8a6a-c38b08660917"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("68aec1c6-07d6-4145-8b38-bc3055753c81"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("6a18cbfd-8d48-438a-b8b5-b76d01d0b35a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("6b847f03-6035-4232-b4d4-fab5ed56cdd9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("6bd3641b-5a17-42c5-b06d-410f10f6c0ac"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("6bf01073-d623-445f-bcd4-7a992cf8d6d6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("746527da-8f9e-4cbd-8fce-6cccc4a6a2ce"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7655f41d-8ede-48df-bdd8-df5afba4c077"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("767ed313-5617-494c-8f28-62467486f679"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("77176bad-7238-49b6-8eed-417b0329678b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("773b6e71-2492-41b9-80ef-2be8c865efdf"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7d86862b-ef8c-4f79-96b6-67f90468a0b3"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7e0a1a7c-f47b-4ed2-932a-df8d1045a068"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7ef44a91-f65d-475a-821e-010c29789628"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7f786963-8bc6-4569-8d88-81a2dc18bebf"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("804713ee-369b-4ac7-979b-9a6188c64383"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("81e7be69-f693-4f1d-9295-085abe90a5ed"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("831c2f8e-53b9-49c8-ac21-a4d14e1a5ada"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("85eeed0a-df43-482c-bd66-44c9e3dbd2f7"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8758881d-f28f-4122-98f0-fe53a8807d9d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8a55df9f-e715-46e2-a461-613ed1d38931"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8cc0e7b4-9ff8-43a1-8c12-b9e072f58b86"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("951c56b7-8f2d-4fce-9d40-bb7961f7adc0"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("9718f1a5-8601-4e4c-a7aa-f0379d78d48a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("9a0fd440-95c4-44b0-abb4-5bb1a1f34f46"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a17eaef1-11ae-4ef0-b85a-fc2d502f4a59"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a2a99af9-7509-40b8-8014-cc39d3c88b05"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a65e9964-d601-41e0-8d98-8b732b3a2211"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a8ba564e-960d-4aae-8013-7df997d84bfb"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("aa105b4e-88cb-452c-97f7-a72986f90e14"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ad55184b-c876-4ed2-8f84-79bc53d822d6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("add9d4ce-c798-4c21-9fa4-855c1e2cf435"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b0c7d44c-616c-4332-a27e-ac8173a2bf40"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b353d52e-af10-4607-8cd6-c02641dcf5a5"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b4d0319b-ea9a-4a35-b3cc-12c0b25286f0"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b5ad60b0-9ae8-4419-b77e-eed90bca74e3"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b68031f6-6ede-486e-a7eb-ca6391003b0d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b88815ea-4360-468c-92f0-2eb9dcfb1755"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("bb29f930-9f1c-4f1d-9ad4-dec056a7d36c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("bcb42f38-8624-464f-8019-8a7b9fde109c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("bd632613-e7a9-4879-881a-4af2fffb78de"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("bffe58df-b6c1-4174-8dca-77f8ec94d5ee"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c3cd7f2a-ff8a-41b1-ae95-150c7c8ec2cf"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c403583f-c1c9-46e1-aab8-9b79c9a8bc33"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c498d2e1-3149-4cdf-8d25-627fee492f91"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c6d05247-eb51-4143-99bd-1e2dd3fb701e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c6d5d1ad-861c-4a81-a2f6-5438ee8709c3"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c79631b2-0d89-4159-9471-34e0965cb9f4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ca50b83e-4989-420a-929d-7f05adfa0998"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("caf96148-401f-454e-b9e0-72a1d2f52e43"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("cc5d333f-9a49-4cb5-a1bd-bf03d5072855"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ccb8172c-48ed-4641-a5d0-029eefd44b95"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d463663c-7c65-429c-8553-fc0b860111a1"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d548080f-7953-4623-bbae-1f2141ccea19"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d627ec45-c9c7-42b8-9a63-a61631dd2e8e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d9b6c19f-1ecb-4bcf-ac63-6fc5c7f62ad6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("def4a316-1241-4244-8a69-f8507e29b6ee"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e02b40eb-f85c-4af3-84b0-4a2e62c8c155"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e044582a-c8f8-4cc4-b135-5e39f5f4b64f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e09aa359-6cad-4fdc-9bef-33837b6dde98"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e752ce3d-c979-4925-bc87-2a0ca1c67336"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e7a6b421-6568-4363-a0d3-7776ca7364c2"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ea117ce4-5eca-4f22-a12e-513433a99380"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ee272664-06d3-46b7-bfc6-4d5818286a9b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f5ea883f-b816-44d6-b9ff-fbfde4dfa801"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f85c0fc7-9fa2-4310-b193-3b2d0befa85b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f8e5f58e-7f90-49c6-a4ae-026d717fd5ff"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("fb24d8e8-381b-47d2-b612-a5770ff6e0bf"));

            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "CouponId", "AlreadyUsed", "Code", "CreatedBy", "CreatedDate", "Discount", "LastModifiedBy", "LastModifiedDate" },
                values: new object[,]
                {
                    { new Guid("2afbc152-e4b2-4c08-a3e8-9e3211c67b41"), false, "BeNice", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, null, null },
                    { new Guid("327bbc2a-e99d-474a-ad86-e3dde176c3f7"), false, "AlmostFree", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, null, null },
                    { new Guid("b87bd520-edcf-4240-90db-95ca87e16c54"), false, "Awesome", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, null, null }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemId", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "MenuId", "Name", "Price", "SubmenuId" },
                values: new object[,]
                {
                    { new Guid("0247e3b3-fe42-49d8-a863-723a88c7154a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/22_soulman-load-up.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soulman Load Up", 80.00m, null },
                    { new Guid("0286643e-8dc0-4515-98de-a88b093fe818"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A delicious chicken patty served with shredded lettuce & Colonel dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Snack Burger", 29.90m, null },
                    { new Guid("04e9cf37-f542-4c3a-9d12-dbeccfdadd86"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/32_love-me-hot-cheese-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Hot", 72.00m, null },
                    { new Guid("09305997-0177-41e7-ba03-4b1bc86442bd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Lunch Meal Max", 76.00m, null },
                    { new Guid("0bacb4d1-8a47-4358-b5b7-1352add99924"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Pieces of Original Recipe Chicken and Small Chips or Coleslaw.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Two with Chips", 49.90m, null },
                    { new Guid("0d48707a-6256-4430-8610-be6a00267da7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wrapsta, 1 Piece of Original Recipe Chicken, Small Chips & Buddy Drink", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Wrapsta Box Meal", 84.90m, null },
                    { new Guid("0e03179e-ec52-4420-89e1-b4840b2e5202"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/12_love-me-hot-cheese-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Hot Cheese Burger", 40.00m, null },
                    { new Guid("112e81b4-c574-4442-892c-95da93fdfe5d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Lunch Meal", 73.00m, null },
                    { new Guid("13153eb1-f78d-4e7a-b388-b733ceddb051"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "6 Hotwings", 42.00m, null },
                    { new Guid("13645000-1437-4fff-a88a-254eb2b6c2e1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "24 Hotwings", 168.00m, null },
                    { new Guid("1411656c-94cf-4ab7-876e-c86202d83bfd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/13_big-john-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Big John", 42.00m, null },
                    { new Guid("154422c5-dff8-409a-b189-027c815eb2c8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "10 Hot Zinger Wings", 89.90m, null },
                    { new Guid("1a034165-1bbb-4338-be50-354cd59ea1ff"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/53_soulsister-party-circle5ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Party", 112.00m, null },
                    { new Guid("1b0d0769-69a4-49d4-b02b-cec635e0bdfb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around a delicious fillet zinger recipe - a slice of cheese, hash brown, crisp lettuce, fresh tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Zinger Boxmaster", 76.90m, null },
                    { new Guid("1d98393a-05e4-4483-acb4-314c63ed52cd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get yourself a Streetwise 5, with 2 Buddy No Sugar", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Streetwise 5 Buddy", 143.90m, null },
                    { new Guid("1e178aee-cbe8-4a7b-acd6-0d67bf43cee5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oven baked, fresh mini loaf", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Mini Loaf", 14.90m, null },
                    { new Guid("1fa45802-11f9-4df7-8359-7211cb391b2c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Nuggets, 1 Crunch Burger, 1 Small Chips and a Buddy Drink", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Nugget Box Buddy Meal", 79.90m, null },
                    { new Guid("210421fd-217c-4e74-b96e-73d4d7738883"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/17_hotwings-party-circle16ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Party", 132.00m, null },
                    { new Guid("21865590-96a4-4686-b30c-e9f11b688df9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/59_just-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 6", 120.00m, null },
                    { new Guid("21dda534-89d9-437c-9f6b-7f6c9a00e2d9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "12 Hotwings", 84.00m, null },
                    { new Guid("2259d288-b2fd-46a1-a58e-1aa8b8042e68"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around 2 deliciously crispy chicken strips, shredded crisp lettuce, sliced tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Classic Twister", 66.90m, null },
                    { new Guid("23838f86-6c39-4777-b468-13edd25e3335"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An icy sippable treat with Berry bitz, and creamy soft-serve.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Verry Berry Krusher", 42.90m, null },
                    { new Guid("273f9cf2-0d48-4261-beae-dc0b30224de5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul 3 Straight", 57.00m, null },
                    { new Guid("2850c91a-e5b1-4cd9-92f7-46347e5ce401"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces of crispy, delicious golden brown Nuggets, paired with 1 delicious Colonel dipping sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "6Pc Nuggets", 36.90m, null },
                    { new Guid("28f0f5d1-91a7-4b13-82bc-67c446e0ac6a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/129_soulsister-2-vibe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Vibe", 40.00m, null },
                    { new Guid("29243265-6ce1-4310-aa6c-42abafd56204"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprite Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Sprite Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("2acf6fba-3891-4108-8dbf-fad5d543d1da"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Two full chickens (cut into 16), 16 Winglets, 2 Flame-grilled Mielies cut into 3 (6 portions), 2 Sharing Wedges. Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/fa60cb07-3c21-4718-8f02-cb91fd83319b", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Peri-er Platter", 640.00m, null },
                    { new Guid("2cc834e5-003d-49be-b29e-1be844ad7dc0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Soul", 50.00m, null },
                    { new Guid("2d01a444-577a-4ed4-8608-1d9c91db04e3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soul Square Meal", 50.00m, null },
                    { new Guid("2ee24eb1-6a64-4caf-819d-f3cd746e4a88"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/10_love-me-hot-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Hot", 37.00m, null },
                    { new Guid("2f79f60e-2118-4cdb-973a-54e970324070"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke 1.5 Litre Bottle", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke 1.5 Litre Bottle", 32.90m, null },
                    { new Guid("3304d555-18ca-4041-b1c8-4a24c282e4a5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/56_just-circle3ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 3", 60.00m, null },
                    { new Guid("379aa7c0-4964-4d1f-8fdd-3f3192141eec"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "24 Zinger Wings Bucket", 194.90m, null },
                    { new Guid("37d3a78f-5b8b-4c1c-a1b6-de6a3a7fc083"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/16_hotwings-circle6ce-max.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Max", 69.00m, null },
                    { new Guid("38a9ec26-7503-4c8d-8d00-2a8f97fcc19f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Hotwings Meal", 86.00m, null },
                    { new Guid("392bb106-bf64-49be-80b2-a65d9b7adaa8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Small Chips", 16.90m, null },
                    { new Guid("3bc09da6-0b8e-4077-b79f-d3930f5edfc0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/25_family-full-house-circle8ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Family Full House", 173.00m, null },
                    { new Guid("3dc10b63-0658-4f04-a035-b27110731fd1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/7_love-me-tender-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Tender", 37.00m, null },
                    { new Guid("3dd23154-4f97-449d-bb88-a2f36f34b42b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Large Chips", 0m, null },
                    { new Guid("3e4a769d-b1d0-40f6-b2ab-89cd0bce9866"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/57_just-circle4ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 4", 80.00m, null },
                    { new Guid("3efae7bf-7668-4e2b-98df-9d64bbc0622e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/28_big-john-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Big John", 72.00m, null },
                    { new Guid("3f602136-bf5c-41be-a090-a4ee60cb069c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "24 Zinger Wings Bucket", 194.90m, null },
                    { new Guid("440f7220-0e67-4925-8110-d28404ccf61f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of creamy mash and our delicious gravy.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Large Mash & Gravy", 27.90m, null },
                    { new Guid("455b49c1-b2eb-45bd-9f7f-7668b9940d52"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 Piece Chicken", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "1 Piece Chicken", 26.90m, null },
                    { new Guid("467a44a6-9aa3-4456-8fb8-837edde09854"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A delicious chicken patty served with shredded lettuce & Colonel dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Snack Burger", 29.90m, null },
                    { new Guid("491366c4-5748-4afd-81ab-1abcc7622f40"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 KFC famous Zinger Wings dunked in a delicious honey, ginger and soy sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "4 Dunked Wings", 54.90m, null },
                    { new Guid("49f34a14-dc0a-49ff-b633-0f1e801c4497"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/31_love-me-hot-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Hot", 70.00m, null },
                    { new Guid("4d3804a7-f0b8-42a5-a596-606151c319fd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Cappy Juice 1.5 Litre", 44.90m, null },
                    { new Guid("4e6d5cc2-e737-49a2-991c-7e93f2af824e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken that are tender on the inside and crunchy on the outside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Small Pops", 29.90m, null },
                    { new Guid("4ec7c3c4-02d3-44ca-bb14-69a13bb84ec1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Veg Burgers, 2 Halloumi & Roast Veg Wraps, 2 Halloumi & Roast Veg Pitas, 2 Sharing Wedges, 4 Flame-grilled Mielies cut into 3 (12 portions). Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/3b7bc5aa-eb6c-4f3b-a289-ae9669f410dd", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Veggie veggie nice platter", 640.00m, null },
                    { new Guid("505456e6-04e0-4143-aa88-2b1c9b4dec0e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "One and a 1/2 full chickens ( cut into 12), 2 Flame-grilled Mielies cut into 3 (6 portions), 4 Kids Burgers, 2 Sharing Wedges. Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/5182f543-741a-4317-a731-e8098a228c37", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "More to share platter", 640.00m, null },
                    { new Guid("5467b379-c517-4c8c-b448-530c2bda9926"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around a delicious fillet original recipe - a slice of cheese, hash brown, crisp lettuce, fresh tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Colonel Boxmaster", 76.90m, null },
                    { new Guid("5644c3fb-659a-4ec5-8b05-6933e612a9dc"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milk shake milk shake shake shake", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Strawberry Milkshake", 31.90m, null },
                    { new Guid("5a9b51ed-11e3-49f2-8fc1-6544b4284ca5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of creamy mash and our delicious gravy.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Mash & Gravy", 19.90m, null },
                    { new Guid("5b5c8a1a-2549-4d92-843c-6ff3ca5191bf"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul 3 Combo", 60.00m, null },
                    { new Guid("5bb4f358-1878-48fa-b455-d52a85c7302b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs & spices.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1"), "15 Piece Bucket", 279.90m, null },
                    { new Guid("5c95a096-f542-47be-8b82-fa4dbcb27d31"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke No Sugar 1.5 Litre", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke No Sugar 1.5 Litre", 29.90m, null },
                    { new Guid("5dcc6dc9-ed11-4798-a80c-b2a414c06fed"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/9_love-me-tender-cheese-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Tender Cheese Burger", 40.00m, null },
                    { new Guid("5e76d819-251e-43d5-a0c2-dcf034aab3b2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/34_2-slyders-original.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "2 Slyders", 27.00m, null },
                    { new Guid("63a71cfa-d493-4f96-a621-ca00ddd68bfb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs and spices of Original Recipe® chicken, marinated and cooked to perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1"), "9 Piece Bucket", 182.90m, null },
                    { new Guid("664bfe90-7f9b-48b5-a7ab-5e949e9a7d52"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/50_soulsister-circle2ce-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Deluxe", 62.00m, null },
                    { new Guid("6859b58a-d7ab-45c9-9d40-864ad1292706"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fanta Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Fanta Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("69a573d4-b453-493d-875f-4d7ae3d47a54"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy 6 pieces of delicious original recipe chicken, 1 large chips, 1 regular coleslaw plus 2 regular mash and gravies.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "All In One Feast", 194.90m, null },
                    { new Guid("6c532763-bea9-4bf1-850a-980a81f43979"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/47_soul-mix-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Soul Mix Snack", 30.00m, null },
                    { new Guid("6f006dda-28f7-4665-9963-a0ced843ec3c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/39_1-slyder-chilli.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Slyder", 14.00m, null },
                    { new Guid("70b4de48-1036-41a5-b153-162d5151fcfa"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chocolate Milkshake", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Chocolate Milkshake", 31.90m, null },
                    { new Guid("7224f4f0-2707-45d3-a6cd-6e9319746262"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An icy sippable treat with Oreo bitz, and creamy soft-serve.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Oreo Krusher", 42.90m, null },
                    { new Guid("74bc3fc1-4717-42d3-9fed-2f2bfcd03e40"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pulled Chicken Wraps (cut into 6), 3 Chicken Wraps (cut into 6), 2 Sharing Wedges, 16 Winglets, 2 Flame-grilled Mielies cut into 3 (6 portions). Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/ccc05d6a-734b-4fec-bbc7-50a7da7ad2da", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Hands-on delicious platter", 640.00m, null },
                    { new Guid("7554bab4-56ad-4b6b-90b7-ea8d822f1a73"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 pieces of crispy, delicious golden brown Nuggets, paired with 1 delicious Colonel dipping sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "9Pc Nuggets", 42.90m, null },
                    { new Guid("775b9142-227a-4d78-a0aa-bce7c1410d28"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy a piece of original recipe chicken, 2 zinger wings and a small scrumptious chips.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Bucket For One", 46.90m, null },
                    { new Guid("795a38a2-6288-4a2d-83fa-990e366da095"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca-Cola Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coca-Cola Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("7a2c8a96-0d0a-48ef-a84e-9b9782f1d17e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken, tender on the inside and crunchy on the outside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Large Pops", 54.90m, null },
                    { new Guid("87c8e714-f26f-4c2e-a883-9b29db665601"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bonaqua Still Spring Water 500ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Bonaqua Still Spring Water 500ml", 19.90m, null },
                    { new Guid("88f4f718-61c9-4957-a310-e4af6d7fe62a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8pc Chicken, 2 snack burgers, 4 Zinger Wings, 2 Reg Coleslaw, 2 Reg chips", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "8 Piece Family Treat", 274.90m, null },
                    { new Guid("8ec62b04-d8ea-418e-b640-ffa6871cb451"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half Platter", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/f93c9cbe-5f94-4bb4-a937-811c28bd88df", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Big on veg platter", 640.00m, null },
                    { new Guid("8fa5d297-6547-4648-9d14-8a5a1ece3df1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Try the new standard! The New Colonel burger, Our trademark real chicken fillet; A fresh Brioche bun, Creamy Colonel sauce and cheese on a fresh bed of lettuce & succulent tomatoes", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Colonel Burger", 60.90m, null },
                    { new Guid("8ff77ae1-efe4-434a-ab0a-c5a25ddf9365"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/30_love-me-tender-cheese-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Tender", 72.00m, null },
                    { new Guid("90e63ff7-bf33-42ac-b666-34a353d4c6fe"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 KFC famous Zinger Wings dunked in a delicious honey, ginger and soy sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "10 Dunked Wings", 104.90m, null },
                    { new Guid("9260c506-9932-4af8-8ab2-680a10ceee44"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 Pieces of Original Recipe chicken cooked to golden perfection and a large portion of chips or coleslaw.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Five", 121.90m, null },
                    { new Guid("93c84859-6969-4fa1-ad0e-3dbff0d39567"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/52_soulsister-party-circle4ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Party", 84.00m, null },
                    { new Guid("9455e1c6-be3e-4ac2-b5be-d27f64239f8e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/24_family-full-house-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Family Full House", 143.00m, null },
                    { new Guid("9479e26f-d2b5-49fd-a9a7-cf45b2c12ad9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/36_1-slyder-cheese.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Slyder", 16.00m, null },
                    { new Guid("9524ea8e-beac-4e99-bf8d-ace72944b6c6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A spicy, crunchy mini fillet with a slice of cheese and lettuce, covered in tangy dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Crunch Burger", 36.90m, null },
                    { new Guid("99f5a6e0-28cb-4f89-97cc-4da1fefd005a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pieces of Original Recipe Chicken with a portion of pap and gravy", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Three with Pap", 72.90m, null },
                    { new Guid("a04d1358-1ed2-42fa-b9dc-8e6007692642"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy KFC`s new Jalapeno loaded fries with brand new Hot * spicy sauce", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Jalapeno Loaded Fries", 32.90m, null },
                    { new Guid("a0953255-bc9e-4805-9a94-eca614764b5f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy 4 pieces of original recipe chicken, 2 small chips, 1 small pops & 2 buddy no sugar drinks.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "2 Can Dine Buddy", 164.90m, null },
                    { new Guid("a6eda0d0-f6fb-424c-a49a-fd1fb9d2ac4d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/125_soulbites-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Soul Bites Snack", 30.00m, null },
                    { new Guid("a78b6ebf-c647-445b-bbf8-ac492a3a13e0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/49_soulsister-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister", 43.00m, null },
                    { new Guid("b076883f-cc58-43ba-9d86-9aba1a070204"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/51_soulsister-circle2ce-max.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Max", 65.00m, null },
                    { new Guid("b0a2aae6-2803-4d35-89ce-cba0361ee394"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The game changer is here, and with a delicious spicy crunch fillet, tomato, lettuce and cheese with tangy dressing all wrapped up in a mini tortilla and grilled to perfection, meal time will never be the same again.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Wrapsta", 42.90m, null },
                    { new Guid("b7b2c9b8-1623-46bb-a547-05861f32d860"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new standard in burgers! 2 Spicy, crunchy mini fillets with 2 cheese slices, lettuce & tomato covered in tangy dressing on a burger bun", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Double Crunch Burger", 68.90m, null },
                    { new Guid("b9557427-6f82-49fd-bbb6-24a854aa156f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new Burger standard…Boxed! The Crispy Zinger burger, 1 piece of original recipe chicken, regular mash & gravy, chips & Buddy no sugar.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Zinger Fully Loaded Buddy Box Meal", 115.90m, null },
                    { new Guid("c0044d94-f0fd-4d5b-a0fa-d6bb94a13ea3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/123_soulbites-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a9"), "Soul Bites", 38.00m, null },
                    { new Guid("c04f15f8-c0be-4cbf-88fd-3554a1a8a02d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/55_just-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 2", 39.00m, null },
                    { new Guid("c14c8fb0-57d5-4043-93dd-1e229865b578"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around 2 deliciously crispy new and improved chicken strips, shredded crisp lettuce, sliced tomato, topped with Colonel dressing and sweet chilli sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Sweet Chilli Twister", 66.90m, null },
                    { new Guid("c1e9487f-8eb4-4c4b-a4d1-cee6ad2691fb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/46_hotwings-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Hotwings Snack", 30.00m, null },
                    { new Guid("c681124d-b05c-48d4-972d-b96a6b014813"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new Burger standard…Boxed! The new Colonel burger, 1 piece of original recipe chicken, regular mash & gravy, chips & a buddy no sugar drink.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Fully Loaded Box Meal", 115.90m, null },
                    { new Guid("c94f6ba1-fde2-42d4-b5f6-83f216004bac"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/54_just-circle1ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 1", 20.00m, null },
                    { new Guid("c9eb8c19-87b3-49c8-9f52-ac3a72dc9772"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A generous sharing platter of 4 succulent Flame-grilled Shisanyama Chicken Sosaties and 20 Winglets, served with 2 portions of our Sharing Wedges, 2 Garlic Rolls and our special PERinase dip.", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/3d93a55d-440a-407c-8b7b-97cc1e6c510a", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Cabo Sosatie Snack Platter", 349.00m, null },
                    { new Guid("cdb05fa1-9848-42bf-8038-e277b3821768"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/61_family-bucket-circle15ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Family Bucket", 230.00m, null },
                    { new Guid("ce0db374-7a99-4c1b-bd20-38daae6b243a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of freshly prepared cabbage, onions and carrots in a delicious dressing", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Coleslaw", 24.90m, null },
                    { new Guid("ce43fcde-a9c4-46db-864a-19e2107ef936"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/60_chicken-inn-circle9ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Chicken Inn", 150.00m, null },
                    { new Guid("d23ae495-38bb-4890-b157-4d4c602413bd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/18_feed-my-craving-circle10ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Feed My Craving", 79.00m, null },
                    { new Guid("d9147e67-5f01-4c57-b2d3-ffb43278cf91"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Hotwings Meal Max", 90.00m, null },
                    { new Guid("da861254-b881-4447-8496-048ef306386e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/45_popcorn-chicken-shaker.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Popcorn Chicken Shaker", 30.00m, null },
                    { new Guid("dc1747fb-b263-4ee9-907b-1c38d4c99045"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/29_love-me-tender-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Tender", 70.00m, null },
                    { new Guid("e01fafdf-fb41-4f0a-a4e0-5687a28bf441"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "36 Hotwings", 231.00m, null },
                    { new Guid("e1b250f0-0507-4c5e-8c22-c386fdfef42a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken dunked in KFC’s famous honey, ginger and soy sauce!", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Dunked Pops", 36.90m, null },
                    { new Guid("e277292a-e320-40c3-bbd7-8e3445ecc3c4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/44_slyder-snack-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Slyder Snack", 30.00m, null },
                    { new Guid("e433aa34-3fae-426f-95e1-7ea1d8846f00"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "4 Zinger Wings", 48.90m, null },
                    { new Guid("e44d02d6-3946-45c6-8081-31267caf12a8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke No Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke No Sugar Buddy 440ml", 22.90m, null },
                    { new Guid("e621bbe4-8034-401c-bc0b-660554870846"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extra Hot & Spicy Zinger sauce on the side", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Sauce - Hot & Spicy", 0m, null },
                    { new Guid("e71d5f77-e985-44d0-bd30-2025a6f20aa7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/124_soulbites-circle9ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a9"), "Soul Bites Max", 45.00m, null },
                    { new Guid("e7720612-e6f8-426d-ab2e-3718a9ba592e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get yourself a Streetwise 1, with a Buddy no sugar free drink", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Streetwise 1 Buddy", 52.90m, null },
                    { new Guid("e788a0df-73f0-4910-b42b-7b653d1687a3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/58_just-circle5ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 5", 99.00m, null },
                    { new Guid("eafe1383-75ec-45d0-ae8a-fd5a020f79aa"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/33_1-slyder-original.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Slyder", 14.00m, null },
                    { new Guid("ec7b1bf1-c972-4ab5-8e56-b36294b93cb7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/62_family-barrel-circle21ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Family Barrel", 300.00m, null },
                    { new Guid("ed20bf1c-e1e3-4780-bdf1-b2871f9dab98"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10pc Chicken, 2 snack burgers, 4 Zinger Wings, 2 Reg Coleslaw, 2 Reg chips", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "10 Piece Family Treat", 316.90m, null },
                    { new Guid("efb81fc3-21f5-4abd-8a0f-f00035ae4c0c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/21_rock-my-soul-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul", 105.00m, null },
                    { new Guid("f25d2992-a308-47e5-ae84-62e9b1538aa6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Pieces of original recipe chicken cooked to golden perfection and a regular portion of pap & small gravy.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Two with Pap", 49.90m, null },
                    { new Guid("f31c40e5-c0c5-4d8e-aaa2-23bfd3b37156"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken that are tender on the inside and crunchy on the outside. Served with a generous sprinkle of fruit chutney flavour.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Sprinkle Pops", 54.90m, null },
                    { new Guid("f817e76a-eabb-4132-b743-64b6700b8ee4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Try the new standard! The New Crispy Zinger burger, Our trademark real chicken fillet; A fresh Brioche bun, New Hot & Spicy sauce and cheese on a fresh bed of lettuce & succulent tomatoes", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Zinger Burger", 60.90m, null },
                    { new Guid("f9c537f4-1ae2-4f58-9ead-37eabae42304"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/15_hotwings-circle6ce-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Deluxe", 67.00m, null },
                    { new Guid("fb3cc5f4-a074-4d2a-bf9d-96359d37dfa7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/23_soul-mates-classic-party.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soul Mates Classic Party", 145.00m, null },
                    { new Guid("fb8be3b9-fd0c-4fa1-ade8-daf14022bd11"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy a delicious Crunch Burger an orginal receipe chicken piece with small chips and a buddy no sugar drink", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Crunch Burger Box Buddy", 71.90m, null },
                    { new Guid("fbe92a1d-747a-41b9-9cc8-2e9ad4fc573a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crunch Burger, 1 Piece of Original Recipe Chicken, 2 Zinger Wings, Small Chips & Buddy Drink", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "All Star Box Meal Buddy", 94.90m, null },
                    { new Guid("fdc446f9-2d05-4407-8f2c-14418a57afcf"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pieces of original recipe chicken, a portion of small chips.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Three with Chips", 72.90m, null },
                    { new Guid("fdc6115f-5883-48bd-81b4-db27adf496f4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Chips", 26.90m, null }
                });
        }
    }
}
