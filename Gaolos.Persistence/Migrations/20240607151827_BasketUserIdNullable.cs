using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gaolos.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class BasketUserIdNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: new Guid("4c443946-fc3f-496d-9b33-8f0842f093c4"));

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: new Guid("dc96d52c-39ba-423a-accf-4ec69c373322"));

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: new Guid("e37733b8-a7ca-4661-889e-3cd63992dd21"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0113de90-946b-4e3c-87d4-f969e32b752b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("01ab38f8-0219-4dd3-90f4-51cfa1b9201e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("02b46a69-6c15-4be5-adf7-c73fb9d15593"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("06902d94-5188-4298-aa04-a3bb6afa6db5"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("07a3e508-2839-4812-a5a9-556020b00adc"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("08d46c65-ebd0-4605-9ce8-9966621be009"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("097cee4e-e270-4209-a12b-cc35ecbe3d65"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("11d10b13-f205-4d90-9c8d-b818e407a4c2"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("12bf0d15-d60f-43b5-80da-4714d9a708c7"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("12ed0879-f325-4dab-aca6-96174b9593f4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("131b3cf7-e50a-489a-9054-e38a06fc094d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1408b088-38db-45b9-9b5d-f3ebe2f5e6e6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1562ba5b-4033-4189-8e59-d99ac55236ae"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("18408312-50af-42d9-b19d-500665f40b96"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("18700d8d-5c1a-4416-8774-f9267b575145"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("196770d9-ea1f-48d6-969a-cf6dd924750e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("19914077-dd28-4da9-8a65-a1583c2aae6e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1cde5fd8-3cc6-4589-8219-b720155adf5d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2658a62d-bd01-45d6-8e5a-d935c16bb71f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("281a9538-ad9e-490b-8b31-9eaa6f0d94e0"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("28f9d8cb-f2ac-435b-b756-45dee8f3ac3a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2b4159c7-5548-443f-9003-d57ccc0c9aad"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2d71bb56-6271-4484-a726-9aced02f3d28"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2da1ce3e-de08-4090-9a5c-c8c491aadcf9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2dc35cc7-61eb-4475-935a-41c136cf3ee0"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("34c4cfa4-ffdd-4c96-a711-9c4080d437e6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("390aa0f4-fe4d-4a7c-af45-023fed3ed3e1"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3d654476-fe16-44d3-84e8-4116a6e8c801"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3eed9b88-d7da-4323-9953-87dc67e333a0"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3f7cc375-e488-4cdb-97ea-d8ea6d0a2488"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3f9327ce-16d8-49ec-add4-53957d25f541"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("41b9c483-b7f1-4ce6-9e96-7c10c65142ee"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("45baf261-04af-48b9-ba11-22ed1cfb8fee"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4f5d1d03-fddf-41dd-92e8-ebab36cf9743"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("54c67513-c1be-4647-b4b0-78fedac3b5f9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5630a76e-5b20-49c2-b84a-342ab7a5000f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("57f59609-0d83-4eff-bef9-2b2eecaae949"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5c9ca2e8-ae76-4c4e-a5c3-a1bf88b5531d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5d0655af-9cec-41bb-aa9b-b03830d84e7c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("6019305f-d2a4-4536-bb98-59bc1393b7d4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("60c93b8e-3de0-46df-aa09-475277175406"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("614be771-d47f-4dcc-b66f-1ba32332cc35"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("6393a244-19b6-40d0-8866-dd4ad472f763"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("660e2c98-3ea9-41da-81f2-a2080c1164e0"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("675d338d-55f5-4a9f-904b-da21467e0f68"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("67e76ffb-1893-4a04-a45e-0eede7887306"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("682eaa70-b5a8-4bc2-8de6-cd889e0ab1df"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("68db50b1-4b5c-4876-a2b9-143b3ede2371"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("6992fbc6-3d13-4d54-a3b7-3bee4c41b7b0"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("6a455856-1d91-4bcf-8df5-8c63380f854a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("70a9e5be-2d3d-4868-b342-0ec5d336dcbe"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7283ad18-5617-4119-ab3e-2d7fd7ef83a5"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7376e04f-05e4-4c29-b717-8e28a3960e6a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("75a65d41-b3dc-47c1-aa51-33c6ea239351"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("77007bdc-0d7d-43cd-9afd-b6b07b4624ee"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7763e725-b972-466c-9140-54a9e66a3340"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("780d05c9-705f-43cc-bedd-59cd9d56c01b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("79daac80-c98f-4e94-ab5f-6c1a23da653b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("79df2d6a-f0e2-4663-bfdf-d2a97bad5358"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7d09e97f-750e-4852-aed0-dc0f2f503f59"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7d23b426-1129-4bba-a464-4a0d2c383192"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("81ea2e81-f1a0-4b7d-b375-3923f16cec21"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("82bd776c-9f67-485e-bbe2-fa6972636506"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("82fc650b-2f31-4582-a085-1c9f5c43aa32"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("858a7fb0-c271-408c-9200-a196f727d463"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8905e68c-dbcb-4471-b48e-c151dfe7e1cb"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("892914f3-156d-464a-a883-6693b0fe68b8"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("899c482c-985f-4994-b03d-50976c29dc5a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8ad0141e-81e9-4c8e-9717-c5e84a1b6c76"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("90a87681-96d4-4e2c-9f5e-0a2776747697"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("96005e52-4bc9-47b7-900d-d6af13d9cf6e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("96beea54-dafd-4591-8a7c-b73379564264"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("97d54c28-6fe7-49bb-920d-05f73d9067b0"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("980a1d2f-a335-4082-be78-94b2a02bfd01"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("9c1e2559-1f02-45cb-86e4-3c50d0b3048c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("9e310146-3730-4d16-9f6d-3b6af370db00"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a0c4ae4e-641d-4c1a-9b90-3e93410224eb"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a28efed5-1861-4ce5-b263-c5f2af23f05c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a80b53af-9ecf-451f-b6ac-14a8310a98ed"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("aad678aa-e085-4a88-801a-5dfb41ca25f0"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ac499447-bfd2-49e7-ac1b-7f11288b25d2"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ad56b23d-8bb1-4adc-8da9-69b8c36215ac"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("af721f73-e253-4b45-b47f-774334ea58f5"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b14c8b66-08fa-49d1-bede-d6b59ca491cd"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b25444cd-5c65-43cf-9b69-1e7bb540d02f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b396eba1-0a54-4e8b-9068-dbc2e61e0bf4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b40d4228-b8e0-43fb-ba8d-6e052fa6dea2"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b502d711-c5bf-484f-8f06-533e9d01c225"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b6169911-1ce5-4203-8210-086d7c7ee622"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b77971f4-4415-4045-8685-58a22a031e48"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b7aa2aac-6b78-48a5-9948-0a8e9fa0a22f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b8f3e942-e021-4e04-9e42-d4ff5233a0a4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("baf30662-fea4-4e6a-a8fd-79016c4dd805"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("bbef6f9b-c753-4c51-8d16-0821248a5f14"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("bf2d4a08-637a-47d9-94b3-497f0dd60dcb"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c0c0bffb-6cc8-40ea-a458-09b270be8e9c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c22299bc-bf82-4659-a629-cd06bb4804bc"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c50b4949-9587-4708-afa2-7327afee1314"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c630f380-9d00-4988-a3e1-dbb600d55d75"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c67081a1-5343-4bcd-a981-673f36fede2e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c82cdd0f-4b73-4918-bffd-cc323ae77cee"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("cc4ee0ac-b005-4325-adf5-e20396d90a67"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("cd2af4f8-082e-4279-93ee-7bebd72b961e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d19e3e1a-9108-4a18-8c44-1573194f71d5"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d2e7f5b8-381c-49b2-af4e-db88f6c0cce6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("da498738-5dec-43e7-87d4-6dbb7d7eed54"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("dbd1ef4f-9912-44aa-9531-cc00c57cd9ec"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("dbe030b4-8e98-4292-b760-55e4d9631bb7"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("dbed62e6-a367-4d0d-b411-e7cfec3a5fa9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("dc02bc2a-72e6-4264-9ff6-2fd2c7475294"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("dea3dce3-dd6c-4683-af89-847100199080"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e0fd0986-8c4d-4f41-aa5a-cbf88e56931f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e469ccc1-1534-4e19-9c70-61e055258f18"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e81503ef-c519-467f-a136-318a6929477b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e9992fe3-789c-4b3e-822c-3ca8985b0b2d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ee104487-3384-4fbe-83f4-facac4d61c00"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ef70362e-8ab1-490c-ac92-56b7dd322f57"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f170187e-9238-4322-b2ab-95172f5be129"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f1d5ca1f-a1fd-43a5-b972-ef1e5892436b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f249f588-ff92-426e-b55e-7542835778f5"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f2efc18e-b019-4aa8-8542-10e117b5f8d6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f443eb77-d5fe-4470-a781-61e6beee8626"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f63811ce-1fad-40ba-829f-9a7a3a47e93e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f70387cc-ce9d-4497-8165-2291aad2165e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("fb69746c-1f05-451b-ae20-a7128103df41"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("fc018130-a259-467b-8222-03a48369c098"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("fc54fa74-b72b-418d-a597-f0945d8a3fd5"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("fd6f6af3-42fc-4ffe-b59e-48f862167153"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Baskets",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "CouponId", "AlreadyUsed", "Code", "CreatedBy", "CreatedDate", "Discount", "LastModifiedBy", "LastModifiedDate" },
                values: new object[,]
                {
                    { new Guid("85887c52-8511-4ac3-960f-932472b061ed"), false, "Awesome", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, null, null },
                    { new Guid("b2f14a42-492c-4a08-ac70-d9668435bf42"), false, "BeNice", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, null, null },
                    { new Guid("fe2b5edf-2307-49c4-a7ce-fc5e80ebf53e"), false, "AlmostFree", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, null, null }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemId", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "MenuId", "Name", "Price", "SubmenuId" },
                values: new object[,]
                {
                    { new Guid("01761248-fb23-4f93-998d-a86e51a565af"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 piece", "https://chickenlicken.co.za/assets/uploads/products/menu/54_just-circle1ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 1", 20.00m, null },
                    { new Guid("0188a0e3-8440-45e2-a943-db7d2477b407"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half Platter", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/f93c9cbe-5f94-4bb4-a937-811c28bd88df", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Big on veg platter", 640.00m, null },
                    { new Guid("018cfd65-1e6a-4f46-ad80-20181d38b7bc"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken fillet + lettuce + tomato\r\n\r\n+ Dreamy Creamy® sauce + a slice of cheese\r\n\r\non a toasted sesame bun", "https://chickenlicken.co.za/assets/uploads/products/menu/9_love-me-tender-cheese-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Tender Cheese Burger", 40.00m, null },
                    { new Guid("09483f19-e499-4639-82ef-ede1aa3d29a8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "21 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/62_family-barrel-circle21ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Family Barrel", 300.00m, null },
                    { new Guid("0988715b-e59e-4278-a5ac-07f40ac0d7d3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes a regular Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/29_love-me-tender-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Tender Top Deluxe", 70.00m, null },
                    { new Guid("0e5f5f81-34f6-4c9f-9bd2-786e4cc79e05"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around a delicious fillet original recipe - a slice of cheese, hash brown, crisp lettuce, fresh tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Colonel Boxmaster", 76.90m, null },
                    { new Guid("11652272-09e2-4b97-896f-8270a783c5cd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "4 Zinger Wings", 48.90m, null },
                    { new Guid("1337270f-d3b8-457a-9100-308d7da8f196"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes a regular Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/31_love-me-hot-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Hot Top Deluxe", 70.00m, null },
                    { new Guid("16a84715-ef11-4073-97e4-20b2e4f9ede6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 pieces of crispy, delicious golden brown Nuggets, paired with 1 delicious Colonel dipping sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "9Pc Nuggets", 42.90m, null },
                    { new Guid("1754fdde-0ffa-4e58-a5f3-a3d2ac94822e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprite Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Sprite Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("1872c945-39f5-4493-93de-79cdf6ec83d4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pulled Chicken Wraps (cut into 6), 3 Chicken Wraps (cut into 6), 2 Sharing Wedges, 16 Winglets, 2 Flame-grilled Mielies cut into 3 (6 portions). Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/ccc05d6a-734b-4fec-bbc7-50a7da7ad2da", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Hands-on delicious platter", 640.00m, null },
                    { new Guid("199b4c71-52e8-4575-9e6f-895878e6601b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new Burger standard…Boxed! The Crispy Zinger burger, 1 piece of original recipe chicken, regular mash & gravy, chips & Buddy no sugar.", "https://images.ctfassets.net/0p42pznmbeec/3spYrESfEqEyv4TaIwhQnZ/e315445416a59f4ba60acf90090482dd/62279_WickedZinger_SF_-_1200x900.png?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Zinger Fully Loaded Buddy Box Meal", 115.90m, null },
                    { new Guid("1ee39270-cb79-475f-865b-89c67479291f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "One and a 1/2 full chickens ( cut into 12), 2 Flame-grilled Mielies cut into 3 (6 portions), 4 Kids Burgers, 2 Sharing Wedges. Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/5182f543-741a-4317-a731-e8098a228c37", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "More to share platter", 640.00m, null },
                    { new Guid("21967ff4-3124-43b7-b7e7-0664c8bf6558"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke No Sugar 1.5 Litre", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke No Sugar 1.5 Litre", 29.90m, null },
                    { new Guid("24696089-27ff-4c1f-8bcf-489fe5d50b8d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 pieces SoulFire® chicken + 1 sachet SoulFire® sauce", "https://chickenlicken.co.za/assets/uploads/products/menu/19_rock-my-soul-circle3cew-straight.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul 3 Straight", 57.00m, null },
                    { new Guid("24b1032a-7d59-4bf1-ba59-eb9ae903bd2a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 Piece + 4 Hotwing®s + 1 Licken Loaf", "https://chickenlicken.co.za/assets/uploads/products/menu/128_soul-square-meal-.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soul Square Meal", 50.00m, null },
                    { new Guid("25235e11-efc6-423a-9357-097bbeb2c35c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "  Square chick’n burger on a toasted square bun with DREAMY CREAMY® sauce and a pickle and cheese", "https://chickenlicken.co.za/assets/uploads/products/menu/36_1-slyder-cheese.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Cheese Slyder", 16.00m, null },
                    { new Guid("28f41a9a-5503-4222-95cc-efa759a0183c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 Hotwings® + a portion of Soul Fries™ + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/16_hotwings-circle6ce-max.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Max", 69.00m, null },
                    { new Guid("2a8cbba6-80dd-437c-8a54-74a20fc3f0f6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extra Hot & Spicy Zinger sauce on the side", "https://images.ctfassets.net/0p42pznmbeec/bEZLbUGmprwC7wW3i0GsS/73b63ef3ac73d2e805688b74cdbc31c0/Hot_n_Spicy_sauce_-_1200x900.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Sauce - Hot & Spicy", 0m, null },
                    { new Guid("2b8ce430-c361-4eb6-a29c-a5369223c06e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy a delicious Crunch Burger an orginal receipe chicken piece with small chips and a buddy no sugar drink", "https://images.ctfassets.net/0p42pznmbeec/3QpxFh5qLJj5GT8dEMW3iZ/3acbea341f4c8d3162163373ff8ed48f/COM2029-streetwise_bucket_for_1.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Crunch Burger Box Buddy", 71.90m, null },
                    { new Guid("2fa8c10c-9a63-4407-b12e-47cb5ac42bc0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Nuggets, 1 Crunch Burger, 1 Small Chips and a Buddy Drink", "https://images.ctfassets.net/0p42pznmbeec/1L5C3sZ1MmaHtuQLewHqYa/5e4ecba1d83ade38d554eba1a7431551/ABC2120-nugget_box_buddy_1.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Nugget Box Buddy Meal", 79.90m, null },
                    { new Guid("322a7b79-b099-454f-85e4-f1db6ed8a36b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The game changer is here, and with a delicious spicy crunch fillet, tomato, lettuce and cheese with tangy dressing all wrapped up in a mini tortilla and grilled to perfection, meal time will never be the same again.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Wrapsta", 42.90m, null },
                    { new Guid("37b3e2a7-4839-4861-9e17-520fd64920b1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes a regular Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/28_big-john-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Big John Top Deluxe", 72.00m, null },
                    { new Guid("38dd42ef-37da-4713-a289-97e64d853ce4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Square chick’n burger on a toasted square bun with DREAMY CREAMY® sauce and a pickle", "https://chickenlicken.co.za/assets/uploads/products/menu/33_1-slyder-original.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Slyder Original", 14.00m, null },
                    { new Guid("3902cb70-ea11-4238-af7d-5af7e9d0109c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fanta Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Fanta Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("39c56a7b-94df-451a-b022-7c0fcf5e2e64"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + a Licken Loaf", "https://chickenlicken.co.za/assets/uploads/products/menu/129_soulsister-2-vibe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Vibe", 40.00m, null },
                    { new Guid("39cffabf-9158-48a1-addf-e65281583699"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken dunked in KFC’s famous honey, ginger and soy sauce!", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Dunked Pops", 36.90m, null },
                    { new Guid("3b68f3d8-5a99-4087-9ccd-39dadaa7e50b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Hotwings", "https://chickenlicken.co.za/assets/uploads/products/menu/3_hotwings-circle12ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "12 Hotwings", 84.00m, null },
                    { new Guid("3b801a93-3fde-4208-a98b-6e9afa652dd5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 pieces + a portion of Soul Fries™ + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/53_soulsister-party-circle5ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Party", 112.00m, null },
                    { new Guid("414522da-9526-4c38-8806-a12dfdf77845"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new Burger standard…Boxed! The new Colonel burger, 1 piece of original recipe chicken, regular mash & gravy, chips & a buddy no sugar drink.", "https://images.ctfassets.net/0p42pznmbeec/31yPC9ryh5KT1pOdwEOOzG/d1e2df6fc99eaf513f84b63f7d475f58/65129_kfc_-_FLBM_cheese_buddy_1200x900.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Fully Loaded Box Meal", 115.90m, null },
                    { new Guid("4945b004-bd72-4663-ac13-6c3fc23b1cba"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Pieces of original recipe chicken cooked to golden perfection and a regular portion of pap & small gravy.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Two with Pap", 49.90m, null },
                    { new Guid("4960e17d-aaa0-4ac6-9357-d30cdaa68d38"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Square chick’n burgers on toasted square buns with DREAMY CREAMY® sauce and a pickle", "https://chickenlicken.co.za/assets/uploads/products/menu/34_2-slyders-original.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "2 Original Slyders", 27.00m, null },
                    { new Guid("4b4f1ab1-4930-450e-97a8-7895565ffbac"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/49_soulsister-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister", 43.00m, null },
                    { new Guid("4b809180-ca96-44b6-89d3-1c1352acfb29"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8 Hotwings + toast + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/66_hotwings-meal-max-circle8ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Hotwings Meal Max", 90.00m, null },
                    { new Guid("4f54fa90-2dd3-47e6-8aae-d8598fcedfab"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy a piece of original recipe chicken, 2 zinger wings and a small scrumptious chips.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Bucket For One", 46.90m, null },
                    { new Guid("4f9e6b88-3df6-41ee-be33-19a136c10d03"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes a regular Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/32_love-me-hot-cheese-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Hot Cheese Top Deluxe", 72.00m, null },
                    { new Guid("50a9b560-40df-4cf3-bbe4-a95b02266617"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces of crispy, delicious golden brown Nuggets, paired with 1 delicious Colonel dipping sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "6Pc Nuggets", 36.90m, null },
                    { new Guid("55b9612d-6125-4183-9dd8-fd946c31af53"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Original Slyders® + a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/44_slyder-snack-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Slyder Snack", 30.00m, null },
                    { new Guid("5b0bfde5-2a01-4d27-93a6-25f8dfe890f1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/57_just-circle4ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 4", 80.00m, null },
                    { new Guid("5c4cefee-6b6b-499a-a0f4-1ce94df7f2e4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Pieces of Original Recipe Chicken and Small Chips or Coleslaw.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Two with Chips", 49.90m, null },
                    { new Guid("63d56ad9-81a0-4186-80ef-683a7a82cb95"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get yourself a Streetwise 5, with 2 Buddy No Sugar", "https://images.ctfassets.net/0p42pznmbeec/2uwM3hjbse4hzaZv6d5peO/576343077547dc714bf02883a79589f6/ICM1009-streetwise_5_chips.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Streetwise 5 Buddy", 143.90m, null },
                    { new Guid("6440f5cf-65eb-4fab-8b9b-4893cd752473"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Hotwings® + 4 Sliders®\r\n\r\n+ 2 regular Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/23_soul-mates-classic-party.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soul Mates Classic Party", 145.00m, null },
                    { new Guid("6a7a1f31-f9d3-46d8-8f0f-fe306f8ed4bc"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken that are tender on the inside and crunchy on the outside. Served with a generous sprinkle of fruit chutney flavour.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Sprinkle Pops", 54.90m, null },
                    { new Guid("6d420987-133d-4516-b160-b078408455b9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Square chick’n burger on a toasted square bun with SOULFIRENAISE™ sauce and a pickle", "https://chickenlicken.co.za/assets/uploads/products/menu/39_1-slyder-chilli.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Slyder Chilli", 14.00m, null },
                    { new Guid("703e97ba-a67b-4335-bbeb-5082ae67d9ea"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy 4 pieces of original recipe chicken, 2 small chips, 1 small pops & 2 buddy no sugar drinks.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "2 Can Dine Buddy", 164.90m, null },
                    { new Guid("7098beba-a697-4d77-a1af-2a3a307097e6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "24 Zinger Wings Bucket", 194.90m, null },
                    { new Guid("70f006bc-1fdb-41f0-bf3b-c1ee1f32ee9c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/60_chicken-inn-circle9ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Chicken Inn", 150.00m, null },
                    { new Guid("70ff6447-eca2-4f9a-a2d0-da820d581c6e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken fillet + lettuce + tomato\r\n\r\n+ Dreamy Creamy® sauce on a toasted sesame bun", "https://chickenlicken.co.za/assets/uploads/products/menu/7_love-me-tender-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Tender", 37.00m, null },
                    { new Guid("7149f4bc-9a72-4f13-b135-1a8510c59bbd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 Hotwings® + a portion of Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/15_hotwings-circle6ce-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Deluxe", 67.00m, null },
                    { new Guid("7490770e-811b-461f-9d71-af6280b615db"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of creamy mash and our delicious gravy.", "https://images.ctfassets.net/0p42pznmbeec/16hT15F1AVhciJyE32xbGE/f83f8d8d906a2593420739e995086bc4/MAG1003-reg_mash___gravy.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Large Mash & Gravy", 27.90m, null },
                    { new Guid("74bd55b2-2c66-46ad-94a3-21313c0fd2c3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wrapsta, 1 Piece of Original Recipe Chicken, Small Chips & Buddy Drink", "https://images.ctfassets.net/0p42pznmbeec/2snvT5LNlzizE6TGQ9KN4F/3f5c8ebf26502ad1bdf5a1cc456ccfc0/ABC1723-wrapsta_box_buddy.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Wrapsta Box Meal", 84.90m, null },
                    { new Guid("75d7d6b0-19a7-4876-a92d-d19c3742eb2e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + a portion of Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/50_soulsister-circle2ce-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Deluxe", 62.00m, null },
                    { new Guid("793d34bc-b98c-4561-a859-99502b50e94e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 Piece Chicken", "https://images.ctfassets.net/0p42pznmbeec/2XhP71I12p5tncjyX1P81w/d94f9543674f4728165031f42dcb2653/ALA1001-1pc_cob.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "1 Piece Chicken", 26.90m, null },
                    { new Guid("7c3bd244-1678-4688-a747-93b0c99bc8aa"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chocolate Milkshake", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Chocolate Milkshake", 31.90m, null },
                    { new Guid("7daac64f-76e5-4ff4-aef2-47bb84ec3bd5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An icy sippable treat with Berry bitz, and creamy soft-serve.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Verry Berry Krusher", 42.90m, null },
                    { new Guid("7e144443-d472-4a98-a9e6-3322a98a8356"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken fillet + lettuce + tomato\r\n\r\n+ Soulfirenaise™ sauce + a slice of cheese\r\n\r\non a toasted sesame bun", "https://chickenlicken.co.za/assets/uploads/products/menu/12_love-me-hot-cheese-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Hot Cheese Burger", 40.00m, null },
                    { new Guid("8117149b-1831-486f-bcf5-03c135170656"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10pc Chicken, 2 snack burgers, 4 Zinger Wings, 2 Reg Coleslaw, 2 Reg chips", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "10 Piece Family Treat", 316.90m, null },
                    { new Guid("8326fadd-ee87-4a3d-b548-2e14e8a01f5e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 pieces SoulFire® chicken + a portion of Soul Fries™\r\n\r\n+ 1 sachet SoulFire® sauce ", "https://chickenlicken.co.za/assets/uploads/products/menu/20_rock-my-soul-circle3ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul 3 Combo", 60.00m, null },
                    { new Guid("85e8938d-8f66-4dc4-815a-5829da3e8070"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/55_just-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 2", 39.00m, null },
                    { new Guid("8633e504-dedb-42da-a9d7-69cebfdbc75c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A spicy, crunchy mini fillet with a slice of cheese and lettuce, covered in tangy dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Crunch Burger", 36.90m, null },
                    { new Guid("86ca2c0f-e218-4a49-844c-5eb4bdab0cbe"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Two full chickens (cut into 16), 16 Winglets, 2 Flame-grilled Mielies cut into 3 (6 portions), 2 Sharing Wedges. Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/fa60cb07-3c21-4718-8f02-cb91fd83319b", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Peri-er Platter", 640.00m, null },
                    { new Guid("89bd50c8-0981-473f-8e3d-ea1d61ed9901"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 Hotwings® + a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/14_hotwings-soul-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Soul", 50.00m, null },
                    { new Guid("8b6fddd5-ba04-4f58-8ef9-51b1157f3dd3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy KFC`s new Jalapeno loaded fries with brand new Hot * spicy sauce", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Jalapeno Loaded Fries", 32.90m, null },
                    { new Guid("8cb2ca9d-595c-43d5-9e5a-9101e5b5bcb0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 pieces + a portion of Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/52_soulsister-party-circle4ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Party", 84.00m, null },
                    { new Guid("8e600125-240a-4532-94dc-18af742d931c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke 1.5 Litre Bottle", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke 1.5 Litre Bottle", 32.90m, null },
                    { new Guid("9570ebfa-bb49-4ed4-bfce-b13ac5424635"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A generous sharing platter of 4 succulent Flame-grilled Shisanyama Chicken Sosaties and 20 Winglets, served with 2 portions of our Sharing Wedges, 2 Garlic Rolls and our special PERinase dip.", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/3d93a55d-440a-407c-8b7b-97cc1e6c510a", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Cabo Sosatie Snack Platter", 349.00m, null },
                    { new Guid("957c13a2-4f5e-4a13-ac52-0fcf3c8dc789"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new standard in burgers! 2 Spicy, crunchy mini fillets with 2 cheese slices, lettuce & tomato covered in tangy dressing on a burger bun", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Double Crunch Burger", 68.90m, null },
                    { new Guid("99bcb380-1a33-4e34-82aa-9abe852b87da"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "10 Hot Zinger Wings", 89.90m, null },
                    { new Guid("a407139a-0061-44a0-8a5f-7daa9d78b256"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 KFC famous Zinger Wings dunked in a delicious honey, ginger and soy sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "10 Dunked Wings", 104.90m, null },
                    { new Guid("a44fda2f-840f-4906-b5f7-10a78a8aa0a9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 Pieces of Original Recipe chicken cooked to golden perfection and a large portion of chips or coleslaw.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Five", 121.90m, null },
                    { new Guid("a49bf7d9-816f-4e3e-bd4f-0f09a7f96ab9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken that are tender on the inside and crunchy on the outside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Small Pops", 29.90m, null },
                    { new Guid("a6801292-ff4f-455b-9740-727bee228bf7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bonaqua Still Spring Water 500ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Bonaqua Still Spring Water 500ml", 19.90m, null },
                    { new Guid("a6bc4cf8-e444-42c0-b1aa-609b0fd96de8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/58_just-circle5ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 5", 99.00m, null },
                    { new Guid("a7b5ed20-2893-481a-b98b-b66944eef7f3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of creamy mash and our delicious gravy.", "https://images.ctfassets.net/0p42pznmbeec/16hT15F1AVhciJyE32xbGE/f83f8d8d906a2593420739e995086bc4/MAG1003-reg_mash___gravy.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Mash & Gravy", 19.90m, null },
                    { new Guid("a80ca283-d6a8-4eda-92ae-68392021cd04"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8pc Chicken, 2 snack burgers, 4 Zinger Wings, 2 Reg Coleslaw, 2 Reg chips", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "8 Piece Family Treat", 274.90m, null },
                    { new Guid("a9371c3d-c99b-4d11-98e4-212d716e6670"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Try the new standard! The New Crispy Zinger burger, Our trademark real chicken fillet; A fresh Brioche bun, New Hot & Spicy sauce and cheese on a fresh bed of lettuce & succulent tomatoes", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Zinger Burger", 60.90m, null },
                    { new Guid("abca4524-7544-4ed9-a36b-f2d93cbabba2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8 pieces + 2 regular Soul Fries™\r\n\r\n+ 2 regular Soulslaw® / Achaar / Tomato Salsa\r\n\r\n+ 2 Licken Loafs®", "https://chickenlicken.co.za/assets/uploads/products/menu/25_family-full-house-circle8ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Family Full House", 173.00m, null },
                    { new Guid("ad531713-5b6b-401f-8258-2d70670a44e4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around 2 deliciously crispy new and improved chicken strips, shredded crisp lettuce, sliced tomato, topped with Colonel dressing and sweet chilli sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Sweet Chilli Twister", 66.90m, null },
                    { new Guid("adf4dc3d-6cb3-4dd4-b9b3-b1b93efc6659"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 SoulBites® + a portion of Soul Fries™ + a sachet of either \r\n\r\nUncle Jessups Ketchup®, SoulFire® sauce or Soulfirennaise™  sauce", "https://chickenlicken.co.za/assets/uploads/products/menu/125_soulbites-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Soul Bites Snack", 30.00m, null },
                    { new Guid("af3b96f5-1548-43c7-b47f-2d3e5792a87e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Hotwings® + a Slider®\r\n\r\n+ a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/47_soul-mix-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Soul Mix Snack", 30.00m, null },
                    { new Guid("b0a3d9ee-30bb-43af-a61a-6803be6ec70f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around 2 deliciously crispy chicken strips, shredded crisp lettuce, sliced tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Classic Twister", 66.90m, null },
                    { new Guid("b1b05ac1-13c3-4cd4-abf5-3b1c4d3677c5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get yourself a Streetwise 1, with a Buddy no sugar free drink", "https://images.ctfassets.net/0p42pznmbeec/3QpxFh5qLJj5GT8dEMW3iZ/3acbea341f4c8d3162163373ff8ed48f/COM2029-streetwise_bucket_for_1.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Streetwise 1 Buddy", 52.90m, null },
                    { new Guid("b2a560a1-a871-407f-a956-2acd911c78db"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + toast + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/64_lunch-meal-max.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Lunch Meal Max", 76.00m, null },
                    { new Guid("b314fda6-e7d0-44d4-b421-c5db4bbf84fa"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An icy sippable treat with Oreo bitz, and creamy soft-serve.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Oreo Krusher", 42.90m, null },
                    { new Guid("b4f8b75a-943c-4ffc-a5aa-30e267fce132"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "24 Zinger Wings Bucket", 194.90m, null },
                    { new Guid("b78dc269-875b-42f7-8054-c93c8d4c97c9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Hotwings® + a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/46_hotwings-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Hotwings Snack", 30.00m, null },
                    { new Guid("b7dcca72-d148-4db6-8682-90b913479aa9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca-Cola Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coca-Cola Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("ba6926a2-2c5e-42cf-a6ce-d22c4ee0bae1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 SoulBites®", "https://chickenlicken.co.za/assets/uploads/products/menu/124_soulbites-circle9ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a9"), "Soul Bites Max", 45.00m, null },
                    { new Guid("bb8851b6-f40e-461d-97ea-bd311bc565a8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 Hotwings® + a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/18_feed-my-craving-circle10ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Feed My Craving", 79.00m, null },
                    { new Guid("bd131876-da83-40a7-82d7-4a204ba88b32"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Popcorn Chicken® in a shaker cup\r\n\r\n+ 2 sachets SoulFire® sauce or\r\n\r\n2 sachets of Uncle Jessup’s® Ketchup\r\n\r\nto shake up the taste!", "https://chickenlicken.co.za/assets/uploads/products/menu/45_popcorn-chicken-shaker.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Popcorn Chicken Shaker", 30.00m, null },
                    { new Guid("bd755214-0935-4e38-884c-4289dba7a4d4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken fillet + lettuce + tomato\r\n\r\n+ Soulfirenaise™ sauce on a toasted sesame bun", "https://chickenlicken.co.za/assets/uploads/products/menu/10_love-me-hot-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Hot", 37.00m, null },
                    { new Guid("bf0cae70-d88a-4a78-bb33-a27044dee2d8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke No Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke No Sugar Buddy 440ml", 22.90m, null },
                    { new Guid("bf5ad1a3-29a1-446a-8745-40a6adda1966"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken, tender on the inside and crunchy on the outside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Large Pops", 54.90m, null },
                    { new Guid("bfb536c8-486d-43fe-a0ff-37652bc275fa"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8 Hotwings + toast + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/65_hotwings-meal-circle8ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Hotwings Meal", 86.00m, null },
                    { new Guid("c606f77e-fcd1-4b6c-8fcb-3fd97ba6fb05"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A delicious chicken patty served with shredded lettuce & Colonel dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Snack Burger", 29.90m, null },
                    { new Guid("c6c126c0-7f50-4bec-9953-0ca69762a3e7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pieces of original recipe chicken, a portion of small chips.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Three with Chips", 72.90m, null },
                    { new Guid("c71660da-b932-4b5b-bc57-8955120b112a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/61_family-bucket-circle15ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Family Bucket", 230.00m, null },
                    { new Guid("c7a73b8e-e6ab-4a77-b3f5-ce5463d26372"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milk shake milk shake shake shake", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Strawberry Milkshake", 31.90m, null },
                    { new Guid("c89c8425-6b96-4a46-9922-e9619eeea33b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 KFC famous Zinger Wings dunked in a delicious honey, ginger and soy sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "4 Dunked Wings", 54.90m, null },
                    { new Guid("c98e0a3b-518a-4cbb-9e5f-94d13c02e2d9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Hotwings", "https://chickenlicken.co.za/assets/uploads/products/menu/4_hotwings-circle24ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "24 Hotwings", 168.00m, null },
                    { new Guid("caa4cc2a-89a4-45e7-8ef2-9d907d766338"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 Hotwings", "https://chickenlicken.co.za/assets/uploads/products/menu/98_hotwings-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "6 Hotwings", 42.00m, null },
                    { new Guid("d131cf42-c69c-4699-a78e-b8b32ce45252"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crunch Burger, 1 Piece of Original Recipe Chicken, 2 Zinger Wings, Small Chips & Buddy Drink", "https://images.ctfassets.net/0p42pznmbeec/2tpR61h0KxupmA8U024fwu/55f538f6ae4384b9bbdf598435d6ea53/ABC1696-all_star_box_buddy.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "All Star Box Meal Buddy", 94.90m, null },
                    { new Guid("d1c6b773-3903-4137-a27b-a612c0b14ccb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces + 2 regular Soul Fries™\r\n\r\n+ 2 regular Soulslaw® / Achaar / Tomato Salsa\r\n\r\n+ 2 Licken Loafs®", "https://chickenlicken.co.za/assets/uploads/products/menu/24_family-full-house-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Family Full House", 143.00m, null },
                    { new Guid("d2e4909b-04a6-41e2-b8a7-5a0d085f5772"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pieces of Original Recipe Chicken with a portion of pap and gravy", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Three with Pap", 72.90m, null },
                    { new Guid("d64e90d1-912d-4e80-8aed-0dff46ad7f37"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/56_just-circle3ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 3", 60.00m, null },
                    { new Guid("d6d39232-9a30-4131-8abd-ac79afa9bbbd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Try the new standard! The New Colonel burger, Our trademark real chicken fillet; A fresh Brioche bun, Creamy Colonel sauce and cheese on a fresh bed of lettuce & succulent tomatoes", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Colonel Burger", 60.90m, null },
                    { new Guid("d91c84eb-c21e-4252-941b-28a7ad5d59eb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", "https://images.ctfassets.net/0p42pznmbeec/4J7RauzcyD6KkQu9Qhpp28/da6827d46db9161d26ae26c874be5123/ABC1247-sml_chips.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Small Chips", 16.90m, null },
                    { new Guid("d97052d7-98df-4072-a854-3a871379350b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy 6 pieces of delicious original recipe chicken, 1 large chips, 1 regular coleslaw plus 2 regular mash and gravies.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "All In One Feast", 194.90m, null },
                    { new Guid("db25da73-e0dd-4713-91f0-7fc5fbc40082"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oven baked, fresh mini loaf", "https://images.ctfassets.net/0p42pznmbeec/2X0ukPSNX6j4kHDE2o2mGa/e910e8f156eb5ca37642fb19944603a0/MIS1001-1_mini_loaf.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Mini Loaf", 14.90m, null },
                    { new Guid("dc617cb3-90c4-4c55-8028-2ef63665f8c7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs and spices of Original Recipe® chicken, marinated and cooked to perfection.", "https://images.ctfassets.net/0p42pznmbeec/2ZE6o3XzzI7YzGsVVT4ubY/e95c55d0c1b050b91a2b070a5ad1b32e/9_piece_bucket.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1"), "9 Piece Bucket", 182.90m, null },
                    { new Guid("dcc28ee2-2482-4a58-a252-764ecf35ad90"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces SoulFire® chicken + 1 regular Soul Fries™\r\n\r\n+ 2 sachets SoulFire® sauce", "https://chickenlicken.co.za/assets/uploads/products/menu/21_rock-my-soul-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul", 105.00m, null },
                    { new Guid("dd6004ca-f1a9-4a22-86b2-0656f548e878"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "16 Hotwings® + 2 regular Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/17_hotwings-party-circle16ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Party", 132.00m, null },
                    { new Guid("e214a8a8-2c9f-4833-8af0-ebe5255fbb31"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around a delicious fillet zinger recipe - a slice of cheese, hash brown, crisp lettuce, fresh tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Zinger Boxmaster", 76.90m, null },
                    { new Guid("e44aa748-45a5-45fd-a47f-e5c65752e342"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of freshly prepared cabbage, onions and carrots in a delicious dressing", "https://images.ctfassets.net/0p42pznmbeec/1LvCxHqjAFXs2XFgAbQpnG/44719dee762ff4f7106e33d8c4f300f9/ABC2225-reg_coleslaw.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Coleslaw", 24.90m, null },
                    { new Guid("e9cd515e-b769-4e93-8892-d0e82b0c22ac"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes a regular Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/30_love-me-tender-cheese-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Tender Cheese Top Deluxe", 72.00m, null },
                    { new Guid("eb558b90-792d-429c-8b88-1f13fc3ceeed"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", "https://images.ctfassets.net/0p42pznmbeec/23emjPvgiS9FE3xT6UiBa/9a5d9ceffa02d18a26679472e7f62cfc/CHI1001-reg_chips.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Chips", 26.90m, null },
                    { new Guid("ebbba262-ad19-42fa-83d6-d8dbbf922670"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", "https://images.ctfassets.net/0p42pznmbeec/5Zt1jvrey6zim41HKaarJr/6c4e0a08f94a83f04ad98dc130ce67e1/CHI1002-lrg_chips.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Large Chips", 0m, null },
                    { new Guid("eca5558a-48f2-4714-9203-5eb19cc15c1e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "36 Hotwings", "https://chickenlicken.co.za/assets/uploads/products/menu/5_hotwings-circle36ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "36 Hotwings", 231.00m, null },
                    { new Guid("ecfa4352-e320-4e65-a53f-a9aaa20e1308"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + toast + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/63_lunch-meal.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Lunch Meal", 73.00m, null },
                    { new Guid("eec99701-c88f-4952-bba0-95901dff3b74"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Chicken Bresteaks® + lettuce + a slice of cheese\r\n\r\n+ 3 pickles + Dreamy Creamy® sauce\r\n\r\non a toasted sesame bun", "https://chickenlicken.co.za/assets/uploads/products/menu/13_big-john-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Big John", 42.00m, null },
                    { new Guid("f2315c7c-8dfc-4f33-8318-3892fa280d0e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Cappy Juice 1.5 Litre", 44.90m, null },
                    { new Guid("f3338911-63ad-4913-b204-4bae4f2f855d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A delicious chicken patty served with shredded lettuce & Colonel dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Snack Burger", 29.90m, null },
                    { new Guid("f811bcf3-b60c-4f4e-a6b1-529e2af8006a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 SoulBites®", "https://chickenlicken.co.za/assets/uploads/products/menu/123_soulbites-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a9"), "Soul Bites", 38.00m, null },
                    { new Guid("f99fd509-838c-4df3-b5ea-a14dd46f3e5e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs & spices.", "https://images.ctfassets.net/0p42pznmbeec/WKTb7n2vvpdYR1v8mvXX0/4d01e6a6cf892c116f2e82bdd4b64b6a/66752_-_E-Commerce_15_pc_Bucket_1200x900.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1"), "15 Piece Bucket", 279.90m, null },
                    { new Guid("fb6cd346-1961-4d46-ba7d-f2ab17068a1f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Veg Burgers, 2 Halloumi & Roast Veg Wraps, 2 Halloumi & Roast Veg Pitas, 2 Sharing Wedges, 4 Flame-grilled Mielies cut into 3 (12 portions). Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/3b7bc5aa-eb6c-4f3b-a289-ae9669f410dd", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Veggie veggie nice platter", 640.00m, null },
                    { new Guid("feb6da23-d9f9-4294-9c36-2dded78b3413"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + a portion of Soul Fries™ + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/51_soulsister-circle2ce-max.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Max", 65.00m, null },
                    { new Guid("fed614a0-79f7-4d37-9798-02bfde370a83"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/59_just-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 6", 120.00m, null },
                    { new Guid("ffe3857b-28ae-4b8d-989d-ed5391d31606"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Love Me Tender® Burger + a regular Soul Fries™\r\n\r\n+ 2 Hotwings® + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/22_soulman-load-up.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soulman Load Up", 80.00m, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: new Guid("85887c52-8511-4ac3-960f-932472b061ed"));

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: new Guid("b2f14a42-492c-4a08-ac70-d9668435bf42"));

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: new Guid("fe2b5edf-2307-49c4-a7ce-fc5e80ebf53e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("01761248-fb23-4f93-998d-a86e51a565af"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0188a0e3-8440-45e2-a943-db7d2477b407"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("018cfd65-1e6a-4f46-ad80-20181d38b7bc"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("09483f19-e499-4639-82ef-ede1aa3d29a8"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0988715b-e59e-4278-a5ac-07f40ac0d7d3"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0e5f5f81-34f6-4c9f-9bd2-786e4cc79e05"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("11652272-09e2-4b97-896f-8270a783c5cd"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1337270f-d3b8-457a-9100-308d7da8f196"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("16a84715-ef11-4073-97e4-20b2e4f9ede6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1754fdde-0ffa-4e58-a5f3-a3d2ac94822e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1872c945-39f5-4493-93de-79cdf6ec83d4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("199b4c71-52e8-4575-9e6f-895878e6601b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1ee39270-cb79-475f-865b-89c67479291f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("21967ff4-3124-43b7-b7e7-0664c8bf6558"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("24696089-27ff-4c1f-8bcf-489fe5d50b8d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("24b1032a-7d59-4bf1-ba59-eb9ae903bd2a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("25235e11-efc6-423a-9357-097bbeb2c35c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("28f41a9a-5503-4222-95cc-efa759a0183c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2a8cbba6-80dd-437c-8a54-74a20fc3f0f6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2b8ce430-c361-4eb6-a29c-a5369223c06e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2fa8c10c-9a63-4407-b12e-47cb5ac42bc0"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("322a7b79-b099-454f-85e4-f1db6ed8a36b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("37b3e2a7-4839-4861-9e17-520fd64920b1"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("38dd42ef-37da-4713-a289-97e64d853ce4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3902cb70-ea11-4238-af7d-5af7e9d0109c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("39c56a7b-94df-451a-b022-7c0fcf5e2e64"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("39cffabf-9158-48a1-addf-e65281583699"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3b68f3d8-5a99-4087-9ccd-39dadaa7e50b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3b801a93-3fde-4208-a98b-6e9afa652dd5"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("414522da-9526-4c38-8806-a12dfdf77845"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4945b004-bd72-4663-ac13-6c3fc23b1cba"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4960e17d-aaa0-4ac6-9357-d30cdaa68d38"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4b4f1ab1-4930-450e-97a8-7895565ffbac"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4b809180-ca96-44b6-89d3-1c1352acfb29"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4f54fa90-2dd3-47e6-8aae-d8598fcedfab"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4f9e6b88-3df6-41ee-be33-19a136c10d03"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("50a9b560-40df-4cf3-bbe4-a95b02266617"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("55b9612d-6125-4183-9dd8-fd946c31af53"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5b0bfde5-2a01-4d27-93a6-25f8dfe890f1"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5c4cefee-6b6b-499a-a0f4-1ce94df7f2e4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("63d56ad9-81a0-4186-80ef-683a7a82cb95"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("6440f5cf-65eb-4fab-8b9b-4893cd752473"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("6a7a1f31-f9d3-46d8-8f0f-fe306f8ed4bc"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("6d420987-133d-4516-b160-b078408455b9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("703e97ba-a67b-4335-bbeb-5082ae67d9ea"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7098beba-a697-4d77-a1af-2a3a307097e6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("70f006bc-1fdb-41f0-bf3b-c1ee1f32ee9c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("70ff6447-eca2-4f9a-a2d0-da820d581c6e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7149f4bc-9a72-4f13-b135-1a8510c59bbd"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7490770e-811b-461f-9d71-af6280b615db"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("74bd55b2-2c66-46ad-94a3-21313c0fd2c3"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("75d7d6b0-19a7-4876-a92d-d19c3742eb2e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("793d34bc-b98c-4561-a859-99502b50e94e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7c3bd244-1678-4688-a747-93b0c99bc8aa"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7daac64f-76e5-4ff4-aef2-47bb84ec3bd5"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7e144443-d472-4a98-a9e6-3322a98a8356"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8117149b-1831-486f-bcf5-03c135170656"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8326fadd-ee87-4a3d-b548-2e14e8a01f5e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("85e8938d-8f66-4dc4-815a-5829da3e8070"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8633e504-dedb-42da-a9d7-69cebfdbc75c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("86ca2c0f-e218-4a49-844c-5eb4bdab0cbe"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("89bd50c8-0981-473f-8e3d-ea1d61ed9901"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8b6fddd5-ba04-4f58-8ef9-51b1157f3dd3"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8cb2ca9d-595c-43d5-9e5a-9101e5b5bcb0"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8e600125-240a-4532-94dc-18af742d931c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("9570ebfa-bb49-4ed4-bfce-b13ac5424635"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("957c13a2-4f5e-4a13-ac52-0fcf3c8dc789"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("99bcb380-1a33-4e34-82aa-9abe852b87da"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a407139a-0061-44a0-8a5f-7daa9d78b256"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a44fda2f-840f-4906-b5f7-10a78a8aa0a9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a49bf7d9-816f-4e3e-bd4f-0f09a7f96ab9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a6801292-ff4f-455b-9740-727bee228bf7"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a6bc4cf8-e444-42c0-b1aa-609b0fd96de8"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a7b5ed20-2893-481a-b98b-b66944eef7f3"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a80ca283-d6a8-4eda-92ae-68392021cd04"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a9371c3d-c99b-4d11-98e4-212d716e6670"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("abca4524-7544-4ed9-a36b-f2d93cbabba2"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ad531713-5b6b-401f-8258-2d70670a44e4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("adf4dc3d-6cb3-4dd4-b9b3-b1b93efc6659"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("af3b96f5-1548-43c7-b47f-2d3e5792a87e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b0a3d9ee-30bb-43af-a61a-6803be6ec70f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b1b05ac1-13c3-4cd4-abf5-3b1c4d3677c5"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b2a560a1-a871-407f-a956-2acd911c78db"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b314fda6-e7d0-44d4-b421-c5db4bbf84fa"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b4f8b75a-943c-4ffc-a5aa-30e267fce132"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b78dc269-875b-42f7-8054-c93c8d4c97c9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b7dcca72-d148-4db6-8682-90b913479aa9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ba6926a2-2c5e-42cf-a6ce-d22c4ee0bae1"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("bb8851b6-f40e-461d-97ea-bd311bc565a8"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("bd131876-da83-40a7-82d7-4a204ba88b32"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("bd755214-0935-4e38-884c-4289dba7a4d4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("bf0cae70-d88a-4a78-bb33-a27044dee2d8"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("bf5ad1a3-29a1-446a-8745-40a6adda1966"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("bfb536c8-486d-43fe-a0ff-37652bc275fa"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c606f77e-fcd1-4b6c-8fcb-3fd97ba6fb05"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c6c126c0-7f50-4bec-9953-0ca69762a3e7"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c71660da-b932-4b5b-bc57-8955120b112a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c7a73b8e-e6ab-4a77-b3f5-ce5463d26372"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c89c8425-6b96-4a46-9922-e9619eeea33b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c98e0a3b-518a-4cbb-9e5f-94d13c02e2d9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("caa4cc2a-89a4-45e7-8ef2-9d907d766338"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d131cf42-c69c-4699-a78e-b8b32ce45252"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d1c6b773-3903-4137-a27b-a612c0b14ccb"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d2e4909b-04a6-41e2-b8a7-5a0d085f5772"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d64e90d1-912d-4e80-8aed-0dff46ad7f37"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d6d39232-9a30-4131-8abd-ac79afa9bbbd"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d91c84eb-c21e-4252-941b-28a7ad5d59eb"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d97052d7-98df-4072-a854-3a871379350b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("db25da73-e0dd-4713-91f0-7fc5fbc40082"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("dc617cb3-90c4-4c55-8028-2ef63665f8c7"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("dcc28ee2-2482-4a58-a252-764ecf35ad90"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("dd6004ca-f1a9-4a22-86b2-0656f548e878"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e214a8a8-2c9f-4833-8af0-ebe5255fbb31"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e44aa748-45a5-45fd-a47f-e5c65752e342"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e9cd515e-b769-4e93-8892-d0e82b0c22ac"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("eb558b90-792d-429c-8b88-1f13fc3ceeed"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ebbba262-ad19-42fa-83d6-d8dbbf922670"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("eca5558a-48f2-4714-9203-5eb19cc15c1e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ecfa4352-e320-4e65-a53f-a9aaa20e1308"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("eec99701-c88f-4952-bba0-95901dff3b74"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f2315c7c-8dfc-4f33-8318-3892fa280d0e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f3338911-63ad-4913-b204-4bae4f2f855d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f811bcf3-b60c-4f4e-a6b1-529e2af8006a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f99fd509-838c-4df3-b5ea-a14dd46f3e5e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("fb6cd346-1961-4d46-ba7d-f2ab17068a1f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("feb6da23-d9f9-4294-9c36-2dded78b3413"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("fed614a0-79f7-4d37-9798-02bfde370a83"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ffe3857b-28ae-4b8d-989d-ed5391d31606"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Baskets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "CouponId", "AlreadyUsed", "Code", "CreatedBy", "CreatedDate", "Discount", "LastModifiedBy", "LastModifiedDate" },
                values: new object[,]
                {
                    { new Guid("4c443946-fc3f-496d-9b33-8f0842f093c4"), false, "AlmostFree", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, null, null },
                    { new Guid("dc96d52c-39ba-423a-accf-4ec69c373322"), false, "BeNice", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, null, null },
                    { new Guid("e37733b8-a7ca-4661-889e-3cd63992dd21"), false, "Awesome", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, null, null }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemId", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "MenuId", "Name", "Price", "SubmenuId" },
                values: new object[,]
                {
                    { new Guid("0113de90-946b-4e3c-87d4-f969e32b752b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Try the new standard! The New Crispy Zinger burger, Our trademark real chicken fillet; A fresh Brioche bun, New Hot & Spicy sauce and cheese on a fresh bed of lettuce & succulent tomatoes", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Zinger Burger", 60.90m, null },
                    { new Guid("01ab38f8-0219-4dd3-90f4-51cfa1b9201e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A delicious chicken patty served with shredded lettuce & Colonel dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Snack Burger", 29.90m, null },
                    { new Guid("02b46a69-6c15-4be5-adf7-c73fb9d15593"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Popcorn Chicken® in a shaker cup\r\n\r\n+ 2 sachets SoulFire® sauce or\r\n\r\n2 sachets of Uncle Jessup’s® Ketchup\r\n\r\nto shake up the taste!", "https://chickenlicken.co.za/assets/uploads/products/menu/45_popcorn-chicken-shaker.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Popcorn Chicken Shaker", 30.00m, null },
                    { new Guid("06902d94-5188-4298-aa04-a3bb6afa6db5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", "https://images.ctfassets.net/0p42pznmbeec/4J7RauzcyD6KkQu9Qhpp28/da6827d46db9161d26ae26c874be5123/ABC1247-sml_chips.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Small Chips", 16.90m, null },
                    { new Guid("07a3e508-2839-4812-a5a9-556020b00adc"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A generous sharing platter of 4 succulent Flame-grilled Shisanyama Chicken Sosaties and 20 Winglets, served with 2 portions of our Sharing Wedges, 2 Garlic Rolls and our special PERinase dip.", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/3d93a55d-440a-407c-8b7b-97cc1e6c510a", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Cabo Sosatie Snack Platter", 349.00m, null },
                    { new Guid("08d46c65-ebd0-4605-9ce8-9966621be009"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8pc Chicken, 2 snack burgers, 4 Zinger Wings, 2 Reg Coleslaw, 2 Reg chips", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "8 Piece Family Treat", 274.90m, null },
                    { new Guid("097cee4e-e270-4209-a12b-cc35ecbe3d65"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Hotwings® + a Slider®\r\n\r\n+ a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/47_soul-mix-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Soul Mix Snack", 30.00m, null },
                    { new Guid("11d10b13-f205-4d90-9c8d-b818e407a4c2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy 4 pieces of original recipe chicken, 2 small chips, 1 small pops & 2 buddy no sugar drinks.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "2 Can Dine Buddy", 164.90m, null },
                    { new Guid("12bf0d15-d60f-43b5-80da-4714d9a708c7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 pieces SoulFire® chicken + a portion of Soul Fries™\r\n\r\n+ 1 sachet SoulFire® sauce ", "https://chickenlicken.co.za/assets/uploads/products/menu/20_rock-my-soul-circle3ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul 3 Combo", 60.00m, null },
                    { new Guid("12ed0879-f325-4dab-aca6-96174b9593f4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "16 Hotwings® + 2 regular Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/17_hotwings-party-circle16ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Party", 132.00m, null },
                    { new Guid("131b3cf7-e50a-489a-9054-e38a06fc094d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken fillet + lettuce + tomato\r\n\r\n+ Soulfirenaise™ sauce on a toasted sesame bun", "https://chickenlicken.co.za/assets/uploads/products/menu/10_love-me-hot-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Hot", 37.00m, null },
                    { new Guid("1408b088-38db-45b9-9b5d-f3ebe2f5e6e6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + a portion of Soul Fries™ + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/51_soulsister-circle2ce-max.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Max", 65.00m, null },
                    { new Guid("1562ba5b-4033-4189-8e59-d99ac55236ae"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken dunked in KFC’s famous honey, ginger and soy sauce!", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Dunked Pops", 36.90m, null },
                    { new Guid("18408312-50af-42d9-b19d-500665f40b96"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8 Hotwings + toast + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/66_hotwings-meal-max-circle8ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Hotwings Meal Max", 90.00m, null },
                    { new Guid("18700d8d-5c1a-4416-8774-f9267b575145"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken fillet + lettuce + tomato\r\n\r\n+ Dreamy Creamy® sauce on a toasted sesame bun", "https://chickenlicken.co.za/assets/uploads/products/menu/7_love-me-tender-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Tender", 37.00m, null },
                    { new Guid("196770d9-ea1f-48d6-969a-cf6dd924750e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Cappy Juice 1.5 Litre", 44.90m, null },
                    { new Guid("19914077-dd28-4da9-8a65-a1583c2aae6e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Square chick’n burger on a toasted square bun with SOULFIRENAISE™ sauce and a pickle", "https://chickenlicken.co.za/assets/uploads/products/menu/39_1-slyder-chilli.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Slyder Chilli", 14.00m, null },
                    { new Guid("1cde5fd8-3cc6-4589-8219-b720155adf5d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pieces of Original Recipe Chicken with a portion of pap and gravy", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Three with Pap", 72.90m, null },
                    { new Guid("2658a62d-bd01-45d6-8e5a-d935c16bb71f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An icy sippable treat with Oreo bitz, and creamy soft-serve.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Oreo Krusher", 42.90m, null },
                    { new Guid("281a9538-ad9e-490b-8b31-9eaa6f0d94e0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "21 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/62_family-barrel-circle21ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Family Barrel", 300.00m, null },
                    { new Guid("28f9d8cb-f2ac-435b-b756-45dee8f3ac3a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken that are tender on the inside and crunchy on the outside. Served with a generous sprinkle of fruit chutney flavour.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Sprinkle Pops", 54.90m, null },
                    { new Guid("2b4159c7-5548-443f-9003-d57ccc0c9aad"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/57_just-circle4ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 4", 80.00m, null },
                    { new Guid("2d71bb56-6271-4484-a726-9aced02f3d28"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milk shake milk shake shake shake", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Strawberry Milkshake", 31.90m, null },
                    { new Guid("2da1ce3e-de08-4090-9a5c-c8c491aadcf9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wrapsta, 1 Piece of Original Recipe Chicken, Small Chips & Buddy Drink", "https://images.ctfassets.net/0p42pznmbeec/2snvT5LNlzizE6TGQ9KN4F/3f5c8ebf26502ad1bdf5a1cc456ccfc0/ABC1723-wrapsta_box_buddy.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Wrapsta Box Meal", 84.90m, null },
                    { new Guid("2dc35cc7-61eb-4475-935a-41c136cf3ee0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/55_just-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 2", 39.00m, null },
                    { new Guid("34c4cfa4-ffdd-4c96-a711-9c4080d437e6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around a delicious fillet zinger recipe - a slice of cheese, hash brown, crisp lettuce, fresh tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Zinger Boxmaster", 76.90m, null },
                    { new Guid("390aa0f4-fe4d-4a7c-af45-023fed3ed3e1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Hotwings", "https://chickenlicken.co.za/assets/uploads/products/menu/3_hotwings-circle12ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "12 Hotwings", 84.00m, null },
                    { new Guid("3d654476-fe16-44d3-84e8-4116a6e8c801"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken, tender on the inside and crunchy on the outside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Large Pops", 54.90m, null },
                    { new Guid("3eed9b88-d7da-4323-9953-87dc67e333a0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pieces of original recipe chicken, a portion of small chips.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Three with Chips", 72.90m, null },
                    { new Guid("3f7cc375-e488-4cdb-97ea-d8ea6d0a2488"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + toast + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/64_lunch-meal-max.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Lunch Meal Max", 76.00m, null },
                    { new Guid("3f9327ce-16d8-49ec-add4-53957d25f541"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Hotwings® + 4 Sliders®\r\n\r\n+ 2 regular Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/23_soul-mates-classic-party.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soul Mates Classic Party", 145.00m, null },
                    { new Guid("41b9c483-b7f1-4ce6-9e96-7c10c65142ee"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/49_soulsister-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister", 43.00m, null },
                    { new Guid("45baf261-04af-48b9-ba11-22ed1cfb8fee"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/59_just-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 6", 120.00m, null },
                    { new Guid("4f5d1d03-fddf-41dd-92e8-ebab36cf9743"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 SoulBites® + a portion of Soul Fries™ + a sachet of either \r\n\r\nUncle Jessups Ketchup®, SoulFire® sauce or Soulfirennaise™  sauce", "https://chickenlicken.co.za/assets/uploads/products/menu/125_soulbites-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Soul Bites Snack", 30.00m, null },
                    { new Guid("54c67513-c1be-4647-b4b0-78fedac3b5f9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes a regular Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/29_love-me-tender-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Tender Top Deluxe", 70.00m, null },
                    { new Guid("5630a76e-5b20-49c2-b84a-342ab7a5000f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + a portion of Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/50_soulsister-circle2ce-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Deluxe", 62.00m, null },
                    { new Guid("57f59609-0d83-4eff-bef9-2b2eecaae949"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Hotwings® + a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/46_hotwings-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Hotwings Snack", 30.00m, null },
                    { new Guid("5c9ca2e8-ae76-4c4e-a5c3-a1bf88b5531d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Hotwings", "https://chickenlicken.co.za/assets/uploads/products/menu/4_hotwings-circle24ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "24 Hotwings", 168.00m, null },
                    { new Guid("5d0655af-9cec-41bb-aa9b-b03830d84e7c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 Piece + 4 Hotwing®s + 1 Licken Loaf", "https://chickenlicken.co.za/assets/uploads/products/menu/128_soul-square-meal-.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soul Square Meal", 50.00m, null },
                    { new Guid("6019305f-d2a4-4536-bb98-59bc1393b7d4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An icy sippable treat with Berry bitz, and creamy soft-serve.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Verry Berry Krusher", 42.90m, null },
                    { new Guid("60c93b8e-3de0-46df-aa09-475277175406"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around 2 deliciously crispy chicken strips, shredded crisp lettuce, sliced tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Classic Twister", 66.90m, null },
                    { new Guid("614be771-d47f-4dcc-b66f-1ba32332cc35"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A spicy, crunchy mini fillet with a slice of cheese and lettuce, covered in tangy dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Crunch Burger", 36.90m, null },
                    { new Guid("6393a244-19b6-40d0-8866-dd4ad472f763"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get yourself a Streetwise 1, with a Buddy no sugar free drink", "https://images.ctfassets.net/0p42pznmbeec/3QpxFh5qLJj5GT8dEMW3iZ/3acbea341f4c8d3162163373ff8ed48f/COM2029-streetwise_bucket_for_1.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Streetwise 1 Buddy", 52.90m, null },
                    { new Guid("660e2c98-3ea9-41da-81f2-a2080c1164e0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of creamy mash and our delicious gravy.", "https://images.ctfassets.net/0p42pznmbeec/16hT15F1AVhciJyE32xbGE/f83f8d8d906a2593420739e995086bc4/MAG1003-reg_mash___gravy.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Mash & Gravy", 19.90m, null },
                    { new Guid("675d338d-55f5-4a9f-904b-da21467e0f68"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 SoulBites®", "https://chickenlicken.co.za/assets/uploads/products/menu/123_soulbites-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a9"), "Soul Bites", 38.00m, null },
                    { new Guid("67e76ffb-1893-4a04-a45e-0eede7887306"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 Hotwings", "https://chickenlicken.co.za/assets/uploads/products/menu/98_hotwings-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "6 Hotwings", 42.00m, null },
                    { new Guid("682eaa70-b5a8-4bc2-8de6-cd889e0ab1df"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke No Sugar 1.5 Litre", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke No Sugar 1.5 Litre", 29.90m, null },
                    { new Guid("68db50b1-4b5c-4876-a2b9-143b3ede2371"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + toast + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/63_lunch-meal.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Lunch Meal", 73.00m, null },
                    { new Guid("6992fbc6-3d13-4d54-a3b7-3bee4c41b7b0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs and spices of Original Recipe® chicken, marinated and cooked to perfection.", "https://images.ctfassets.net/0p42pznmbeec/2ZE6o3XzzI7YzGsVVT4ubY/e95c55d0c1b050b91a2b070a5ad1b32e/9_piece_bucket.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1"), "9 Piece Bucket", 182.90m, null },
                    { new Guid("6a455856-1d91-4bcf-8df5-8c63380f854a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fanta Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Fanta Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("70a9e5be-2d3d-4868-b342-0ec5d336dcbe"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Nuggets, 1 Crunch Burger, 1 Small Chips and a Buddy Drink", "https://images.ctfassets.net/0p42pznmbeec/1L5C3sZ1MmaHtuQLewHqYa/5e4ecba1d83ade38d554eba1a7431551/ABC2120-nugget_box_buddy_1.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Nugget Box Buddy Meal", 79.90m, null },
                    { new Guid("7283ad18-5617-4119-ab3e-2d7fd7ef83a5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces of crispy, delicious golden brown Nuggets, paired with 1 delicious Colonel dipping sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "6Pc Nuggets", 36.90m, null },
                    { new Guid("7376e04f-05e4-4c29-b717-8e28a3960e6a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "  Square chick’n burger on a toasted square bun with DREAMY CREAMY® sauce and a pickle and cheese", "https://chickenlicken.co.za/assets/uploads/products/menu/36_1-slyder-cheese.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Cheese Slyder", 16.00m, null },
                    { new Guid("75a65d41-b3dc-47c1-aa51-33c6ea239351"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Original Slyders® + a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/44_slyder-snack-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Slyder Snack", 30.00m, null },
                    { new Guid("77007bdc-0d7d-43cd-9afd-b6b07b4624ee"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", "https://images.ctfassets.net/0p42pznmbeec/23emjPvgiS9FE3xT6UiBa/9a5d9ceffa02d18a26679472e7f62cfc/CHI1001-reg_chips.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Chips", 26.90m, null },
                    { new Guid("7763e725-b972-466c-9140-54a9e66a3340"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprite Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Sprite Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("780d05c9-705f-43cc-bedd-59cd9d56c01b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", "https://images.ctfassets.net/0p42pznmbeec/5Zt1jvrey6zim41HKaarJr/6c4e0a08f94a83f04ad98dc130ce67e1/CHI1002-lrg_chips.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Large Chips", 0m, null },
                    { new Guid("79daac80-c98f-4e94-ab5f-6c1a23da653b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 KFC famous Zinger Wings dunked in a delicious honey, ginger and soy sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "4 Dunked Wings", 54.90m, null },
                    { new Guid("79df2d6a-f0e2-4663-bfdf-d2a97bad5358"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 pieces SoulFire® chicken + 1 sachet SoulFire® sauce", "https://chickenlicken.co.za/assets/uploads/products/menu/19_rock-my-soul-circle3cew-straight.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul 3 Straight", 57.00m, null },
                    { new Guid("7d09e97f-750e-4852-aed0-dc0f2f503f59"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The game changer is here, and with a delicious spicy crunch fillet, tomato, lettuce and cheese with tangy dressing all wrapped up in a mini tortilla and grilled to perfection, meal time will never be the same again.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Wrapsta", 42.90m, null },
                    { new Guid("7d23b426-1129-4bba-a464-4a0d2c383192"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "36 Hotwings", "https://chickenlicken.co.za/assets/uploads/products/menu/5_hotwings-circle36ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "36 Hotwings", 231.00m, null },
                    { new Guid("81ea2e81-f1a0-4b7d-b375-3923f16cec21"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Square chick’n burger on a toasted square bun with DREAMY CREAMY® sauce and a pickle", "https://chickenlicken.co.za/assets/uploads/products/menu/33_1-slyder-original.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Slyder Original", 14.00m, null },
                    { new Guid("82bd776c-9f67-485e-bbe2-fa6972636506"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of creamy mash and our delicious gravy.", "https://images.ctfassets.net/0p42pznmbeec/16hT15F1AVhciJyE32xbGE/f83f8d8d906a2593420739e995086bc4/MAG1003-reg_mash___gravy.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Large Mash & Gravy", 27.90m, null },
                    { new Guid("82fc650b-2f31-4582-a085-1c9f5c43aa32"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Chicken Bresteaks® + lettuce + a slice of cheese\r\n\r\n+ 3 pickles + Dreamy Creamy® sauce\r\n\r\non a toasted sesame bun", "https://chickenlicken.co.za/assets/uploads/products/menu/13_big-john-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Big John", 42.00m, null },
                    { new Guid("858a7fb0-c271-408c-9200-a196f727d463"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new Burger standard…Boxed! The Crispy Zinger burger, 1 piece of original recipe chicken, regular mash & gravy, chips & Buddy no sugar.", "https://images.ctfassets.net/0p42pznmbeec/3spYrESfEqEyv4TaIwhQnZ/e315445416a59f4ba60acf90090482dd/62279_WickedZinger_SF_-_1200x900.png?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Zinger Fully Loaded Buddy Box Meal", 115.90m, null },
                    { new Guid("8905e68c-dbcb-4471-b48e-c151dfe7e1cb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "24 Zinger Wings Bucket", 194.90m, null },
                    { new Guid("892914f3-156d-464a-a883-6693b0fe68b8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes a regular Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/32_love-me-hot-cheese-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Hot Cheese Top Deluxe", 72.00m, null },
                    { new Guid("899c482c-985f-4994-b03d-50976c29dc5a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8 pieces + 2 regular Soul Fries™\r\n\r\n+ 2 regular Soulslaw® / Achaar / Tomato Salsa\r\n\r\n+ 2 Licken Loafs®", "https://chickenlicken.co.za/assets/uploads/products/menu/25_family-full-house-circle8ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Family Full House", 173.00m, null },
                    { new Guid("8ad0141e-81e9-4c8e-9717-c5e84a1b6c76"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/58_just-circle5ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 5", 99.00m, null },
                    { new Guid("90a87681-96d4-4e2c-9f5e-0a2776747697"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10pc Chicken, 2 snack burgers, 4 Zinger Wings, 2 Reg Coleslaw, 2 Reg chips", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "10 Piece Family Treat", 316.90m, null },
                    { new Guid("96005e52-4bc9-47b7-900d-d6af13d9cf6e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chocolate Milkshake", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Chocolate Milkshake", 31.90m, null },
                    { new Guid("96beea54-dafd-4591-8a7c-b73379564264"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "4 Zinger Wings", 48.90m, null },
                    { new Guid("97d54c28-6fe7-49bb-920d-05f73d9067b0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A delicious chicken patty served with shredded lettuce & Colonel dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Snack Burger", 29.90m, null },
                    { new Guid("980a1d2f-a335-4082-be78-94b2a02bfd01"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/56_just-circle3ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 3", 60.00m, null },
                    { new Guid("9c1e2559-1f02-45cb-86e4-3c50d0b3048c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bonaqua Still Spring Water 500ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Bonaqua Still Spring Water 500ml", 19.90m, null },
                    { new Guid("9e310146-3730-4d16-9f6d-3b6af370db00"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around a delicious fillet original recipe - a slice of cheese, hash brown, crisp lettuce, fresh tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Colonel Boxmaster", 76.90m, null },
                    { new Guid("a0c4ae4e-641d-4c1a-9b90-3e93410224eb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crunch Burger, 1 Piece of Original Recipe Chicken, 2 Zinger Wings, Small Chips & Buddy Drink", "https://images.ctfassets.net/0p42pznmbeec/2tpR61h0KxupmA8U024fwu/55f538f6ae4384b9bbdf598435d6ea53/ABC1696-all_star_box_buddy.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "All Star Box Meal Buddy", 94.90m, null },
                    { new Guid("a28efed5-1861-4ce5-b263-c5f2af23f05c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oven baked, fresh mini loaf", "https://images.ctfassets.net/0p42pznmbeec/2X0ukPSNX6j4kHDE2o2mGa/e910e8f156eb5ca37642fb19944603a0/MIS1001-1_mini_loaf.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Mini Loaf", 14.90m, null },
                    { new Guid("a80b53af-9ecf-451f-b6ac-14a8310a98ed"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy a delicious Crunch Burger an orginal receipe chicken piece with small chips and a buddy no sugar drink", "https://images.ctfassets.net/0p42pznmbeec/3QpxFh5qLJj5GT8dEMW3iZ/3acbea341f4c8d3162163373ff8ed48f/COM2029-streetwise_bucket_for_1.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Crunch Burger Box Buddy", 71.90m, null },
                    { new Guid("aad678aa-e085-4a88-801a-5dfb41ca25f0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs & spices.", "https://images.ctfassets.net/0p42pznmbeec/WKTb7n2vvpdYR1v8mvXX0/4d01e6a6cf892c116f2e82bdd4b64b6a/66752_-_E-Commerce_15_pc_Bucket_1200x900.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1"), "15 Piece Bucket", 279.90m, null },
                    { new Guid("ac499447-bfd2-49e7-ac1b-7f11288b25d2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extra Hot & Spicy Zinger sauce on the side", "https://images.ctfassets.net/0p42pznmbeec/bEZLbUGmprwC7wW3i0GsS/73b63ef3ac73d2e805688b74cdbc31c0/Hot_n_Spicy_sauce_-_1200x900.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Sauce - Hot & Spicy", 0m, null },
                    { new Guid("ad56b23d-8bb1-4adc-8da9-69b8c36215ac"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes a regular Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/31_love-me-hot-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Hot Top Deluxe", 70.00m, null },
                    { new Guid("af721f73-e253-4b45-b47f-774334ea58f5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 KFC famous Zinger Wings dunked in a delicious honey, ginger and soy sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "10 Dunked Wings", 104.90m, null },
                    { new Guid("b14c8b66-08fa-49d1-bede-d6b59ca491cd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8 Hotwings + toast + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/65_hotwings-meal-circle8ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Hotwings Meal", 86.00m, null },
                    { new Guid("b25444cd-5c65-43cf-9b69-1e7bb540d02f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of freshly prepared cabbage, onions and carrots in a delicious dressing", "https://images.ctfassets.net/0p42pznmbeec/1LvCxHqjAFXs2XFgAbQpnG/44719dee762ff4f7106e33d8c4f300f9/ABC2225-reg_coleslaw.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Coleslaw", 24.90m, null },
                    { new Guid("b396eba1-0a54-4e8b-9068-dbc2e61e0bf4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 pieces + a portion of Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/52_soulsister-party-circle4ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Party", 84.00m, null },
                    { new Guid("b40d4228-b8e0-43fb-ba8d-6e052fa6dea2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "24 Zinger Wings Bucket", 194.90m, null },
                    { new Guid("b502d711-c5bf-484f-8f06-533e9d01c225"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/60_chicken-inn-circle9ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Chicken Inn", 150.00m, null },
                    { new Guid("b6169911-1ce5-4203-8210-086d7c7ee622"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/61_family-bucket-circle15ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Family Bucket", 230.00m, null },
                    { new Guid("b77971f4-4415-4045-8685-58a22a031e48"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Two full chickens (cut into 16), 16 Winglets, 2 Flame-grilled Mielies cut into 3 (6 portions), 2 Sharing Wedges. Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/fa60cb07-3c21-4718-8f02-cb91fd83319b", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Peri-er Platter", 640.00m, null },
                    { new Guid("b7aa2aac-6b78-48a5-9948-0a8e9fa0a22f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy 6 pieces of delicious original recipe chicken, 1 large chips, 1 regular coleslaw plus 2 regular mash and gravies.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "All In One Feast", 194.90m, null },
                    { new Guid("b8f3e942-e021-4e04-9e42-d4ff5233a0a4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get yourself a Streetwise 5, with 2 Buddy No Sugar", "https://images.ctfassets.net/0p42pznmbeec/2uwM3hjbse4hzaZv6d5peO/576343077547dc714bf02883a79589f6/ICM1009-streetwise_5_chips.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Streetwise 5 Buddy", 143.90m, null },
                    { new Guid("baf30662-fea4-4e6a-a8fd-79016c4dd805"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around 2 deliciously crispy new and improved chicken strips, shredded crisp lettuce, sliced tomato, topped with Colonel dressing and sweet chilli sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Sweet Chilli Twister", 66.90m, null },
                    { new Guid("bbef6f9b-c753-4c51-8d16-0821248a5f14"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Square chick’n burgers on toasted square buns with DREAMY CREAMY® sauce and a pickle", "https://chickenlicken.co.za/assets/uploads/products/menu/34_2-slyders-original.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "2 Original Slyders", 27.00m, null },
                    { new Guid("bf2d4a08-637a-47d9-94b3-497f0dd60dcb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken that are tender on the inside and crunchy on the outside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Small Pops", 29.90m, null },
                    { new Guid("c0c0bffb-6cc8-40ea-a458-09b270be8e9c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Love Me Tender® Burger + a regular Soul Fries™\r\n\r\n+ 2 Hotwings® + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/22_soulman-load-up.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soulman Load Up", 80.00m, null },
                    { new Guid("c22299bc-bf82-4659-a629-cd06bb4804bc"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 Hotwings® + a portion of Soul Fries™ + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/16_hotwings-circle6ce-max.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Max", 69.00m, null },
                    { new Guid("c50b4949-9587-4708-afa2-7327afee1314"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 Pieces of Original Recipe chicken cooked to golden perfection and a large portion of chips or coleslaw.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Five", 121.90m, null },
                    { new Guid("c630f380-9d00-4988-a3e1-dbb600d55d75"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces SoulFire® chicken + 1 regular Soul Fries™\r\n\r\n+ 2 sachets SoulFire® sauce", "https://chickenlicken.co.za/assets/uploads/products/menu/21_rock-my-soul-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul", 105.00m, null },
                    { new Guid("c67081a1-5343-4bcd-a981-673f36fede2e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new standard in burgers! 2 Spicy, crunchy mini fillets with 2 cheese slices, lettuce & tomato covered in tangy dressing on a burger bun", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Double Crunch Burger", 68.90m, null },
                    { new Guid("c82cdd0f-4b73-4918-bffd-cc323ae77cee"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken fillet + lettuce + tomato\r\n\r\n+ Soulfirenaise™ sauce + a slice of cheese\r\n\r\non a toasted sesame bun", "https://chickenlicken.co.za/assets/uploads/products/menu/12_love-me-hot-cheese-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Hot Cheese Burger", 40.00m, null },
                    { new Guid("cc4ee0ac-b005-4325-adf5-e20396d90a67"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new Burger standard…Boxed! The new Colonel burger, 1 piece of original recipe chicken, regular mash & gravy, chips & a buddy no sugar drink.", "https://images.ctfassets.net/0p42pznmbeec/31yPC9ryh5KT1pOdwEOOzG/d1e2df6fc99eaf513f84b63f7d475f58/65129_kfc_-_FLBM_cheese_buddy_1200x900.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Fully Loaded Box Meal", 115.90m, null },
                    { new Guid("cd2af4f8-082e-4279-93ee-7bebd72b961e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 Hotwings® + a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/18_feed-my-craving-circle10ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Feed My Craving", 79.00m, null },
                    { new Guid("d19e3e1a-9108-4a18-8c44-1573194f71d5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 Hotwings® + a portion of Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/15_hotwings-circle6ce-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Deluxe", 67.00m, null },
                    { new Guid("d2e7f5b8-381c-49b2-af4e-db88f6c0cce6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half Platter", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/f93c9cbe-5f94-4bb4-a937-811c28bd88df", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Big on veg platter", 640.00m, null },
                    { new Guid("da498738-5dec-43e7-87d4-6dbb7d7eed54"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "10 Hot Zinger Wings", 89.90m, null },
                    { new Guid("dbd1ef4f-9912-44aa-9531-cc00c57cd9ec"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 pieces of crispy, delicious golden brown Nuggets, paired with 1 delicious Colonel dipping sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "9Pc Nuggets", 42.90m, null },
                    { new Guid("dbe030b4-8e98-4292-b760-55e4d9631bb7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke 1.5 Litre Bottle", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke 1.5 Litre Bottle", 32.90m, null },
                    { new Guid("dbed62e6-a367-4d0d-b411-e7cfec3a5fa9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "One and a 1/2 full chickens ( cut into 12), 2 Flame-grilled Mielies cut into 3 (6 portions), 4 Kids Burgers, 2 Sharing Wedges. Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/5182f543-741a-4317-a731-e8098a228c37", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "More to share platter", 640.00m, null },
                    { new Guid("dc02bc2a-72e6-4264-9ff6-2fd2c7475294"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Try the new standard! The New Colonel burger, Our trademark real chicken fillet; A fresh Brioche bun, Creamy Colonel sauce and cheese on a fresh bed of lettuce & succulent tomatoes", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Colonel Burger", 60.90m, null },
                    { new Guid("dea3dce3-dd6c-4683-af89-847100199080"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 Piece Chicken", "https://images.ctfassets.net/0p42pznmbeec/2XhP71I12p5tncjyX1P81w/d94f9543674f4728165031f42dcb2653/ALA1001-1pc_cob.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "1 Piece Chicken", 26.90m, null },
                    { new Guid("e0fd0986-8c4d-4f41-aa5a-cbf88e56931f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + a Licken Loaf", "https://chickenlicken.co.za/assets/uploads/products/menu/129_soulsister-2-vibe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Vibe", 40.00m, null },
                    { new Guid("e469ccc1-1534-4e19-9c70-61e055258f18"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces + 2 regular Soul Fries™\r\n\r\n+ 2 regular Soulslaw® / Achaar / Tomato Salsa\r\n\r\n+ 2 Licken Loafs®", "https://chickenlicken.co.za/assets/uploads/products/menu/24_family-full-house-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Family Full House", 143.00m, null },
                    { new Guid("e81503ef-c519-467f-a136-318a6929477b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Pieces of Original Recipe Chicken and Small Chips or Coleslaw.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Two with Chips", 49.90m, null },
                    { new Guid("e9992fe3-789c-4b3e-822c-3ca8985b0b2d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes a regular Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/30_love-me-tender-cheese-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Tender Cheese Top Deluxe", 72.00m, null },
                    { new Guid("ee104487-3384-4fbe-83f4-facac4d61c00"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke No Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke No Sugar Buddy 440ml", 22.90m, null },
                    { new Guid("ef70362e-8ab1-490c-ac92-56b7dd322f57"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Veg Burgers, 2 Halloumi & Roast Veg Wraps, 2 Halloumi & Roast Veg Pitas, 2 Sharing Wedges, 4 Flame-grilled Mielies cut into 3 (12 portions). Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/3b7bc5aa-eb6c-4f3b-a289-ae9669f410dd", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Veggie veggie nice platter", 640.00m, null },
                    { new Guid("f170187e-9238-4322-b2ab-95172f5be129"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy KFC`s new Jalapeno loaded fries with brand new Hot * spicy sauce", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Jalapeno Loaded Fries", 32.90m, null },
                    { new Guid("f1d5ca1f-a1fd-43a5-b972-ef1e5892436b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy a piece of original recipe chicken, 2 zinger wings and a small scrumptious chips.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Bucket For One", 46.90m, null },
                    { new Guid("f249f588-ff92-426e-b55e-7542835778f5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Pieces of original recipe chicken cooked to golden perfection and a regular portion of pap & small gravy.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Two with Pap", 49.90m, null },
                    { new Guid("f2efc18e-b019-4aa8-8542-10e117b5f8d6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 piece", "https://chickenlicken.co.za/assets/uploads/products/menu/54_just-circle1ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 1", 20.00m, null },
                    { new Guid("f443eb77-d5fe-4470-a781-61e6beee8626"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 Hotwings® + a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/14_hotwings-soul-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Soul", 50.00m, null },
                    { new Guid("f63811ce-1fad-40ba-829f-9a7a3a47e93e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 pieces + a portion of Soul Fries™ + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/53_soulsister-party-circle5ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Party", 112.00m, null },
                    { new Guid("f70387cc-ce9d-4497-8165-2291aad2165e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken fillet + lettuce + tomato\r\n\r\n+ Dreamy Creamy® sauce + a slice of cheese\r\n\r\non a toasted sesame bun", "https://chickenlicken.co.za/assets/uploads/products/menu/9_love-me-tender-cheese-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Tender Cheese Burger", 40.00m, null },
                    { new Guid("fb69746c-1f05-451b-ae20-a7128103df41"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 SoulBites®", "https://chickenlicken.co.za/assets/uploads/products/menu/124_soulbites-circle9ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a9"), "Soul Bites Max", 45.00m, null },
                    { new Guid("fc018130-a259-467b-8222-03a48369c098"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes a regular Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/28_big-john-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Big John Top Deluxe", 72.00m, null },
                    { new Guid("fc54fa74-b72b-418d-a597-f0945d8a3fd5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pulled Chicken Wraps (cut into 6), 3 Chicken Wraps (cut into 6), 2 Sharing Wedges, 16 Winglets, 2 Flame-grilled Mielies cut into 3 (6 portions). Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/ccc05d6a-734b-4fec-bbc7-50a7da7ad2da", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Hands-on delicious platter", 640.00m, null },
                    { new Guid("fd6f6af3-42fc-4ffe-b59e-48f862167153"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca-Cola Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coca-Cola Sugar Buddy 440ml", 24.90m, null }
                });
        }
    }
}
