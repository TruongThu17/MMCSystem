using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class add_education : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "Class",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "f2cf6203-6121-42ba-a9b9-3a0c642d8b89");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "01661a32-69fb-4aaa-8bd3-d71aaeeac0c9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fe0e9c2d-6abd-4f73-a635-63fc58ec700e"),
                column: "ConcurrencyStamp",
                value: "2fbeb3bf-8d45-49ba-ac6c-0b69b60bac49");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "112d753a-7e72-433c-99df-aac104c1ab5b", "AQAAAAEAACcQAAAAEP+AxUGOOPwYXnsRZ3Y0OvhzzesCVVtTKokblvXb56LbKINXV3RVYnE+0mo+IdyQUg==", "9e7e8921-9d49-4ad6-a4c3-a8e6e700495b" });

            migrationBuilder.CreateIndex(
                name: "IX_Class_EducationId",
                table: "Class",
                column: "EducationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_Education_EducationId",
                table: "Class",
                column: "EducationId",
                principalTable: "Education",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_Education_EducationId",
                table: "Class");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropIndex(
                name: "IX_Class_EducationId",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "Class");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "4df7dfe1-ae6e-4676-8f6e-d6c7ad509b94");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "4152cf9c-21ba-4b6c-92ab-b2db6494837c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fe0e9c2d-6abd-4f73-a635-63fc58ec700e"),
                column: "ConcurrencyStamp",
                value: "ac8d7758-cd05-41ee-af2c-066f043cb3c6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76f8a5dc-1ed6-4c0c-8915-4705814b4e2c", "AQAAAAEAACcQAAAAEH+y9Utzv3Myz2OKyupJelvP23eDxUE4UekDGhdgJ/+feem8V6WqS6zicMuhPjFPBg==", "cb660d3c-3abe-453f-afb0-1baf525fdef7" });
        }
    }
}
