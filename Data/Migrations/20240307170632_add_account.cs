using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class add_account : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "a9e6c530-2f08-41d3-93a8-7a29dd6a60d2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "45f5dfa5-6349-48f9-bdb4-ed32de8b8fe2", "Staff", "STAFF" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fe0e9c2d-6abd-4f73-a635-63fc58ec700e"),
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2d150cec-85e1-4a92-a2ab-411cd2df665b", "Parent", "PARENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("6335deda-9f1c-43d4-908f-58073ff07896"), "e4c97408-80d8-40be-974b-1d9526c70566", "SuperAdmin", "SUPERADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec1fb9ff-ab9e-46ca-bb43-f21caecc6c2f", "AQAAAAEAACcQAAAAEDOyS71yf0rZ88vLZmqSvxo5+m1sHU0DGUlEgPu0rmirykr//fLd53zMoQDRPj82LQ==", "02f8626a-a7d6-4e4a-b4db-9d433b454c5f" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDay", "ClassId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "ParentFullName", "ParentPhone", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"), 0, null, null, null, "a0b087b7-eefd-4ac3-a4e6-cc3bcedfcc9d", "superadmin@gmail.com", true, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", null, null, "AQAAAAEAACcQAAAAEDHryxv5bg2/ioQL3hYZy1tFCuPXclJmanEigh2Ui9ERLM0jZ3ZsmWtgDMrNrXQCQA==", null, null, true, "b7efe980-f115-4955-98af-3b4dfa17a81e", true, true, "SuperAdmin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"));

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
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01661a32-69fb-4aaa-8bd3-d71aaeeac0c9", "Manage", "MANAGE" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fe0e9c2d-6abd-4f73-a635-63fc58ec700e"),
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2fbeb3bf-8d45-49ba-ac6c-0b69b60bac49", "Cashier", "CASHIER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "112d753a-7e72-433c-99df-aac104c1ab5b", "AQAAAAEAACcQAAAAEP+AxUGOOPwYXnsRZ3Y0OvhzzesCVVtTKokblvXb56LbKINXV3RVYnE+0mo+IdyQUg==", "9e7e8921-9d49-4ad6-a4c3-a8e6e700495b" });
        }
    }
}
