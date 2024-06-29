using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gaolos.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class OrderSummary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<decimal>(
                name: "Delivery",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Subtotal",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "CouponId", "AlreadyUsed", "Code", "CreatedBy", "CreatedDate", "Discount", "LastModifiedBy", "LastModifiedDate" },
                values: new object[,]
                {
                    { new Guid("b0082bbc-1cb9-4ea5-84c3-cd07dfc5dd26"), false, "Awesome", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, null, null },
                    { new Guid("b9da42cb-e4d8-4da1-ba06-75ca16711d92"), false, "BeNice", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, null, null },
                    { new Guid("f0a34a0d-b687-4f8c-8b40-329e36a8f8e9"), false, "AlmostFree", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, null, null }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemId", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "MenuId", "Name", "Price", "SubmenuId" },
                values: new object[,]
                {
                    { new Guid("00d2e678-d6da-45a8-9fb9-1a8b28d4888e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul 3 Combo", 60.00m, null },
                    { new Guid("01bc5d82-1bbc-4109-827f-4e159fc63c29"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around 2 deliciously crispy new and improved chicken strips, shredded crisp lettuce, sliced tomato, topped with Colonel dressing and sweet chilli sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Sweet Chilli Twister", 66.90m, null },
                    { new Guid("044bbffb-b57a-491a-97ca-9afc7f1ea16d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/47_soul-mix-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Soul Mix Snack", 30.00m, null },
                    { new Guid("04ec9cc2-9dc1-4f49-b058-1cc11c9b58fe"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/129_soulsister-2-vibe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Vibe", 40.00m, null },
                    { new Guid("07b46e0c-db2a-4399-abec-3db720a2f882"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/52_soulsister-party-circle4ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Party", 84.00m, null },
                    { new Guid("090cc3df-a60b-4203-abf0-79694f1deed6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/32_love-me-hot-cheese-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Hot", 72.00m, null },
                    { new Guid("090e1343-4eb7-48c8-85d7-fc2f001b180e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Large Chips", 0m, null },
                    { new Guid("0993ce3b-da63-4f74-badc-35452d4f3ac7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/9_love-me-tender-cheese-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Tender Cheese Burger", 40.00m, null },
                    { new Guid("0aaf14c1-2f39-4e3f-a713-b59d91a86d5b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of creamy mash and our delicious gravy.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Large Mash & Gravy", 27.90m, null },
                    { new Guid("0c5a2585-9f00-41ad-a209-dba00d40f52e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprite Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Sprite Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("0ce1c1c0-0c21-4de9-87b5-821c2505ee1e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Chips", 26.90m, null },
                    { new Guid("0e541591-97e0-41ee-945d-a2623c13107d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy 4 pieces of original recipe chicken, 2 small chips, 1 small pops & 2 buddy no sugar drinks.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "2 Can Dine Buddy", 164.90m, null },
                    { new Guid("0ef1839c-bfd5-4984-b58e-7223cdebd11d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pieces of original recipe chicken, a portion of small chips.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Three with Chips", 72.90m, null },
                    { new Guid("0f007d9d-e5c1-4e59-b48e-a4fa383640c6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "24 Zinger Wings Bucket", 194.90m, null },
                    { new Guid("1211ce0f-7a87-497a-9bd1-3e72069ad683"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/53_soulsister-party-circle5ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Party", 112.00m, null },
                    { new Guid("127c70a9-d3b2-430b-bb11-8627c82d1c5b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/62_family-barrel-circle21ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Family Barrel", 300.00m, null },
                    { new Guid("163cab99-01d6-46b5-a8d2-b12fdf1195f4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get yourself a Streetwise 1, with a Buddy no sugar free drink", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Streetwise 1 Buddy", 52.90m, null },
                    { new Guid("17a21d7c-57f2-4c2f-ae82-f43e8438a610"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oven baked, fresh mini loaf", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Mini Loaf", 14.90m, null },
                    { new Guid("19d1a5cc-f9bd-46cc-aa54-600be0fb7e13"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs & spices.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1"), "15 Piece Bucket", 279.90m, null },
                    { new Guid("1adbeb05-c01f-4633-8240-6f963e715e82"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Pieces of Original Recipe Chicken and Small Chips or Coleslaw.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Two with Chips", 49.90m, null },
                    { new Guid("1cae9102-e680-4e31-8a52-1262d60d92cb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/58_just-circle5ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 5", 99.00m, null },
                    { new Guid("1df22795-d8f4-4a90-90f2-cfd41225b1a1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Nuggets, 1 Crunch Burger, 1 Small Chips and a Buddy Drink", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Nugget Box Buddy Meal", 79.90m, null },
                    { new Guid("228bd58f-eadb-4e64-b98f-7d3671241db7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/18_feed-my-craving-circle10ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Feed My Craving", 79.00m, null },
                    { new Guid("2506138d-72c9-404c-ace2-33c9aedc7209"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half Platter", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/f93c9cbe-5f94-4bb4-a937-811c28bd88df", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Big on veg platter", 640.00m, null },
                    { new Guid("2776131b-aaa2-4308-9a34-8d8e014603e2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "4 Zinger Wings", 48.90m, null },
                    { new Guid("2cdea746-5038-42cb-b9e9-02a0c6e95dfa"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy a delicious Crunch Burger an orginal receipe chicken piece with small chips and a buddy no sugar drink", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Crunch Burger Box Buddy", 71.90m, null },
                    { new Guid("2d315bc6-8426-4427-a544-c95961a2dce3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Two full chickens (cut into 16), 16 Winglets, 2 Flame-grilled Mielies cut into 3 (6 portions), 2 Sharing Wedges. Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/fa60cb07-3c21-4718-8f02-cb91fd83319b", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Peri-er Platter", 640.00m, null },
                    { new Guid("305eebe4-8ec2-4a73-b594-395d88139200"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Try the new standard! The New Colonel burger, Our trademark real chicken fillet; A fresh Brioche bun, Creamy Colonel sauce and cheese on a fresh bed of lettuce & succulent tomatoes", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Colonel Burger", 60.90m, null },
                    { new Guid("31c47bab-f713-48e5-a043-40b9ba2d9fc2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul 3 Straight", 57.00m, null },
                    { new Guid("327a5c34-d3f9-4d6e-a882-7d90c76025e1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crunch Burger, 1 Piece of Original Recipe Chicken, 2 Zinger Wings, Small Chips & Buddy Drink", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "All Star Box Meal Buddy", 94.90m, null },
                    { new Guid("32f25071-aeeb-4da6-bd1d-fd2a67977a2e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Veg Burgers, 2 Halloumi & Roast Veg Wraps, 2 Halloumi & Roast Veg Pitas, 2 Sharing Wedges, 4 Flame-grilled Mielies cut into 3 (12 portions). Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/3b7bc5aa-eb6c-4f3b-a289-ae9669f410dd", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Veggie veggie nice platter", 640.00m, null },
                    { new Guid("32fbedda-4445-4391-ba0e-ad78ee3127c6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A generous sharing platter of 4 succulent Flame-grilled Shisanyama Chicken Sosaties and 20 Winglets, served with 2 portions of our Sharing Wedges, 2 Garlic Rolls and our special PERinase dip.", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/3d93a55d-440a-407c-8b7b-97cc1e6c510a", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Cabo Sosatie Snack Platter", 349.00m, null },
                    { new Guid("34db9c35-af36-4ca0-841e-f9690279297e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/33_1-slyder-original.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Slyder", 14.00m, null },
                    { new Guid("3655a092-4a2e-4ca8-99d6-e28d0beaf321"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke No Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke No Sugar Buddy 440ml", 22.90m, null },
                    { new Guid("39ac9746-2fe7-47d8-9cb8-7acf473969cd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/51_soulsister-circle2ce-max.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Max", 65.00m, null },
                    { new Guid("3a701e32-0760-47b7-a117-8ad74a279ab3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken, tender on the inside and crunchy on the outside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Large Pops", 54.90m, null },
                    { new Guid("3dde5cf0-2529-4459-99c7-bc6b3c520564"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken that are tender on the inside and crunchy on the outside. Served with a generous sprinkle of fruit chutney flavour.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Sprinkle Pops", 54.90m, null },
                    { new Guid("405423ac-7b89-4ee6-a3aa-5b0ffefee51e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/61_family-bucket-circle15ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Family Bucket", 230.00m, null },
                    { new Guid("40d69b13-2048-4cec-bae2-88fa84976a76"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/16_hotwings-circle6ce-max.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Max", 69.00m, null },
                    { new Guid("42a953c5-4eda-4198-a2f5-9b897446ce5a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/124_soulbites-circle9ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a9"), "Soul Bites Max", 45.00m, null },
                    { new Guid("437a5513-4139-44fc-bccf-41b37dca5dea"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Hotwings Meal Max", 90.00m, null },
                    { new Guid("4698a7c9-dcbd-43bc-a5bc-1f5219f64075"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milk shake milk shake shake shake", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Strawberry Milkshake", 31.90m, null },
                    { new Guid("470d4c8d-c1ff-4995-9a87-2b8e7b957db6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/46_hotwings-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Hotwings Snack", 30.00m, null },
                    { new Guid("49b117b9-6f37-475f-8e6a-d71bb3987baf"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/31_love-me-hot-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Hot", 70.00m, null },
                    { new Guid("4b5cd767-8f21-4bf9-93f4-c840ba0e73f6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "12 Hotwings", 84.00m, null },
                    { new Guid("4d6aa6c6-b5f2-4ef3-9fdb-e4131cb29d49"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/24_family-full-house-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Family Full House", 143.00m, null },
                    { new Guid("4da8918a-1b0d-4d12-8e48-661491095288"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 Pieces of Original Recipe chicken cooked to golden perfection and a large portion of chips or coleslaw.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Five", 121.90m, null },
                    { new Guid("5512a62c-7e23-49e3-9929-965a62d52427"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 Piece Chicken", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "1 Piece Chicken", 26.90m, null },
                    { new Guid("5528220f-0232-4c37-90c2-1dedbe790128"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10pc Chicken, 2 snack burgers, 4 Zinger Wings, 2 Reg Coleslaw, 2 Reg chips", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "10 Piece Family Treat", 316.90m, null },
                    { new Guid("56de3bb3-a65e-441f-8383-8aa31d512f56"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/28_big-john-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Big John", 72.00m, null },
                    { new Guid("5c3b9bac-c8f9-4761-a63f-7127236198c1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 KFC famous Zinger Wings dunked in a delicious honey, ginger and soy sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "4 Dunked Wings", 54.90m, null },
                    { new Guid("5ee5f033-97a3-4fbd-a32a-d9b399d9e881"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/10_love-me-hot-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Hot", 37.00m, null },
                    { new Guid("6273fbba-cc38-42d6-b60b-b2f244398712"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extra Hot & Spicy Zinger sauce on the side", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Sauce - Hot & Spicy", 0m, null },
                    { new Guid("64260ad6-c960-4d22-b95e-d20a3cb08e33"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/13_big-john-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Big John", 42.00m, null },
                    { new Guid("65344d9e-19aa-4001-a64d-f23de69f5044"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bonaqua Still Spring Water 500ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Bonaqua Still Spring Water 500ml", 19.90m, null },
                    { new Guid("68a532d0-e33e-4f94-9542-006fcc3309e2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/45_popcorn-chicken-shaker.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Popcorn Chicken Shaker", 30.00m, null },
                    { new Guid("6f919fb3-d6f9-4caf-803f-5b32c9e49233"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/17_hotwings-party-circle16ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Party", 132.00m, null },
                    { new Guid("719cdacc-13da-4dcb-86e6-7e5801e09385"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8pc Chicken, 2 snack burgers, 4 Zinger Wings, 2 Reg Coleslaw, 2 Reg chips", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "8 Piece Family Treat", 274.90m, null },
                    { new Guid("71c0efae-3fe9-4119-b226-c7f4aa0fc6e2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Small Chips", 16.90m, null },
                    { new Guid("743b68e3-dfb8-474f-aa60-9cc63dc6071b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 pieces of crispy, delicious golden brown Nuggets, paired with 1 delicious Colonel dipping sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "9Pc Nuggets", 42.90m, null },
                    { new Guid("74f7941e-814b-4fc9-a480-435840dc72d4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/12_love-me-hot-cheese-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Hot Cheese Burger", 40.00m, null },
                    { new Guid("751b7a00-f9e4-4635-8b60-de0aff9e0a4b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/125_soulbites-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Soul Bites Snack", 30.00m, null },
                    { new Guid("75959c7d-1b79-4690-a3a2-9f07fffd2f03"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around 2 deliciously crispy chicken strips, shredded crisp lettuce, sliced tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Classic Twister", 66.90m, null },
                    { new Guid("76690a47-deec-468f-93c3-5f14c165a98f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke 1.5 Litre Bottle", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke 1.5 Litre Bottle", 32.90m, null },
                    { new Guid("7a8e5e5a-d378-478d-b365-a968e1cc01ba"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/55_just-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 2", 39.00m, null },
                    { new Guid("7b8c9784-1f37-4962-abcf-702b0cae9ae2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An icy sippable treat with Oreo bitz, and creamy soft-serve.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Oreo Krusher", 42.90m, null },
                    { new Guid("7c3adfd7-09f8-4420-8bf9-087c496dae08"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A delicious chicken patty served with shredded lettuce & Colonel dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Snack Burger", 29.90m, null },
                    { new Guid("82675bd7-0c3d-4ac7-b5db-829499349394"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy KFC`s new Jalapeno loaded fries with brand new Hot * spicy sauce", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Jalapeno Loaded Fries", 32.90m, null },
                    { new Guid("84cf0618-1c14-4c1d-acfe-48f673585521"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Lunch Meal", 73.00m, null },
                    { new Guid("85bf078b-2c26-4db3-8cb3-320dbb673ff5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/50_soulsister-circle2ce-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Deluxe", 62.00m, null },
                    { new Guid("8ad7189c-9d04-4862-8f18-614913bfe33e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/36_1-slyder-cheese.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Slyder", 16.00m, null },
                    { new Guid("8b2f2a6b-3290-4117-bf01-5f7f86a993ae"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/54_just-circle1ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 1", 20.00m, null },
                    { new Guid("8bca23e4-8b14-49b8-93ae-cc3df88dc44a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "10 Hot Zinger Wings", 89.90m, null },
                    { new Guid("8d4427b2-0221-4974-a74d-8f66672e851b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new standard in burgers! 2 Spicy, crunchy mini fillets with 2 cheese slices, lettuce & tomato covered in tangy dressing on a burger bun", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Double Crunch Burger", 68.90m, null },
                    { new Guid("8e13081a-36fb-4123-8473-ea9f5a724fb8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An icy sippable treat with Berry bitz, and creamy soft-serve.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Verry Berry Krusher", 42.90m, null },
                    { new Guid("8f9c441c-5ee5-4420-9abb-a89a8014af28"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Soul", 50.00m, null },
                    { new Guid("958217ed-f437-4877-b10e-ffc1228ccbae"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "36 Hotwings", 231.00m, null },
                    { new Guid("97ff6912-8b5c-4bb6-bb23-ba763fc05a68"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around a delicious fillet original recipe - a slice of cheese, hash brown, crisp lettuce, fresh tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Colonel Boxmaster", 76.90m, null },
                    { new Guid("98063063-0919-4c45-b41f-b510ba9ca474"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chocolate Milkshake", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Chocolate Milkshake", 31.90m, null },
                    { new Guid("98c9e5f8-0b80-4419-bc42-a4f8d45505cd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/57_just-circle4ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 4", 80.00m, null },
                    { new Guid("992a641d-a42c-45b5-8930-f5ebbc5103cc"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/23_soul-mates-classic-party.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soul Mates Classic Party", 145.00m, null },
                    { new Guid("99a6a26c-3e62-490b-98ae-bac259593c66"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy 6 pieces of delicious original recipe chicken, 1 large chips, 1 regular coleslaw plus 2 regular mash and gravies.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "All In One Feast", 194.90m, null },
                    { new Guid("9a35ac95-b550-473f-b2e9-56148e2fb1ea"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/123_soulbites-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a9"), "Soul Bites", 38.00m, null },
                    { new Guid("9a9e5a85-898b-4c83-8ad0-212953657199"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke No Sugar 1.5 Litre", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke No Sugar 1.5 Litre", 29.90m, null },
                    { new Guid("9e67b8f6-0937-4568-a234-a18aedc5371e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/56_just-circle3ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 3", 60.00m, null },
                    { new Guid("a40e2b1f-535e-4c80-87b6-18c515a06dfd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/49_soulsister-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister", 43.00m, null },
                    { new Guid("a5d4b31a-ddcc-496f-8c7b-bee3ef6bd0d6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/25_family-full-house-circle8ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Family Full House", 173.00m, null },
                    { new Guid("a5f37c4a-a858-4475-b084-be4c39db1c16"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken that are tender on the inside and crunchy on the outside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Small Pops", 29.90m, null },
                    { new Guid("a605a6e1-d217-4eb7-a2e7-378d5bc64a8c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/30_love-me-tender-cheese-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Tender", 72.00m, null },
                    { new Guid("a61f873f-d51c-4583-ae60-bace0dd13c01"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of freshly prepared cabbage, onions and carrots in a delicious dressing", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Coleslaw", 24.90m, null },
                    { new Guid("b442bc14-7350-4de1-aab1-789fe8299ee1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of creamy mash and our delicious gravy.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Mash & Gravy", 19.90m, null },
                    { new Guid("b7e46666-9831-4181-abac-1aaf22a9e546"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soul Square Meal", 50.00m, null },
                    { new Guid("ba00213b-c060-4128-a0f7-a3f4e215ceb4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/22_soulman-load-up.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soulman Load Up", 80.00m, null },
                    { new Guid("ba8ad172-b528-47db-9230-f59e07e72718"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pulled Chicken Wraps (cut into 6), 3 Chicken Wraps (cut into 6), 2 Sharing Wedges, 16 Winglets, 2 Flame-grilled Mielies cut into 3 (6 portions). Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/ccc05d6a-734b-4fec-bbc7-50a7da7ad2da", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Hands-on delicious platter", 640.00m, null },
                    { new Guid("babbe0d0-cb1f-4860-b111-0dd8b19ad08b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca-Cola Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coca-Cola Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("bc54758a-6487-40e0-8815-561b12e8b2f5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Hotwings Meal", 86.00m, null },
                    { new Guid("bde156bb-b00f-42d0-a357-b88f97d6bf97"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "24 Zinger Wings Bucket", 194.90m, null },
                    { new Guid("c03e8a9b-d69a-4948-a5a9-9c65d0898257"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wrapsta, 1 Piece of Original Recipe Chicken, Small Chips & Buddy Drink", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Wrapsta Box Meal", 84.90m, null },
                    { new Guid("c1f4c0e4-c33c-4367-bd58-e97ce81d7286"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 KFC famous Zinger Wings dunked in a delicious honey, ginger and soy sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "10 Dunked Wings", 104.90m, null },
                    { new Guid("c74ad7d4-06c7-441f-935d-56c69fadcb58"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The game changer is here, and with a delicious spicy crunch fillet, tomato, lettuce and cheese with tangy dressing all wrapped up in a mini tortilla and grilled to perfection, meal time will never be the same again.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Wrapsta", 42.90m, null },
                    { new Guid("c7e1a3e2-3f6b-449e-b0a9-0ff62d38fabf"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy a piece of original recipe chicken, 2 zinger wings and a small scrumptious chips.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Bucket For One", 46.90m, null },
                    { new Guid("cb03e8ed-4d15-4358-8bfd-bb5e9375f1f6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A delicious chicken patty served with shredded lettuce & Colonel dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Snack Burger", 29.90m, null },
                    { new Guid("cc768f89-83fa-468d-aa0b-cb3396bf482b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs and spices of Original Recipe® chicken, marinated and cooked to perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1"), "9 Piece Bucket", 182.90m, null },
                    { new Guid("cc8a4b10-cd24-4562-a594-274b295e0cf6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/7_love-me-tender-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Tender", 37.00m, null },
                    { new Guid("cd326290-da54-4172-afc8-d8f3db53e8d8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/60_chicken-inn-circle9ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Chicken Inn", 150.00m, null },
                    { new Guid("cdcb7d22-c218-497c-a7e2-29e6085aa449"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "24 Hotwings", 168.00m, null },
                    { new Guid("ce8711b5-8da2-433f-ad12-e682709c0bb6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces of crispy, delicious golden brown Nuggets, paired with 1 delicious Colonel dipping sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "6Pc Nuggets", 36.90m, null },
                    { new Guid("d7278691-fffd-4c4c-b791-bd906936682c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/29_love-me-tender-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Tender", 70.00m, null },
                    { new Guid("d78a8636-5e80-4820-8cde-f83aa46cc4d8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Lunch Meal Max", 76.00m, null },
                    { new Guid("d991823b-384a-480a-bcd9-6b093e5ae040"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A spicy, crunchy mini fillet with a slice of cheese and lettuce, covered in tangy dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Crunch Burger", 36.90m, null },
                    { new Guid("da03b1a4-ece8-4042-8323-3f5ff37108f6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get yourself a Streetwise 5, with 2 Buddy No Sugar", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Streetwise 5 Buddy", 143.90m, null },
                    { new Guid("dadd06a7-9404-4c77-a003-abf8b6702731"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fanta Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Fanta Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("dba18c09-5b24-4378-98da-a6f5a677b3fc"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new Burger standard…Boxed! The Crispy Zinger burger, 1 piece of original recipe chicken, regular mash & gravy, chips & Buddy no sugar.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Zinger Fully Loaded Buddy Box Meal", 115.90m, null },
                    { new Guid("deb09230-d613-45a8-bf3e-66b4fc453ed0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/21_rock-my-soul-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul", 105.00m, null },
                    { new Guid("e21c437a-7ce2-4e4f-86ee-bf591444852b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new Burger standard…Boxed! The new Colonel burger, 1 piece of original recipe chicken, regular mash & gravy, chips & a buddy no sugar drink.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Fully Loaded Box Meal", 115.90m, null },
                    { new Guid("e27be3dc-b167-4aa3-99be-36f1b119afd3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/44_slyder-snack-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Slyder Snack", 30.00m, null },
                    { new Guid("e2d2a645-7945-4f6c-a9de-57018436138a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Pieces of original recipe chicken cooked to golden perfection and a regular portion of pap & small gravy.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Two with Pap", 49.90m, null },
                    { new Guid("e2e8733e-90c2-435b-8a0e-d7f6712749e8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around a delicious fillet zinger recipe - a slice of cheese, hash brown, crisp lettuce, fresh tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Zinger Boxmaster", 76.90m, null },
                    { new Guid("e595162b-7763-4d61-9313-2b1bd783e495"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pieces of Original Recipe Chicken with a portion of pap and gravy", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Three with Pap", 72.90m, null },
                    { new Guid("e6022ef7-a506-438e-bed5-2db05833d986"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "6 Hotwings", 42.00m, null },
                    { new Guid("e7e05513-5f7e-4eea-bd5e-6dc1a5401318"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Try the new standard! The New Crispy Zinger burger, Our trademark real chicken fillet; A fresh Brioche bun, New Hot & Spicy sauce and cheese on a fresh bed of lettuce & succulent tomatoes", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Zinger Burger", 60.90m, null },
                    { new Guid("eaa614b5-ed3c-414c-8f1f-87fc4dc6cce9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken dunked in KFC’s famous honey, ginger and soy sauce!", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Dunked Pops", 36.90m, null },
                    { new Guid("ead90e21-7ad7-4f58-a057-4632197401d2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/39_1-slyder-chilli.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Slyder", 14.00m, null },
                    { new Guid("f1a31ed7-0ee2-44cc-8488-c45570d8432b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/59_just-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 6", 120.00m, null },
                    { new Guid("f50a532b-166c-4e2b-9742-8b89eb4edfb6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/34_2-slyders-original.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "2 Slyders", 27.00m, null },
                    { new Guid("f61af45f-e746-4400-abda-70e50d7914d0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Cappy Juice 1.5 Litre", 44.90m, null },
                    { new Guid("f9dc4eb8-295c-4ef3-aed6-6ccb1704a04e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "One and a 1/2 full chickens ( cut into 12), 2 Flame-grilled Mielies cut into 3 (6 portions), 4 Kids Burgers, 2 Sharing Wedges. Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/5182f543-741a-4317-a731-e8098a228c37", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "More to share platter", 640.00m, null },
                    { new Guid("ff07a54d-c0e8-4c0c-ab4e-24d78ef8b187"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://chickenlicken.co.za/assets/uploads/products/menu/15_hotwings-circle6ce-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Deluxe", 67.00m, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: new Guid("b0082bbc-1cb9-4ea5-84c3-cd07dfc5dd26"));

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: new Guid("b9da42cb-e4d8-4da1-ba06-75ca16711d92"));

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: new Guid("f0a34a0d-b687-4f8c-8b40-329e36a8f8e9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("00d2e678-d6da-45a8-9fb9-1a8b28d4888e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("01bc5d82-1bbc-4109-827f-4e159fc63c29"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("044bbffb-b57a-491a-97ca-9afc7f1ea16d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("04ec9cc2-9dc1-4f49-b058-1cc11c9b58fe"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("07b46e0c-db2a-4399-abec-3db720a2f882"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("090cc3df-a60b-4203-abf0-79694f1deed6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("090e1343-4eb7-48c8-85d7-fc2f001b180e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0993ce3b-da63-4f74-badc-35452d4f3ac7"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0aaf14c1-2f39-4e3f-a713-b59d91a86d5b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0c5a2585-9f00-41ad-a209-dba00d40f52e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0ce1c1c0-0c21-4de9-87b5-821c2505ee1e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0e541591-97e0-41ee-945d-a2623c13107d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0ef1839c-bfd5-4984-b58e-7223cdebd11d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0f007d9d-e5c1-4e59-b48e-a4fa383640c6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1211ce0f-7a87-497a-9bd1-3e72069ad683"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("127c70a9-d3b2-430b-bb11-8627c82d1c5b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("163cab99-01d6-46b5-a8d2-b12fdf1195f4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("17a21d7c-57f2-4c2f-ae82-f43e8438a610"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("19d1a5cc-f9bd-46cc-aa54-600be0fb7e13"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1adbeb05-c01f-4633-8240-6f963e715e82"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1cae9102-e680-4e31-8a52-1262d60d92cb"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1df22795-d8f4-4a90-90f2-cfd41225b1a1"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("228bd58f-eadb-4e64-b98f-7d3671241db7"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2506138d-72c9-404c-ace2-33c9aedc7209"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2776131b-aaa2-4308-9a34-8d8e014603e2"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2cdea746-5038-42cb-b9e9-02a0c6e95dfa"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2d315bc6-8426-4427-a544-c95961a2dce3"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("305eebe4-8ec2-4a73-b594-395d88139200"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("31c47bab-f713-48e5-a043-40b9ba2d9fc2"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("327a5c34-d3f9-4d6e-a882-7d90c76025e1"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("32f25071-aeeb-4da6-bd1d-fd2a67977a2e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("32fbedda-4445-4391-ba0e-ad78ee3127c6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("34db9c35-af36-4ca0-841e-f9690279297e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3655a092-4a2e-4ca8-99d6-e28d0beaf321"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("39ac9746-2fe7-47d8-9cb8-7acf473969cd"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3a701e32-0760-47b7-a117-8ad74a279ab3"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3dde5cf0-2529-4459-99c7-bc6b3c520564"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("405423ac-7b89-4ee6-a3aa-5b0ffefee51e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("40d69b13-2048-4cec-bae2-88fa84976a76"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("42a953c5-4eda-4198-a2f5-9b897446ce5a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("437a5513-4139-44fc-bccf-41b37dca5dea"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4698a7c9-dcbd-43bc-a5bc-1f5219f64075"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("470d4c8d-c1ff-4995-9a87-2b8e7b957db6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("49b117b9-6f37-475f-8e6a-d71bb3987baf"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4b5cd767-8f21-4bf9-93f4-c840ba0e73f6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4d6aa6c6-b5f2-4ef3-9fdb-e4131cb29d49"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4da8918a-1b0d-4d12-8e48-661491095288"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5512a62c-7e23-49e3-9929-965a62d52427"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5528220f-0232-4c37-90c2-1dedbe790128"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("56de3bb3-a65e-441f-8383-8aa31d512f56"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5c3b9bac-c8f9-4761-a63f-7127236198c1"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5ee5f033-97a3-4fbd-a32a-d9b399d9e881"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("6273fbba-cc38-42d6-b60b-b2f244398712"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("64260ad6-c960-4d22-b95e-d20a3cb08e33"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("65344d9e-19aa-4001-a64d-f23de69f5044"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("68a532d0-e33e-4f94-9542-006fcc3309e2"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("6f919fb3-d6f9-4caf-803f-5b32c9e49233"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("719cdacc-13da-4dcb-86e6-7e5801e09385"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("71c0efae-3fe9-4119-b226-c7f4aa0fc6e2"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("743b68e3-dfb8-474f-aa60-9cc63dc6071b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("74f7941e-814b-4fc9-a480-435840dc72d4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("751b7a00-f9e4-4635-8b60-de0aff9e0a4b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("75959c7d-1b79-4690-a3a2-9f07fffd2f03"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("76690a47-deec-468f-93c3-5f14c165a98f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7a8e5e5a-d378-478d-b365-a968e1cc01ba"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7b8c9784-1f37-4962-abcf-702b0cae9ae2"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7c3adfd7-09f8-4420-8bf9-087c496dae08"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("82675bd7-0c3d-4ac7-b5db-829499349394"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("84cf0618-1c14-4c1d-acfe-48f673585521"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("85bf078b-2c26-4db3-8cb3-320dbb673ff5"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8ad7189c-9d04-4862-8f18-614913bfe33e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8b2f2a6b-3290-4117-bf01-5f7f86a993ae"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8bca23e4-8b14-49b8-93ae-cc3df88dc44a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8d4427b2-0221-4974-a74d-8f66672e851b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8e13081a-36fb-4123-8473-ea9f5a724fb8"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8f9c441c-5ee5-4420-9abb-a89a8014af28"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("958217ed-f437-4877-b10e-ffc1228ccbae"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("97ff6912-8b5c-4bb6-bb23-ba763fc05a68"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("98063063-0919-4c45-b41f-b510ba9ca474"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("98c9e5f8-0b80-4419-bc42-a4f8d45505cd"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("992a641d-a42c-45b5-8930-f5ebbc5103cc"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("99a6a26c-3e62-490b-98ae-bac259593c66"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("9a35ac95-b550-473f-b2e9-56148e2fb1ea"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("9a9e5a85-898b-4c83-8ad0-212953657199"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("9e67b8f6-0937-4568-a234-a18aedc5371e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a40e2b1f-535e-4c80-87b6-18c515a06dfd"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a5d4b31a-ddcc-496f-8c7b-bee3ef6bd0d6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a5f37c4a-a858-4475-b084-be4c39db1c16"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a605a6e1-d217-4eb7-a2e7-378d5bc64a8c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a61f873f-d51c-4583-ae60-bace0dd13c01"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b442bc14-7350-4de1-aab1-789fe8299ee1"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b7e46666-9831-4181-abac-1aaf22a9e546"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ba00213b-c060-4128-a0f7-a3f4e215ceb4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ba8ad172-b528-47db-9230-f59e07e72718"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("babbe0d0-cb1f-4860-b111-0dd8b19ad08b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("bc54758a-6487-40e0-8815-561b12e8b2f5"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("bde156bb-b00f-42d0-a357-b88f97d6bf97"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c03e8a9b-d69a-4948-a5a9-9c65d0898257"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c1f4c0e4-c33c-4367-bd58-e97ce81d7286"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c74ad7d4-06c7-441f-935d-56c69fadcb58"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c7e1a3e2-3f6b-449e-b0a9-0ff62d38fabf"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("cb03e8ed-4d15-4358-8bfd-bb5e9375f1f6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("cc768f89-83fa-468d-aa0b-cb3396bf482b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("cc8a4b10-cd24-4562-a594-274b295e0cf6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("cd326290-da54-4172-afc8-d8f3db53e8d8"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("cdcb7d22-c218-497c-a7e2-29e6085aa449"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ce8711b5-8da2-433f-ad12-e682709c0bb6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d7278691-fffd-4c4c-b791-bd906936682c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d78a8636-5e80-4820-8cde-f83aa46cc4d8"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d991823b-384a-480a-bcd9-6b093e5ae040"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("da03b1a4-ece8-4042-8323-3f5ff37108f6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("dadd06a7-9404-4c77-a003-abf8b6702731"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("dba18c09-5b24-4378-98da-a6f5a677b3fc"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("deb09230-d613-45a8-bf3e-66b4fc453ed0"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e21c437a-7ce2-4e4f-86ee-bf591444852b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e27be3dc-b167-4aa3-99be-36f1b119afd3"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e2d2a645-7945-4f6c-a9de-57018436138a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e2e8733e-90c2-435b-8a0e-d7f6712749e8"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e595162b-7763-4d61-9313-2b1bd783e495"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e6022ef7-a506-438e-bed5-2db05833d986"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e7e05513-5f7e-4eea-bd5e-6dc1a5401318"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("eaa614b5-ed3c-414c-8f1f-87fc4dc6cce9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ead90e21-7ad7-4f58-a057-4632197401d2"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f1a31ed7-0ee2-44cc-8488-c45570d8432b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f50a532b-166c-4e2b-9742-8b89eb4edfb6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f61af45f-e746-4400-abda-70e50d7914d0"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f9dc4eb8-295c-4ef3-aed6-6ccb1704a04e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ff07a54d-c0e8-4c0c-ab4e-24d78ef8b187"));

            migrationBuilder.DropColumn(
                name: "Delivery",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Subtotal",
                table: "Orders");

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
    }
}
