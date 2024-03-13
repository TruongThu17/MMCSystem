using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class UpdateDataUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "f8c3e2b8-2c9e-49ba-8f28-7164a70d9afe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "41f3494b-2212-487f-9878-8e807f427754");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "022a2647-67c4-4f12-a6de-8f9c87d08918");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fe0e9c2d-6abd-4f73-a635-63fc58ec700e"),
                column: "ConcurrencyStamp",
                value: "aceffd70-50e4-44df-ad2b-c1ca4f7ea638");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "EducationId", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0d6b89f4-0d6e-4aa9-aff2-1ed3c1db2fb3", 1, "DongDa@gmail.com", "DONGDA@GMAIL.COM", "DONGDA", "AQAAAAEAACcQAAAAEJyAvWeiNqZ8ST+ksoCBa5j06zw16UozHICVJwcUMBps03XjmXs/eDd/H6TbPQSfsg==", "f2a2e251-4aab-40a4-a116-9d42b77e9df6", "DongDa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2288a82-909e-4e78-98c8-d48e92654f3d", "AQAAAAEAACcQAAAAEDvV3TNu7P/mxgX7Oi2ONAiVpmhmMpSg/hx02dOKeVnTdHe8aHG5FWBLJoCVKDosWQ==", "70093915-fc43-48cb-ab41-d223ad8b00fc" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDay", "ClassId", "ConcurrencyStamp", "EducationId", "Email", "EmailConfirmed", "FullName", "Img", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "ParentFullName", "ParentPhone", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("b551fd08-76d9-4040-b0fa-fb2e7aacbe7d"), 0, null, null, null, "9e8ea727-fba2-4bd5-9ea1-e8871a37bc4a", 5, "LeLoi@gmail.com", true, null, null, false, null, "LELOI@GMAIL.COM", "LELOI", null, null, "AQAAAAEAACcQAAAAEO+b8ZsFrXoJxyptnjb4qW1HtUL2Y7KN23BI2s+M4YIzI1YhhRDK0PQDxE1IkKlkhw==", null, null, true, "6fc3792f-2c11-4a90-b68e-8bfe3853c20c", true, true, "LeLoi" },
                    { new Guid("b8ddc2e0-8b14-4c37-869e-7ca5bad4671a"), 0, null, null, null, "08512db1-db30-4fee-9534-2d28e9a12c49", 2, "NguyenDu@gmail.com", true, null, null, false, null, "NGUYENDU@GMAIL.COM", "NGUYENDU", null, null, "AQAAAAEAACcQAAAAEPKi4qhfRgyUu3L68XuEYddPaX4qvOqAS7z5iumlfhcXgM8bl8E9sjh63AP3CuJ3aQ==", null, null, true, "15083606-2f71-4498-901f-996faeb89f46", true, true, "NguyenDu" },
                    { new Guid("c3a4a2eb-1703-4fc5-8511-f68acdb3a1d9"), 0, null, null, null, "1cbab019-07de-4660-8c80-ccf9175a09c2", 3, "PhanChuTrinh@gmail.com", true, null, null, false, null, "PHANCHUTRINH@GMAIL.COM", "PHANCHUTRINH", null, null, "AQAAAAEAACcQAAAAEPQLcXyEAeOFV3GmSDmB+CD3gLBsw0m58/9/hXAYS8MuNOv0qqpLzh52OiNmIIFNyw==", null, null, true, "7f29baad-3ee1-4347-88d0-114b50fe1e74", true, true, "PhanChuTrinh" },
                    { new Guid("e7d19c1e-a674-4d77-978a-47bbacd6910e"), 0, null, null, null, "bb47ae8e-b503-4c7b-a80f-4519a8a334ca", 4, "TranHungDao@gmail.com", true, null, null, false, null, "TRANHUNGDAO@GMAIL.COM", "TRANHUNGDAO", null, null, "AQAAAAEAACcQAAAAEDb1RwhpWPcEDTvdiX4hjx/ziLdnvB+Vvk1M7BhOVmp0bKfozM38/qKMasTKdfXuFQ==", null, null, true, "4be6be88-1bcf-4803-a331-f6cc923f70a7", true, true, "TranHungDao" }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 13, 21, 55, 20, 467, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 13, 21, 55, 20, 467, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 13, 21, 55, 20, 467, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 13, 21, 55, 20, 467, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 13, 21, 55, 20, 467, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 13, 21, 55, 20, 467, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 13, 21, 55, 20, 467, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 13, 21, 55, 20, 467, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 13, 21, 55, 20, 467, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.InsertData(
                table: "Class",
                columns: new[] { "ClassId", "ClassName", "ClassTypeId", "EducationId" },
                values: new object[,]
                {
                    { 1, "Lớp 1a", 1, 1 },
                    { 2, "Lớp 1b", 1, 1 },
                    { 3, "Lớp 1c", 1, 1 },
                    { 4, "Lớp 2a", 2, 1 },
                    { 5, "Lớp 2b", 2, 1 },
                    { 6, "Lớp 2c", 2, 1 },
                    { 7, "Lớp 3a", 3, 1 },
                    { 8, "Lớp 3b", 3, 1 },
                    { 9, "Lớp 3c", 3, 1 },
                    { 10, "Lớp 4a", 4, 1 },
                    { 11, "Lớp 4b", 4, 1 },
                    { 12, "Lớp 4c", 4, 1 },
                    { 13, "Lớp 5a", 5, 1 },
                    { 14, "Lớp 5b", 5, 1 },
                    { 15, "Lớp 5c", 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"), new Guid("b551fd08-76d9-4040-b0fa-fb2e7aacbe7d") },
                    { new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"), new Guid("b8ddc2e0-8b14-4c37-869e-7ca5bad4671a") },
                    { new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"), new Guid("c3a4a2eb-1703-4fc5-8511-f68acdb3a1d9") },
                    { new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"), new Guid("e7d19c1e-a674-4d77-978a-47bbacd6910e") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"), new Guid("b551fd08-76d9-4040-b0fa-fb2e7aacbe7d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"), new Guid("b8ddc2e0-8b14-4c37-869e-7ca5bad4671a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"), new Guid("c3a4a2eb-1703-4fc5-8511-f68acdb3a1d9") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"), new Guid("e7d19c1e-a674-4d77-978a-47bbacd6910e") });

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b551fd08-76d9-4040-b0fa-fb2e7aacbe7d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8ddc2e0-8b14-4c37-869e-7ca5bad4671a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c3a4a2eb-1703-4fc5-8511-f68acdb3a1d9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7d19c1e-a674-4d77-978a-47bbacd6910e"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "385a745a-75d2-48e9-b6cb-ae4349451ba9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "8a9a91f7-e29c-49e5-8d6b-271ca1d572b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "78df5252-3cf4-4e4d-969e-1c8def2c2762");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fe0e9c2d-6abd-4f73-a635-63fc58ec700e"),
                column: "ConcurrencyStamp",
                value: "e7ab255b-5620-4be3-a875-762b81416414");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "EducationId", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4fcc1d9f-aee1-4a60-ad94-10e4f5797344", null, "admin@gmail.com", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEENpKMVcJ7pyx0ap/XbHinMPfSyR8t+EeDE4YpZs8cn8+uSGc0ZeOnt4t5b63H350Q==", "0ea8a518-8893-4ef5-bfa3-5bc9bcd3ff41", "Admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21ae8bb1-2baf-4ac7-a81d-0d7f52a62dc8", "AQAAAAEAACcQAAAAEJxL9hebp/I8rI6O72p0Q4NnnYtJ9nX6GZlwVNACutF3xowAadRyGf9a+kusyTebrw==", "81d40a34-d973-4791-94d4-4a3cfac2994c" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 13, 11, 49, 30, 609, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 13, 11, 49, 30, 609, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 13, 11, 49, 30, 609, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 13, 11, 49, 30, 609, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 13, 11, 49, 30, 609, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 13, 11, 49, 30, 609, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 13, 11, 49, 30, 609, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 13, 11, 49, 30, 609, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 13, 11, 49, 30, 609, DateTimeKind.Local).AddTicks(4124));
        }
    }
}
