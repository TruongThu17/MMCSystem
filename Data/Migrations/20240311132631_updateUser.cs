using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class updateUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "14d0f749-b424-4cdf-aef0-015940a6cb84");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "d057854c-45fa-4c72-95b2-62757e890503");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "363b1dd7-9b07-4e74-b034-50e3147fcd15");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fe0e9c2d-6abd-4f73-a635-63fc58ec700e"),
                column: "ConcurrencyStamp",
                value: "721c1655-d07d-468b-8411-7e5055722224");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "976d486a-7ba8-4223-928e-16d52598aa83", "AQAAAAEAACcQAAAAEAxzDIK7F0FZSMPBOje7aTnn9Wz8ZGSDZefCHexETJHX9D8aMofW+D+PQUtH3NhhHA==", "ef7a074c-1592-4c87-ae5b-9bd532e60b89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66954b0d-e2ab-4dd5-964c-19670c7f3701", "AQAAAAEAACcQAAAAEFW205nGppkXWKkFc4FsvY5YmBqeuEGZ3Wcyk1FWYdiFrxl/PSanGlLLRB9wT3qN6Q==", "db6dc8f5-c57f-4629-84b1-780af57bf77f" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 11, 20, 26, 30, 754, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 11, 20, 26, 30, 754, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 11, 20, 26, 30, 754, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 11, 20, 26, 30, 754, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 11, 20, 26, 30, 754, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 11, 20, 26, 30, 754, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 11, 20, 26, 30, 754, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 11, 20, 26, 30, 754, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 11, 20, 26, 30, 754, DateTimeKind.Local).AddTicks(8101));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "8e98f4cb-74a8-4e07-bb9b-51b8a7fea726");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "7b04661a-7056-41dd-9682-747c58f8fc18");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "4753b31c-2825-4bdf-a5ad-91668b945b02");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fe0e9c2d-6abd-4f73-a635-63fc58ec700e"),
                column: "ConcurrencyStamp",
                value: "5fac00ea-8b23-4cee-b872-575d60a2bd15");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d753e68c-da59-4ac6-9c3b-88f2c5655670", "AQAAAAEAACcQAAAAEAyXFxWqD9Hc1jfkXYI5dsFQJIRRxCHzxqos0jkV5CXqvyuleZDr/U+drIQ1FmIwBA==", "f7800bd1-29f6-49e5-bbe5-53c453cbc171" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82445c97-9203-4909-b268-d89f958db0eb", "AQAAAAEAACcQAAAAEH7S0vDijnGkp5CxbcC2ogrIDOxdyMuLyen+CV67674aTnN3GLAbraIyye8AOecIaA==", "3a9272d7-8351-40ff-90e0-77c5c07f8a41" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 9, 20, 42, 18, 439, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 9, 20, 42, 18, 439, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 9, 20, 42, 18, 439, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 9, 20, 42, 18, 439, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 9, 20, 42, 18, 439, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 9, 20, 42, 18, 439, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 9, 20, 42, 18, 439, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 9, 20, 42, 18, 439, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 9, 20, 42, 18, 439, DateTimeKind.Local).AddTicks(349));
        }
    }
}
