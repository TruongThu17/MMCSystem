using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"));

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("6335deda-9f1c-43d4-908f-58073ff07896"), new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82445c97-9203-4909-b268-d89f958db0eb", "AQAAAAEAACcQAAAAEH7S0vDijnGkp5CxbcC2ogrIDOxdyMuLyen+CV67674aTnN3GLAbraIyye8AOecIaA==", "3a9272d7-8351-40ff-90e0-77c5c07f8a41" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDay", "ClassId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "ParentFullName", "ParentPhone", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"), 0, null, null, null, "d753e68c-da59-4ac6-9c3b-88f2c5655670", "admin@gmail.com", true, null, false, null, "ADMIN@GMAIL.COM", "ADMIN", null, null, "AQAAAAEAACcQAAAAEAyXFxWqD9Hc1jfkXYI5dsFQJIRRxCHzxqos0jkV5CXqvyuleZDr/U+drIQ1FmIwBA==", null, null, true, "f7800bd1-29f6-49e5-bbe5-53c453cbc171", true, true, "Admin" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"), new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"), new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6335deda-9f1c-43d4-908f-58073ff07896"), new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "28685835-19aa-4d7c-ad2f-c3b8dc7e9246");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "f327318d-3452-4e9e-ae53-90bdbe0f04e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "a6077daf-e79d-4fc2-a3cc-f8ffab377689");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fe0e9c2d-6abd-4f73-a635-63fc58ec700e"),
                column: "ConcurrencyStamp",
                value: "d2ea9149-4f82-4dce-a5e8-fe482e0433d0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca9f0e43-c614-40fa-bab9-63e992975684", "AQAAAAEAACcQAAAAEFT91GlW9FRde8uHBWTEOYmIsVkLmjD5pmh1bbRZXL/Vj3nr7hOVU1xvM6Y1jAd0MQ==", "1099ed38-95fd-4e9d-aa3b-87c75e2b5260" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDay", "ClassId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "ParentFullName", "ParentPhone", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"), 0, null, null, null, "c4f8ac36-1561-45a0-a7a9-5a49bd341add", "admin@gmail.com", true, null, false, null, "ADMIN@GMAIL.COM", "ADMIN", null, null, "AQAAAAEAACcQAAAAENPoOIha5TdJj5C799nZaLPnTV4o+yZr0MGKxJnrbg9cR4Oelb1xiBXGJSRcWDrnhw==", null, null, true, "3c4ce554-ba09-42e5-90e1-d8c209bde5ea", true, true, "Admin" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 8, 1, 6, 5, 365, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 8, 1, 6, 5, 365, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 8, 1, 6, 5, 365, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 8, 1, 6, 5, 365, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 8, 1, 6, 5, 365, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 8, 1, 6, 5, 365, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 8, 1, 6, 5, 365, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 8, 1, 6, 5, 365, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 8, 1, 6, 5, 365, DateTimeKind.Local).AddTicks(4507));
        }
    }
}
