using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Update_UserStudentCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fe0e9c2d-6abd-4f73-a635-63fc58ec700e"));

            migrationBuilder.AddColumn<string>(
                name: "StudentCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "bd107739-7811-40b4-9e9f-c4da73d2c190");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "24896827-3250-414f-a416-84193e7ecd4d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "6d16d062-83c5-4699-9c8d-7da236861780");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79a6edbb-0fba-4c61-89d2-8d44570ec0b7", "AQAAAAEAACcQAAAAEC3a8UeX5vI6SaDpC8PkUUOPi4GayCxsmOHr827HcQ4v9MbtkHeD6LDYAs2G9L7HOg==", "b2af8784-019a-40b9-b85c-f84a78751b72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c85649c-2d04-4846-a5f2-212ea550291b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StudentCode" },
                values: new object[] { "4eccef76-b2cd-4098-ae8a-a75dcd2569f6", "AQAAAAEAACcQAAAAEKgIsTLPJ+ZdXpkep9ZRLwGoGoVr5fNwEs696JSLN+E3cAsfK9NGYyCQUhiTaA7cJA==", "0d05a40d-324e-4485-a29b-2eb7db31b8b2", "LamntDongDa10001" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e63d277b-f725-48ea-a564-5ca20854c669", "AQAAAAEAACcQAAAAEEvnRkiX7q+bNiA3alFidKQvxdbsFIKcpv5ZrCG2AbYhMJH7AhK4g4hvgNEezDTOSA==", "1b80beab-9cea-4ed6-92e6-ccee9b858a30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b551fd08-76d9-4040-b0fa-fb2e7aacbe7d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f2d4512-80d6-4d27-a0e7-a09b134e4ab3", "AQAAAAEAACcQAAAAEBGy+IeaZ1kQ66sNpdc5f3LVftZdXByFC2bEXzray1c011LdfRKZ5c/Arx8Xr8iLXQ==", "37a0f915-0834-4f36-9aa9-e9cbcbbec08e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8ddc2e0-8b14-4c37-869e-7ca5bad4671a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5866c71-c014-4f37-bf6d-2ef90d37d0ee", "AQAAAAEAACcQAAAAEGsOB6jC1Kit6UBJjE+ykvhARAEZ0pIUVkvITYno/iBC5ehBlD75fw5eImf9KOJzQQ==", "ec5e7e80-d326-4eff-a20c-f84411f199dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c3a4a2eb-1703-4fc5-8511-f68acdb3a1d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67db3817-3c2d-420d-a048-3de910f30cce", "AQAAAAEAACcQAAAAEGYw6jl+XTRfkZMh+wWgf253rko9KkZO+yss1WIvICt6OllQqdh7t9dJpnmyeosbbg==", "bbec4d66-b845-4c7b-9003-7f31f87e5a9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7d19c1e-a674-4d77-978a-47bbacd6910e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "920d1dd5-68f7-4178-b31e-501916785d29", "AQAAAAEAACcQAAAAEM9W4K2eJiO1HLknLfUdsCtFOkpqhrJEsce2Z7mQC9ePQRFaJnKOZdZDYL8Gx+JFNQ==", "c4347d4c-84d8-4a00-8bb6-b46657568509" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 15, 48, 701, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 15, 48, 701, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 15, 48, 701, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 15, 48, 701, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 15, 48, 701, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 15, 48, 701, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 15, 48, 701, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 15, 48, 701, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 15, 48, 701, DateTimeKind.Local).AddTicks(3505));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentCode",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "b69e14d1-d9ae-4036-8d92-8681e3dc5dbc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "0f243720-dcd4-4991-bc33-2c3416ffc6ad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "0315709c-254f-4133-a7d6-92fe1edfd8fc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("fe0e9c2d-6abd-4f73-a635-63fc58ec700e"), "9bf4ff8d-c473-4c51-b552-c9fbe021f304", "Parent", "PARENT" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e78ca86-d0cc-4b83-bdf2-a4bea4f74c1d", "AQAAAAEAACcQAAAAEFV+hP7uwByIiVC2++6JEnPT9WdTJM/Soc4S/z8enhFlGNizO1+PVRFc84Y7TPUozg==", "98b2c418-f079-4174-a58d-91ede0c0e805" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c85649c-2d04-4846-a5f2-212ea550291b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff630956-52ce-4029-b613-57e407a2b150", "AQAAAAEAACcQAAAAEF6K7B8THeZZ1okNxOOY9pnlX4nua547WwwZ8vVFOychI4AGJLSDjMbbsxrTgLUNNA==", "68124207-5ffa-4fcd-b3b3-3d451231fa92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8184dab5-79d9-4011-9887-3177c2d521ea", "AQAAAAEAACcQAAAAEEq78tcbAUyZh/VEvvuyZ6fdJzoKLX8DAjI3/qCFnKaWM9JkmWDzCtz25Q1xG7ksNQ==", "a037f76e-a498-480f-8414-ba971f11c62c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b551fd08-76d9-4040-b0fa-fb2e7aacbe7d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cbc46cc-6134-441f-bbe5-eba646fe1010", "AQAAAAEAACcQAAAAENx2tF5ZskwSuTv/fZTaZ+hGR3YmFH9LzPd4TqAYiLmM4JxDnxqGAYnCqGBfNSHkJw==", "4f98f0c1-977c-4cc8-ae4a-c528926e8d5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8ddc2e0-8b14-4c37-869e-7ca5bad4671a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfe527cb-d307-4475-8ee1-5ad547a95526", "AQAAAAEAACcQAAAAEPhA22Q+Wug4svvPa/zce/lBaxAUEGNl8VFcVJcNBoH2+dG3VdrJ8l16k7xe0NEkGQ==", "eaaf093c-bbf7-458c-9415-0140d2e896a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c3a4a2eb-1703-4fc5-8511-f68acdb3a1d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c831722-24a4-4ccc-a8c4-932954a3cb86", "AQAAAAEAACcQAAAAEFwULWfdC1016pHCZu03isHXj2h5/JFFpWKU9d00pG2vlJquthrau8+/E7pXfD3W3w==", "63e94dac-50de-44cf-b497-b4efe9d44ae8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7d19c1e-a674-4d77-978a-47bbacd6910e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14c6219a-395c-4ae6-89cb-1ea855e253e1", "AQAAAAEAACcQAAAAEM0KJPJW1phpdWNUMxw9qGO/uHeC0vgcKxhHcN17wesXoRaWWbJo6kLXTFRTbbBMuA==", "4684a342-3ab2-4166-a481-287f282d36f8" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 10, 26, 674, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 10, 26, 674, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 10, 26, 674, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 10, 26, 674, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 10, 26, 674, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 10, 26, 674, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 10, 26, 674, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 10, 26, 674, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 10, 26, 674, DateTimeKind.Local).AddTicks(809));
        }
    }
}
