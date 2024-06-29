using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gaolos.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreditCardType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: new Guid("8ca140ca-2ab0-4563-8d06-9764ed739c66"));

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: new Guid("9cf27cb6-80fc-4417-ae0b-32c03b708b88"));

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: new Guid("c46f5433-b1be-4906-a95e-55c8f779360f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("002c2550-800a-4b5e-a450-2ded1a05ec0c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("01a116a2-6716-4a46-8223-9450be0d14e5"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0283e629-0bae-48b1-9007-2e00e142e473"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("04101530-a659-488f-b222-de99b2bdf6f6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("04fc21b6-84ab-45aa-970c-42bec74adebc"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("082d27f2-d5bb-4e43-bd7f-6f1d082b9c48"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0b35cc09-8d55-4227-9b02-0b6db5e80060"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0b5a08d0-6fcd-4a3d-87f6-9b937bc473c1"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0da9bd1b-5969-44f0-9705-6294296770ac"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0e261c2c-9453-483e-ac24-7cf87e3d7ce0"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("0e6e48bb-6e20-458a-a16b-876cb2e1e34b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1148c9a7-a3b2-496d-b417-3ad7c13aad67"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("12746e02-2f5d-48f5-9709-1979e5c5d29f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("141fd78c-0113-413e-a1f9-438ab0f10ee4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("15939535-94b5-4118-a460-9737b8f6093c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("17a33939-353d-4b93-96de-0214eeecd1f5"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1e0e20bb-5a4a-484c-855a-019dc5cf610b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("1f719b4e-ebf9-4476-9e69-dc823833a493"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("220ab625-95f2-4868-b2e9-edee76c23c47"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("223b2aa6-cba9-4014-9dfc-7ea6b9ead062"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("24b51a06-b642-4b59-a89e-d8421710bbee"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("24b8f14e-3257-441d-a410-3df5c26e1244"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("26a1c352-bfd9-4c35-9cd2-f7386c5b522c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("283d6b6a-c0b8-4ae0-849f-7d1e95c8e140"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("29fe6207-2ea9-4ee5-9869-cdfda80ac7bc"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("2f72e883-25b5-4e03-9fe8-8ca9d47329f8"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("33a8b5d5-7a1f-491d-8560-f4c67c5e1ab2"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("34787e61-0b1c-4d11-a573-1513f72228b4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("34dedf0d-b155-491f-bfa5-3fedfe5dc1a4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3572b1a8-9973-4425-875f-86810d8fbdaa"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("35b7a8d3-84b1-456a-a9be-f6d1ccfffe8f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("36d476b7-003f-4939-ba6d-58648f6b13f8"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("371f8520-0c15-4720-83f4-dd4d9e547f13"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("38900cf8-59ff-46ea-abd9-76553252444e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3cbf66c2-89fb-4ae1-9afb-9cdf737a44c9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3e7bdc57-1d5c-44bb-a2d9-5d9b2f2f9543"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("3ff40163-4356-47d1-b276-e264f1a260aa"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("40cd8b14-4a34-4b60-850f-e58976dcf77a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4129b680-1ba3-4fc9-a9c1-d4a46a8af890"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("41ec3b30-8bd8-4041-aec5-b15e8b16009d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("43e74758-90f8-4dce-836f-ca24e9309c5e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4479aed9-8308-49de-8662-56e6565a37fd"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("44c4d601-d08c-43bd-80f0-3da4b013568a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("494263e5-fe23-4cd4-b82d-0d3b66a57707"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("498ef385-879f-48dd-8ac0-9c6bb557d4cb"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4c012378-e399-4359-8492-e475f9e44f54"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4ca08e50-84da-4868-a55a-d3d767561510"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("4ec1343a-2da9-425b-980e-0a18d61599b9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("50c89ee5-f147-416e-921a-6ebef6f1a033"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("52b9d83f-965a-4c42-9aba-bd4fd3c49e95"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("53985e75-05c7-4874-8d61-d4a265b21f4b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5415ecdb-c90f-4e44-a0b5-94bdbf0c372c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("57300a59-1520-483d-b3dd-ba7a001fc6d7"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5c5425c3-7c2e-4857-a312-eabaef355086"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5d113f59-92b8-4864-ab21-8ef981bfb793"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5d7b0ef4-e374-4438-91aa-3d2df6891366"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5eba4083-7c7f-48c0-890d-6839a601aebc"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("5f325665-1f3b-4e7d-ae6a-c39b7e3c328b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("61ffd5ce-dab8-483a-9ed4-4e69a35251c9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("629fb478-1c78-4f11-82b2-a98f33197b61"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("63c94c86-0993-40fe-b9b8-d2e210ed112e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("65552484-91b4-415b-afc1-d343e0022c36"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("655cd21f-adcf-446f-bfef-5fed6372a899"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("65c65d79-6145-4cb7-b359-61db56e16844"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("6641665c-3b74-4c41-be15-765092a36266"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("669dea97-728e-4f5e-b631-0646583e9135"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("68853904-d7df-4730-a562-655a368bb024"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("6f3ba78b-427c-4130-9900-d56e45acecd1"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("6f554267-a27d-4543-acb8-e44cba1a3226"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("71a7d221-7a48-402d-9a7a-26ed83558404"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("77243f70-7a36-45e6-9b3c-011f9769be14"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("792082d4-89a7-46ee-aba7-4048a3d94897"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("79f8508a-21bc-43c4-a87d-6abd29b3171b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7d1e22c6-fd8f-43aa-8ab0-b4503ba9b899"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("7de12c1f-7694-4fd0-8cb6-0ee17f1bf2c9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("828f52eb-2848-4bb4-94d9-3919b7af537e"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("84f3da61-10aa-493d-8a78-86c42a61f418"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8705de5d-10f6-4415-9511-041d2f95a504"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("871bd936-63a4-4db7-9422-c47b03221bb3"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("881474ea-cfe5-44d0-9407-d0063cd7efa8"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("882d8242-28dd-428e-bf3a-c06790245abd"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8b17946c-91d1-494a-b433-b8997a621217"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8c097fb5-d557-4d78-8162-de774a993017"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8e044a33-6154-4b4c-a860-5057511aebb7"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("8e1513ba-024c-4fdb-8aad-e0dbb0570001"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("902b9141-7b80-45e4-aa36-20a080a424cb"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("95e6dc21-bdf6-43e0-b5df-984904d6453c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("97b4b34c-e453-40f1-82de-f395974f3eda"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("97c499c9-5aca-4280-8134-9dbd19ed9f94"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("9b02ad2b-8c3e-4443-8789-fdb9d77897cd"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a44e3af7-ec0b-4fff-94b3-91a7f8f2e686"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a4ac927e-8d59-4c71-aea1-820cab1d6620"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a6a3343b-bacc-495b-889f-40185d5950e6"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("a9a9973d-6de9-4bec-8821-e33837744c31"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("aaaa750c-a0de-459a-8f0a-17d4f3916022"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b04a4c52-b763-4500-bce2-ccb76e73ded4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b0ae4d1a-4ac7-4838-9acb-3cee54ca6c5f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b20d66c2-d899-48e8-bea1-0a457bf2006a"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("b9ae1079-f91c-486c-8c11-a11b14be7e78"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("bb7e9c72-a927-497b-972d-71453a2ec31c"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("bd489887-bf60-446c-ae4e-468e5546aab9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("bde82396-035d-4df8-9e13-a12f578d2b18"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("be29abf0-a0d0-4ebe-974f-8f2b80a597b4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("be4266cb-360f-4dc7-927b-c85b59ff26ff"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("bf0ce8b1-deda-4501-a069-3082b80918fc"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("c81cbbc2-c4dc-4e08-ba10-3bbfe3961763"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ca1d4a42-5b47-42f9-8696-002f09cb4088"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("cc6e24b5-dbbb-4d3a-aa64-c7253e22469f"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("ccf4437d-0c1a-4d39-a422-5b5c4bab5533"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("cebb7251-009c-468a-b379-5193dd60dba9"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d1ee9fd2-e371-474a-9157-be686f74c1f3"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d3888efc-244f-4642-a5e9-4fea8bbb0dca"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d7388d80-8eb2-497a-9072-0db957250319"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d7cd9a71-8c94-47a0-b0c3-1ab0940fe8f7"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d80b06d3-e76d-47ca-be1d-4b50b2e27686"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("d9789d14-f81f-47b7-9746-4b53a7871038"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("dd9e45c9-dd4e-44ff-be72-4090fbe304ad"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e6ce19f9-4fe1-4105-8aae-163f930bc2e8"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e83cf236-a12f-4303-adcf-82bf27599e4d"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("e9e29b08-c323-4b96-bea2-9f60d14537cd"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("eba572be-81ef-4303-be1b-c05cb125e699"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f253afd7-db5f-47bc-bf6f-d8c4d1c70c40"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f4e5ac70-c1c2-4d1e-8d06-bf8d6f8cf8aa"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f70b1e1d-d10d-4c15-8abf-d7706c76a076"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("f7dfa71a-5623-456d-8f11-987c92de821b"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("fab79172-03e7-46d5-ae5a-e93159323ba4"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("fb7b1371-a532-4857-8830-5be0cac5f6ca"));

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: new Guid("fe060403-e205-4260-a060-d4ed3854bd5d"));

            migrationBuilder.AddColumn<string>(
                name: "CardType",
                table: "CreditCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CardType",
                table: "CreditCards");

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "CouponId", "AlreadyUsed", "Code", "CreatedBy", "CreatedDate", "Discount", "LastModifiedBy", "LastModifiedDate" },
                values: new object[,]
                {
                    { new Guid("8ca140ca-2ab0-4563-8d06-9764ed739c66"), false, "AlmostFree", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, null, null },
                    { new Guid("9cf27cb6-80fc-4417-ae0b-32c03b708b88"), false, "Awesome", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, null, null },
                    { new Guid("c46f5433-b1be-4906-a95e-55c8f779360f"), false, "BeNice", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, null, null }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemId", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "MenuId", "Name", "Price", "SubmenuId" },
                values: new object[,]
                {
                    { new Guid("002c2550-800a-4b5e-a450-2ded1a05ec0c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 KFC famous Zinger Wings dunked in a delicious honey, ginger and soy sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "10 Dunked Wings", 104.90m, null },
                    { new Guid("01a116a2-6716-4a46-8223-9450be0d14e5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around a delicious fillet original recipe - a slice of cheese, hash brown, crisp lettuce, fresh tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Colonel Boxmaster", 76.90m, null },
                    { new Guid("0283e629-0bae-48b1-9007-2e00e142e473"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An icy sippable treat with Berry bitz, and creamy soft-serve.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Verry Berry Krusher", 42.90m, null },
                    { new Guid("04101530-a659-488f-b222-de99b2bdf6f6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Love Me Tender® Burger + a regular Soul Fries™\r\n\r\n+ 2 Hotwings® + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/22_soulman-load-up.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soulman Load Up", 80.00m, null },
                    { new Guid("04fc21b6-84ab-45aa-970c-42bec74adebc"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes a regular Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/28_big-john-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Big John Top Deluxe", 72.00m, null },
                    { new Guid("082d27f2-d5bb-4e43-bd7f-6f1d082b9c48"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/55_just-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 2", 39.00m, null },
                    { new Guid("0b35cc09-8d55-4227-9b02-0b6db5e80060"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 pieces SoulFire® chicken + 1 sachet SoulFire® sauce", "https://chickenlicken.co.za/assets/uploads/products/menu/19_rock-my-soul-circle3cew-straight.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul 3 Straight", 57.00m, null },
                    { new Guid("0b5a08d0-6fcd-4a3d-87f6-9b937bc473c1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 Hotwings® + a portion of Soul Fries™ + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/16_hotwings-circle6ce-max.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Max", 69.00m, null },
                    { new Guid("0da9bd1b-5969-44f0-9705-6294296770ac"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Hotwings® + a Slider®\r\n\r\n+ a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/47_soul-mix-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Soul Mix Snack", 30.00m, null },
                    { new Guid("0e261c2c-9453-483e-ac24-7cf87e3d7ce0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/49_soulsister-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister", 43.00m, null },
                    { new Guid("0e6e48bb-6e20-458a-a16b-876cb2e1e34b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crunch Burger, 1 Piece of Original Recipe Chicken, 2 Zinger Wings, Small Chips & Buddy Drink", "https://images.ctfassets.net/0p42pznmbeec/2tpR61h0KxupmA8U024fwu/55f538f6ae4384b9bbdf598435d6ea53/ABC1696-all_star_box_buddy.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "All Star Box Meal Buddy", 94.90m, null },
                    { new Guid("1148c9a7-a3b2-496d-b417-3ad7c13aad67"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new standard in burgers! 2 Spicy, crunchy mini fillets with 2 cheese slices, lettuce & tomato covered in tangy dressing on a burger bun", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Double Crunch Burger", 68.90m, null },
                    { new Guid("12746e02-2f5d-48f5-9709-1979e5c5d29f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around 2 deliciously crispy new and improved chicken strips, shredded crisp lettuce, sliced tomato, topped with Colonel dressing and sweet chilli sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Sweet Chilli Twister", 66.90m, null },
                    { new Guid("141fd78c-0113-413e-a1f9-438ab0f10ee4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken that are tender on the inside and crunchy on the outside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Small Pops", 29.90m, null },
                    { new Guid("15939535-94b5-4118-a460-9737b8f6093c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/58_just-circle5ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 5", 99.00m, null },
                    { new Guid("17a33939-353d-4b93-96de-0214eeecd1f5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 Hotwings® + a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/14_hotwings-soul-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Soul", 50.00m, null },
                    { new Guid("1e0e20bb-5a4a-484c-855a-019dc5cf610b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Chicken Bresteaks® + lettuce + a slice of cheese\r\n\r\n+ 3 pickles + Dreamy Creamy® sauce\r\n\r\non a toasted sesame bun", "https://chickenlicken.co.za/assets/uploads/products/menu/13_big-john-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Big John", 42.00m, null },
                    { new Guid("1f719b4e-ebf9-4476-9e69-dc823833a493"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A delicious chicken patty served with shredded lettuce & Colonel dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Snack Burger", 29.90m, null },
                    { new Guid("220ab625-95f2-4868-b2e9-edee76c23c47"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken fillet + lettuce + tomato\r\n\r\n+ Dreamy Creamy® sauce + a slice of cheese\r\n\r\non a toasted sesame bun", "https://chickenlicken.co.za/assets/uploads/products/menu/9_love-me-tender-cheese-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Tender Cheese Burger", 40.00m, null },
                    { new Guid("223b2aa6-cba9-4014-9dfc-7ea6b9ead062"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pieces of Original Recipe Chicken with a portion of pap and gravy", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Three with Pap", 72.90m, null },
                    { new Guid("24b51a06-b642-4b59-a89e-d8421710bbee"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + toast + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/64_lunch-meal-max.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Lunch Meal Max", 76.00m, null },
                    { new Guid("24b8f14e-3257-441d-a410-3df5c26e1244"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes a regular Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/30_love-me-tender-cheese-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Tender Cheese Top Deluxe", 72.00m, null },
                    { new Guid("26a1c352-bfd9-4c35-9cd2-f7386c5b522c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy a delicious Crunch Burger an orginal receipe chicken piece with small chips and a buddy no sugar drink", "https://images.ctfassets.net/0p42pznmbeec/3QpxFh5qLJj5GT8dEMW3iZ/3acbea341f4c8d3162163373ff8ed48f/COM2029-streetwise_bucket_for_1.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Crunch Burger Box Buddy", 71.90m, null },
                    { new Guid("283d6b6a-c0b8-4ae0-849f-7d1e95c8e140"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/60_chicken-inn-circle9ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Chicken Inn", 150.00m, null },
                    { new Guid("29fe6207-2ea9-4ee5-9869-cdfda80ac7bc"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", "https://images.ctfassets.net/0p42pznmbeec/23emjPvgiS9FE3xT6UiBa/9a5d9ceffa02d18a26679472e7f62cfc/CHI1001-reg_chips.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Chips", 26.90m, null },
                    { new Guid("2f72e883-25b5-4e03-9fe8-8ca9d47329f8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/59_just-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 6", 120.00m, null },
                    { new Guid("33a8b5d5-7a1f-491d-8560-f4c67c5e1ab2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/56_just-circle3ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 3", 60.00m, null },
                    { new Guid("34787e61-0b1c-4d11-a573-1513f72228b4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 Hotwings® + a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/18_feed-my-craving-circle10ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Feed My Craving", 79.00m, null },
                    { new Guid("34dedf0d-b155-491f-bfa5-3fedfe5dc1a4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Nuggets, 1 Crunch Burger, 1 Small Chips and a Buddy Drink", "https://images.ctfassets.net/0p42pznmbeec/1L5C3sZ1MmaHtuQLewHqYa/5e4ecba1d83ade38d554eba1a7431551/ABC2120-nugget_box_buddy_1.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Nugget Box Buddy Meal", 79.90m, null },
                    { new Guid("3572b1a8-9973-4425-875f-86810d8fbdaa"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken that are tender on the inside and crunchy on the outside. Served with a generous sprinkle of fruit chutney flavour.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Sprinkle Pops", 54.90m, null },
                    { new Guid("35b7a8d3-84b1-456a-a9be-f6d1ccfffe8f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy 6 pieces of delicious original recipe chicken, 1 large chips, 1 regular coleslaw plus 2 regular mash and gravies.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "All In One Feast", 194.90m, null },
                    { new Guid("36d476b7-003f-4939-ba6d-58648f6b13f8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new Burger standard…Boxed! The Crispy Zinger burger, 1 piece of original recipe chicken, regular mash & gravy, chips & Buddy no sugar.", "https://images.ctfassets.net/0p42pznmbeec/3spYrESfEqEyv4TaIwhQnZ/e315445416a59f4ba60acf90090482dd/62279_WickedZinger_SF_-_1200x900.png?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Zinger Fully Loaded Buddy Box Meal", 115.90m, null },
                    { new Guid("371f8520-0c15-4720-83f4-dd4d9e547f13"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half Platter", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/f93c9cbe-5f94-4bb4-a937-811c28bd88df", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Big on veg platter", 640.00m, null },
                    { new Guid("38900cf8-59ff-46ea-abd9-76553252444e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken fillet + lettuce + tomato\r\n\r\n+ Soulfirenaise™ sauce on a toasted sesame bun", "https://chickenlicken.co.za/assets/uploads/products/menu/10_love-me-hot-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Hot", 37.00m, null },
                    { new Guid("3cbf66c2-89fb-4ae1-9afb-9cdf737a44c9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 Hotwings® + a portion of Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/15_hotwings-circle6ce-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Deluxe", 67.00m, null },
                    { new Guid("3e7bdc57-1d5c-44bb-a2d9-5d9b2f2f9543"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy a piece of original recipe chicken, 2 zinger wings and a small scrumptious chips.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Bucket For One", 46.90m, null },
                    { new Guid("3ff40163-4356-47d1-b276-e264f1a260aa"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8 Hotwings + toast + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/65_hotwings-meal-circle8ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Hotwings Meal", 86.00m, null },
                    { new Guid("40cd8b14-4a34-4b60-850f-e58976dcf77a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 pieces SoulFire® chicken + a portion of Soul Fries™\r\n\r\n+ 1 sachet SoulFire® sauce ", "https://chickenlicken.co.za/assets/uploads/products/menu/20_rock-my-soul-circle3ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul 3 Combo", 60.00m, null },
                    { new Guid("4129b680-1ba3-4fc9-a9c1-d4a46a8af890"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs and spices of Original Recipe® chicken, marinated and cooked to perfection.", "https://images.ctfassets.net/0p42pznmbeec/2ZE6o3XzzI7YzGsVVT4ubY/e95c55d0c1b050b91a2b070a5ad1b32e/9_piece_bucket.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1"), "9 Piece Bucket", 182.90m, null },
                    { new Guid("41ec3b30-8bd8-4041-aec5-b15e8b16009d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/57_just-circle4ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 4", 80.00m, null },
                    { new Guid("43e74758-90f8-4dce-836f-ca24e9309c5e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke No Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke No Sugar Buddy 440ml", 22.90m, null },
                    { new Guid("4479aed9-8308-49de-8662-56e6565a37fd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + a portion of Soul Fries™ + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/51_soulsister-circle2ce-max.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Max", 65.00m, null },
                    { new Guid("44c4d601-d08c-43bd-80f0-3da4b013568a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken fillet + lettuce + tomato\r\n\r\n+ Soulfirenaise™ sauce + a slice of cheese\r\n\r\non a toasted sesame bun", "https://chickenlicken.co.za/assets/uploads/products/menu/12_love-me-hot-cheese-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Hot Cheese Burger", 40.00m, null },
                    { new Guid("494263e5-fe23-4cd4-b82d-0d3b66a57707"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fanta Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Fanta Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("498ef385-879f-48dd-8ac0-9c6bb557d4cb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 KFC famous Zinger Wings dunked in a delicious honey, ginger and soy sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "4 Dunked Wings", 54.90m, null },
                    { new Guid("4c012378-e399-4359-8492-e475f9e44f54"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "10 Hot Zinger Wings", 89.90m, null },
                    { new Guid("4ca08e50-84da-4868-a55a-d3d767561510"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 SoulBites® + a portion of Soul Fries™ + a sachet of either \r\n\r\nUncle Jessups Ketchup®, SoulFire® sauce or Soulfirennaise™  sauce", "https://chickenlicken.co.za/assets/uploads/products/menu/125_soulbites-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Soul Bites Snack", 30.00m, null },
                    { new Guid("4ec1343a-2da9-425b-980e-0a18d61599b9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8 pieces + 2 regular Soul Fries™\r\n\r\n+ 2 regular Soulslaw® / Achaar / Tomato Salsa\r\n\r\n+ 2 Licken Loafs®", "https://chickenlicken.co.za/assets/uploads/products/menu/25_family-full-house-circle8ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Family Full House", 173.00m, null },
                    { new Guid("50c89ee5-f147-416e-921a-6ebef6f1a033"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Cappy Juice 1.5 Litre", 44.90m, null },
                    { new Guid("52b9d83f-965a-4c42-9aba-bd4fd3c49e95"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pulled Chicken Wraps (cut into 6), 3 Chicken Wraps (cut into 6), 2 Sharing Wedges, 16 Winglets, 2 Flame-grilled Mielies cut into 3 (6 portions). Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/ccc05d6a-734b-4fec-bbc7-50a7da7ad2da", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Hands-on delicious platter", 640.00m, null },
                    { new Guid("53985e75-05c7-4874-8d61-d4a265b21f4b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get yourself a Streetwise 1, with a Buddy no sugar free drink", "https://images.ctfassets.net/0p42pznmbeec/3QpxFh5qLJj5GT8dEMW3iZ/3acbea341f4c8d3162163373ff8ed48f/COM2029-streetwise_bucket_for_1.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Streetwise 1 Buddy", 52.90m, null },
                    { new Guid("5415ecdb-c90f-4e44-a0b5-94bdbf0c372c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 Piece + 4 Hotwing®s + 1 Licken Loaf", "https://chickenlicken.co.za/assets/uploads/products/menu/128_soul-square-meal-.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soul Square Meal", 50.00m, null },
                    { new Guid("57300a59-1520-483d-b3dd-ba7a001fc6d7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 Hotwings", "https://chickenlicken.co.za/assets/uploads/products/menu/98_hotwings-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "6 Hotwings", 42.00m, null },
                    { new Guid("5c5425c3-7c2e-4857-a312-eabaef355086"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes a regular Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/31_love-me-hot-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Hot Top Deluxe", 70.00m, null },
                    { new Guid("5d113f59-92b8-4864-ab21-8ef981bfb793"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken dunked in KFC’s famous honey, ginger and soy sauce!", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Dunked Pops", 36.90m, null },
                    { new Guid("5d7b0ef4-e374-4438-91aa-3d2df6891366"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 SoulBites®", "https://chickenlicken.co.za/assets/uploads/products/menu/124_soulbites-circle9ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a9"), "Soul Bites Max", 45.00m, null },
                    { new Guid("5eba4083-7c7f-48c0-890d-6839a601aebc"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The new Burger standard…Boxed! The new Colonel burger, 1 piece of original recipe chicken, regular mash & gravy, chips & a buddy no sugar drink.", "https://images.ctfassets.net/0p42pznmbeec/31yPC9ryh5KT1pOdwEOOzG/d1e2df6fc99eaf513f84b63f7d475f58/65129_kfc_-_FLBM_cheese_buddy_1200x900.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Fully Loaded Box Meal", 115.90m, null },
                    { new Guid("5f325665-1f3b-4e7d-ae6a-c39b7e3c328b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprite Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Sprite Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("61ffd5ce-dab8-483a-9ed4-4e69a35251c9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Hotwings® + 4 Sliders®\r\n\r\n+ 2 regular Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/23_soul-mates-classic-party.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Soul Mates Classic Party", 145.00m, null },
                    { new Guid("629fb478-1c78-4f11-82b2-a98f33197b61"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Hotwings", "https://chickenlicken.co.za/assets/uploads/products/menu/4_hotwings-circle24ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "24 Hotwings", 168.00m, null },
                    { new Guid("63c94c86-0993-40fe-b9b8-d2e210ed112e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wrapsta, 1 Piece of Original Recipe Chicken, Small Chips & Buddy Drink", "https://images.ctfassets.net/0p42pznmbeec/2snvT5LNlzizE6TGQ9KN4F/3f5c8ebf26502ad1bdf5a1cc456ccfc0/ABC1723-wrapsta_box_buddy.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a2"), "Wrapsta Box Meal", 84.90m, null },
                    { new Guid("65552484-91b4-415b-afc1-d343e0022c36"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces of crispy, delicious golden brown Nuggets, paired with 1 delicious Colonel dipping sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "6Pc Nuggets", 36.90m, null },
                    { new Guid("655cd21f-adcf-446f-bfef-5fed6372a899"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oven baked, fresh mini loaf", "https://images.ctfassets.net/0p42pznmbeec/2X0ukPSNX6j4kHDE2o2mGa/e910e8f156eb5ca37642fb19944603a0/MIS1001-1_mini_loaf.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Mini Loaf", 14.90m, null },
                    { new Guid("65c65d79-6145-4cb7-b359-61db56e16844"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes a regular Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/29_love-me-tender-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Tender Top Deluxe", 70.00m, null },
                    { new Guid("6641665c-3b74-4c41-be15-765092a36266"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes a regular Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/32_love-me-hot-cheese-top-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a8"), "Love Me Hot Cheese Top Deluxe", 72.00m, null },
                    { new Guid("669dea97-728e-4f5e-b631-0646583e9135"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 Pieces of original recipe chicken, a portion of small chips.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Three with Chips", 72.90m, null },
                    { new Guid("68853904-d7df-4730-a562-655a368bb024"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A delicious chicken patty served with shredded lettuce & Colonel dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Snack Burger", 29.90m, null },
                    { new Guid("6f3ba78b-427c-4130-9900-d56e45acecd1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + toast + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/63_lunch-meal.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Lunch Meal", 73.00m, null },
                    { new Guid("6f554267-a27d-4543-acb8-e44cba1a3226"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken fillet + lettuce + tomato\r\n\r\n+ Dreamy Creamy® sauce on a toasted sesame bun", "https://chickenlicken.co.za/assets/uploads/products/menu/7_love-me-tender-burger.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a7"), "Love Me Tender", 37.00m, null },
                    { new Guid("71a7d221-7a48-402d-9a7a-26ed83558404"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around a delicious fillet zinger recipe - a slice of cheese, hash brown, crisp lettuce, fresh tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Zinger Boxmaster", 76.90m, null },
                    { new Guid("77243f70-7a36-45e6-9b3c-011f9769be14"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A spicy, crunchy mini fillet with a slice of cheese and lettuce, covered in tangy dressing on a snack bun.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Crunch Burger", 36.90m, null },
                    { new Guid("792082d4-89a7-46ee-aba7-4048a3d94897"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The game changer is here, and with a delicious spicy crunch fillet, tomato, lettuce and cheese with tangy dressing all wrapped up in a mini tortilla and grilled to perfection, meal time will never be the same again.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Wrapsta", 42.90m, null },
                    { new Guid("79f8508a-21bc-43c4-a87d-6abd29b3171b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 pieces + a portion of Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/52_soulsister-party-circle4ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Party", 84.00m, null },
                    { new Guid("7d1e22c6-fd8f-43aa-8ab0-b4503ba9b899"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9 pieces of crispy, delicious golden brown Nuggets, paired with 1 delicious Colonel dipping sauce.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "9Pc Nuggets", 42.90m, null },
                    { new Guid("7de12c1f-7694-4fd0-8cb6-0ee17f1bf2c9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "21 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/62_family-barrel-circle21ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Family Barrel", 300.00m, null },
                    { new Guid("828f52eb-2848-4bb4-94d9-3919b7af537e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Pieces of Original Recipe Chicken and Small Chips or Coleslaw.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Two with Chips", 49.90m, null },
                    { new Guid("84f3da61-10aa-493d-8a78-86c42a61f418"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Original Slyders® + a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/44_slyder-snack-circle2ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Slyder Snack", 30.00m, null },
                    { new Guid("8705de5d-10f6-4415-9511-041d2f95a504"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke 1.5 Litre Bottle", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke 1.5 Litre Bottle", 32.90m, null },
                    { new Guid("871bd936-63a4-4db7-9422-c47b03221bb3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "24 Zinger Wings Bucket", 194.90m, null },
                    { new Guid("881474ea-cfe5-44d0-9407-d0063cd7efa8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 Pieces of Original Recipe chicken cooked to golden perfection and a large portion of chips or coleslaw.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Five", 121.90m, null },
                    { new Guid("882d8242-28dd-428e-bf3a-c06790245abd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8pc Chicken, 2 snack burgers, 4 Zinger Wings, 2 Reg Coleslaw, 2 Reg chips", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "8 Piece Family Treat", 274.90m, null },
                    { new Guid("8b17946c-91d1-494a-b433-b8997a621217"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Square chick’n burger on a toasted square bun with DREAMY CREAMY® sauce and a pickle", "https://chickenlicken.co.za/assets/uploads/products/menu/33_1-slyder-original.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Slyder Original", 14.00m, null },
                    { new Guid("8c097fb5-d557-4d78-8162-de774a993017"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Veg Burgers, 2 Halloumi & Roast Veg Wraps, 2 Halloumi & Roast Veg Pitas, 2 Sharing Wedges, 4 Flame-grilled Mielies cut into 3 (12 portions). Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/3b7bc5aa-eb6c-4f3b-a289-ae9669f410dd", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Veggie veggie nice platter", 640.00m, null },
                    { new Guid("8e044a33-6154-4b4c-a860-5057511aebb7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces + 2 regular Soul Fries™\r\n\r\n+ 2 regular Soulslaw® / Achaar / Tomato Salsa\r\n\r\n+ 2 Licken Loafs®", "https://chickenlicken.co.za/assets/uploads/products/menu/24_family-full-house-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Family Full House", 143.00m, null },
                    { new Guid("8e1513ba-024c-4fdb-8aad-e0dbb0570001"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "4 Zinger Wings", 48.90m, null },
                    { new Guid("902b9141-7b80-45e4-aa36-20a080a424cb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of creamy mash and our delicious gravy.", "https://images.ctfassets.net/0p42pznmbeec/16hT15F1AVhciJyE32xbGE/f83f8d8d906a2593420739e995086bc4/MAG1003-reg_mash___gravy.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Large Mash & Gravy", 27.90m, null },
                    { new Guid("95e6dc21-bdf6-43e0-b5df-984904d6453c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", "https://images.ctfassets.net/0p42pznmbeec/5Zt1jvrey6zim41HKaarJr/6c4e0a08f94a83f04ad98dc130ce67e1/CHI1002-lrg_chips.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Large Chips", 0m, null },
                    { new Guid("97b4b34c-e453-40f1-82de-f395974f3eda"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An icy sippable treat with Oreo bitz, and creamy soft-serve.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Oreo Krusher", 42.90m, null },
                    { new Guid("97c499c9-5aca-4280-8134-9dbd19ed9f94"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of chips, crispy on the outside, soft and fluffy on the inside.", "https://images.ctfassets.net/0p42pznmbeec/4J7RauzcyD6KkQu9Qhpp28/da6827d46db9161d26ae26c874be5123/ABC1247-sml_chips.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Small Chips", 16.90m, null },
                    { new Guid("9b02ad2b-8c3e-4443-8789-fdb9d77897cd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of freshly prepared cabbage, onions and carrots in a delicious dressing", "https://images.ctfassets.net/0p42pznmbeec/1LvCxHqjAFXs2XFgAbQpnG/44719dee762ff4f7106e33d8c4f300f9/ABC2225-reg_coleslaw.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Coleslaw", 24.90m, null },
                    { new Guid("a44e3af7-ec0b-4fff-94b3-91a7f8f2e686"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chocolate Milkshake", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Chocolate Milkshake", 31.90m, null },
                    { new Guid("a4ac927e-8d59-4c71-aea1-820cab1d6620"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Try the new standard! The New Colonel burger, Our trademark real chicken fillet; A fresh Brioche bun, Creamy Colonel sauce and cheese on a fresh bed of lettuce & succulent tomatoes", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Colonel Burger", 60.90m, null },
                    { new Guid("a6a3343b-bacc-495b-889f-40185d5950e6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A generous sharing platter of 4 succulent Flame-grilled Shisanyama Chicken Sosaties and 20 Winglets, served with 2 portions of our Sharing Wedges, 2 Garlic Rolls and our special PERinase dip.", "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/3d93a55d-440a-407c-8b7b-97cc1e6c510a", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Cabo Sosatie Snack Platter", 349.00m, null },
                    { new Guid("a9a9973d-6de9-4bec-8821-e33837744c31"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 Piece Chicken", "https://images.ctfassets.net/0p42pznmbeec/2XhP71I12p5tncjyX1P81w/d94f9543674f4728165031f42dcb2653/ALA1001-1pc_cob.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "1 Piece Chicken", 26.90m, null },
                    { new Guid("aaaa750c-a0de-459a-8f0a-17d4f3916022"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy KFC`s new Jalapeno loaded fries with brand new Hot * spicy sauce", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Jalapeno Loaded Fries", 32.90m, null },
                    { new Guid("b04a4c52-b763-4500-bce2-ccb76e73ded4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10pc Chicken, 2 snack burgers, 4 Zinger Wings, 2 Reg Coleslaw, 2 Reg chips", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "10 Piece Family Treat", 316.90m, null },
                    { new Guid("b0ae4d1a-4ac7-4838-9acb-3cee54ca6c5f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca-Cola Sugar Buddy 440ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coca-Cola Sugar Buddy 440ml", 24.90m, null },
                    { new Guid("b20d66c2-d899-48e8-bea1-0a457bf2006a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs & spices.", "https://images.ctfassets.net/0p42pznmbeec/WKTb7n2vvpdYR1v8mvXX0/4d01e6a6cf892c116f2e82bdd4b64b6a/66752_-_E-Commerce_15_pc_Bucket_1200x900.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a1"), "15 Piece Bucket", 279.90m, null },
                    { new Guid("b9ae1079-f91c-486c-8c11-a11b14be7e78"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 Hotwings® + a portion of Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/46_hotwings-snack.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Hotwings Snack", 30.00m, null },
                    { new Guid("bb7e9c72-a927-497b-972d-71453a2ec31c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + a Licken Loaf", "https://chickenlicken.co.za/assets/uploads/products/menu/129_soulsister-2-vibe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Vibe", 40.00m, null },
                    { new Guid("bd489887-bf60-446c-ae4e-468e5546aab9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15 pieces", "https://chickenlicken.co.za/assets/uploads/products/menu/61_family-bucket-circle15ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Family Bucket", 230.00m, null },
                    { new Guid("bde82396-035d-4df8-9e13-a12f578d2b18"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Popcorn Chicken® in a shaker cup\r\n\r\n+ 2 sachets SoulFire® sauce or\r\n\r\n2 sachets of Uncle Jessup’s® Ketchup\r\n\r\nto shake up the taste!", "https://chickenlicken.co.za/assets/uploads/products/menu/45_popcorn-chicken-shaker.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a6"), "Popcorn Chicken Shaker", 30.00m, null },
                    { new Guid("be29abf0-a0d0-4ebe-974f-8f2b80a597b4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Try the new standard! The New Crispy Zinger burger, Our trademark real chicken fillet; A fresh Brioche bun, New Hot & Spicy sauce and cheese on a fresh bed of lettuce & succulent tomatoes", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "New Zinger Burger", 60.90m, null },
                    { new Guid("be4266cb-360f-4dc7-927b-c85b59ff26ff"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bonaqua Still Spring Water 500ml", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Bonaqua Still Spring Water 500ml", 19.90m, null },
                    { new Guid("bf0ce8b1-deda-4501-a069-3082b80918fc"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "16 Hotwings® + 2 regular Soul Fries™", "https://chickenlicken.co.za/assets/uploads/products/menu/17_hotwings-party-circle16ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Hotwings Party", 132.00m, null },
                    { new Guid("c81cbbc2-c4dc-4e08-ba10-3bbfe3961763"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 pieces + a portion of Soul Fries™ + 440ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/53_soulsister-party-circle5ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Party", 112.00m, null },
                    { new Guid("ca1d4a42-5b47-42f9-8696-002f09cb4088"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "  Square chick’n burger on a toasted square bun with DREAMY CREAMY® sauce and a pickle and cheese", "https://chickenlicken.co.za/assets/uploads/products/menu/36_1-slyder-cheese.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Cheese Slyder", 16.00m, null },
                    { new Guid("cc6e24b5-dbbb-4d3a-aa64-c7253e22469f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Hotwings", "https://chickenlicken.co.za/assets/uploads/products/menu/3_hotwings-circle12ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "12 Hotwings", 84.00m, null },
                    { new Guid("ccf4437d-0c1a-4d39-a422-5b5c4bab5533"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pieces + a portion of Soul Fries™ + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/50_soulsister-circle2ce-deluxe.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a4"), "Soul Sister Deluxe", 62.00m, null },
                    { new Guid("cebb7251-009c-468a-b379-5193dd60dba9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Pieces of original recipe chicken cooked to golden perfection and a regular portion of pap & small gravy.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "Streetwise Two with Pap", 49.90m, null },
                    { new Guid("d1ee9fd2-e371-474a-9157-be686f74c1f3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "24 Zinger Wings Bucket", 194.90m, null },
                    { new Guid("d3888efc-244f-4642-a5e9-4fea8bbb0dca"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8 Hotwings + toast + 300ml Coke", "https://chickenlicken.co.za/assets/uploads/products/menu/66_hotwings-meal-max-circle8ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a1"), "Hotwings Meal Max", 90.00m, null },
                    { new Guid("d7388d80-8eb2-497a-9072-0db957250319"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Square chick’n burger on a toasted square bun with SOULFIRENAISE™ sauce and a pickle", "https://chickenlicken.co.za/assets/uploads/products/menu/39_1-slyder-chilli.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "1 Slyder Chilli", 14.00m, null },
                    { new Guid("d7cd9a71-8c94-47a0-b0c3-1ab0940fe8f7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extra Hot & Spicy Zinger sauce on the side", "https://images.ctfassets.net/0p42pznmbeec/bEZLbUGmprwC7wW3i0GsS/73b63ef3ac73d2e805688b74cdbc31c0/Hot_n_Spicy_sauce_-_1200x900.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Sauce - Hot & Spicy", 0m, null },
                    { new Guid("d80b06d3-e76d-47ca-be1d-4b50b2e27686"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 pieces SoulFire® chicken + 1 regular Soul Fries™\r\n\r\n+ 2 sachets SoulFire® sauce", "https://chickenlicken.co.za/assets/uploads/products/menu/21_rock-my-soul-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a3"), "Rock My Soul", 105.00m, null },
                    { new Guid("d9789d14-f81f-47b7-9746-4b53a7871038"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portion of creamy mash and our delicious gravy.", "https://images.ctfassets.net/0p42pznmbeec/16hT15F1AVhciJyE32xbGE/f83f8d8d906a2593420739e995086bc4/MAG1003-reg_mash___gravy.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a8"), "Regular Mash & Gravy", 19.90m, null },
                    { new Guid("dd9e45c9-dd4e-44ff-be72-4090fbe304ad"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy 4 pieces of original recipe chicken, 2 small chips, 1 small pops & 2 buddy no sugar drinks.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a5"), "2 Can Dine Buddy", 164.90m, null },
                    { new Guid("e6ce19f9-4fe1-4105-8aae-163f930bc2e8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Two full chickens (cut into 16), 16 Winglets, 2 Flame-grilled Mielies cut into 3 (6 portions), 2 Sharing Wedges. Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/fa60cb07-3c21-4718-8f02-cb91fd83319b", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "Peri-er Platter", 640.00m, null },
                    { new Guid("e83cf236-a12f-4303-adcf-82bf27599e4d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Square chick’n burgers on toasted square buns with DREAMY CREAMY® sauce and a pickle", "https://chickenlicken.co.za/assets/uploads/products/menu/34_2-slyders-original.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a0"), "2 Original Slyders", 27.00m, null },
                    { new Guid("e9e29b08-c323-4b96-bea2-9f60d14537cd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coke No Sugar 1.5 Litre", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Coke No Sugar 1.5 Litre", 29.90m, null },
                    { new Guid("eba572be-81ef-4303-be1b-c05cb125e699"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 piece", "https://chickenlicken.co.za/assets/uploads/products/menu/54_just-circle1ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a5"), "Just 1", 20.00m, null },
                    { new Guid("f253afd7-db5f-47bc-bf6f-d8c4d1c70c40"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "One and a 1/2 full chickens ( cut into 12), 2 Flame-grilled Mielies cut into 3 (6 portions), 4 Kids Burgers, 2 Sharing Wedges. Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.", "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/5182f543-741a-4317-a731-e8098a228c37", null, null, new Guid("2013179f-1117-173a-a4d5-a6571b43e6a1"), "More to share platter", 640.00m, null },
                    { new Guid("f4e5ac70-c1c2-4d1e-8d06-bf8d6f8cf8aa"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milk shake milk shake shake shake", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a4"), "Strawberry Milkshake", 31.90m, null },
                    { new Guid("f70b1e1d-d10d-4c15-8abf-d7706c76a076"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bite-sized pieces of chicken, tender on the inside and crunchy on the outside.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a6"), "Large Pops", 54.90m, null },
                    { new Guid("f7dfa71a-5623-456d-8f11-987c92de821b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get yourself a Streetwise 5, with 2 Buddy No Sugar", "https://images.ctfassets.net/0p42pznmbeec/2uwM3hjbse4hzaZv6d5peO/576343077547dc714bf02883a79589f6/ICM1009-streetwise_5_chips.jpg?h=600&w=800&fm=webp&fit=fill", null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a3"), "SW Bozza Streetwise 5 Buddy", 143.90m, null },
                    { new Guid("fab79172-03e7-46d5-ae5a-e93159323ba4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A warm tortilla wrapped around 2 deliciously crispy chicken strips, shredded crisp lettuce, sliced tomato and a dash of Colonel dressing.", null, null, null, new Guid("2013179f-1037-173a-a4d5-a6571b43e6a7"), "Classic Twister", 66.90m, null },
                    { new Guid("fb7b1371-a532-4857-8830-5be0cac5f6ca"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 SoulBites®", "https://chickenlicken.co.za/assets/uploads/products/menu/123_soulbites-circle6ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a9"), "Soul Bites", 38.00m, null },
                    { new Guid("fe060403-e205-4260-a060-d4ed3854bd5d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "36 Hotwings", "https://chickenlicken.co.za/assets/uploads/products/menu/5_hotwings-circle36ce.png", null, null, new Guid("2014179f-1037-173a-a4d5-a6571b43e6a2"), "36 Hotwings", 231.00m, null }
                });
        }
    }
}
