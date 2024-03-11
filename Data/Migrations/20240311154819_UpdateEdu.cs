using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class UpdateEdu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "6023a42b-f00b-4fd7-89ac-87114b6dc492");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "7b4e1e47-0c9d-4241-962a-3a963027fb5f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "fc60626a-a5cf-41d4-b2b7-a4ce0ab302eb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fe0e9c2d-6abd-4f73-a635-63fc58ec700e"),
                column: "ConcurrencyStamp",
                value: "e6c928a2-a757-4770-8945-f58f11c22ff7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0952d9a-9bb4-4237-9224-9d9bede7fb55", "AQAAAAEAACcQAAAAEFKSAa7xJ1Y2Cvkx8Ikclwgmj47zBDamiSxbtM+172Voew7zUIcvpbBDEACySsp/nQ==", "24ceddd2-ced7-4b9f-a9fc-e41a625c901b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45004df9-1db2-4af5-9778-11394201771d", "AQAAAAEAACcQAAAAEIWg30ES46YRzxkVVDvugelvcCjkr1wsX42k2TFrhT7fbcSoYA6DC3byoVKQqeovyQ==", "9c2c2354-3ba7-4ac8-8adb-bcabf812887f" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 11, 22, 48, 19, 505, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 11, 22, 48, 19, 505, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 11, 22, 48, 19, 505, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 11, 22, 48, 19, 505, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 11, 22, 48, 19, 505, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 11, 22, 48, 19, 505, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 11, 22, 48, 19, 505, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 11, 22, 48, 19, 505, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 11, 22, 48, 19, 505, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EducationId",
                table: "AspNetUsers",
                column: "EducationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Education_EducationId",
                table: "AspNetUsers",
                column: "EducationId",
                principalTable: "Education",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Education_EducationId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EducationId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "AspNetUsers");

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
    }
}
