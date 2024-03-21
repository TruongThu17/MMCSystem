using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Update_UserInfor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentPhone",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Phone",
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
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0315709c-254f-4133-a7d6-92fe1edfd8fc", "Student", "STUDENT" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fe0e9c2d-6abd-4f73-a635-63fc58ec700e"),
                column: "ConcurrencyStamp",
                value: "9bf4ff8d-c473-4c51-b552-c9fbe021f304");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "EducationId", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3e78ca86-d0cc-4b83-bdf2-a4bea4f74c1d", 1, "DongDa@gmail.com", "DONGDA@GMAIL.COM", "DONGDA", "AQAAAAEAACcQAAAAEFV+hP7uwByIiVC2++6JEnPT9WdTJM/Soc4S/z8enhFlGNizO1+PVRFc84Y7TPUozg==", "98b2c418-f079-4174-a58d-91ede0c0e805", "DongDa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8184dab5-79d9-4011-9887-3177c2d521ea", "AQAAAAEAACcQAAAAEEq78tcbAUyZh/VEvvuyZ6fdJzoKLX8DAjI3/qCFnKaWM9JkmWDzCtz25Q1xG7ksNQ==", "a037f76e-a498-480f-8414-ba971f11c62c" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDay", "ClassId", "ConcurrencyStamp", "EducationId", "Email", "EmailConfirmed", "FullName", "Img", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "ParentFullName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("b551fd08-76d9-4040-b0fa-fb2e7aacbe7d"), 0, null, null, null, "7cbc46cc-6134-441f-bbe5-eba646fe1010", 5, "LeLoi@gmail.com", true, null, null, false, null, "LELOI@GMAIL.COM", "LELOI", null, "AQAAAAEAACcQAAAAENx2tF5ZskwSuTv/fZTaZ+hGR3YmFH9LzPd4TqAYiLmM4JxDnxqGAYnCqGBfNSHkJw==", null, true, "4f98f0c1-977c-4cc8-ae4a-c528926e8d5c", true, true, "LeLoi" },
                    { new Guid("b8ddc2e0-8b14-4c37-869e-7ca5bad4671a"), 0, null, null, null, "dfe527cb-d307-4475-8ee1-5ad547a95526", 2, "NguyenDu@gmail.com", true, null, null, false, null, "NGUYENDU@GMAIL.COM", "NGUYENDU", null, "AQAAAAEAACcQAAAAEPhA22Q+Wug4svvPa/zce/lBaxAUEGNl8VFcVJcNBoH2+dG3VdrJ8l16k7xe0NEkGQ==", null, true, "eaaf093c-bbf7-458c-9415-0140d2e896a9", true, true, "NguyenDu" },
                    { new Guid("c3a4a2eb-1703-4fc5-8511-f68acdb3a1d9"), 0, null, null, null, "5c831722-24a4-4ccc-a8c4-932954a3cb86", 3, "PhanChuTrinh@gmail.com", true, null, null, false, null, "PHANCHUTRINH@GMAIL.COM", "PHANCHUTRINH", null, "AQAAAAEAACcQAAAAEFwULWfdC1016pHCZu03isHXj2h5/JFFpWKU9d00pG2vlJquthrau8+/E7pXfD3W3w==", null, true, "63e94dac-50de-44cf-b497-b4efe9d44ae8", true, true, "PhanChuTrinh" },
                    { new Guid("e7d19c1e-a674-4d77-978a-47bbacd6910e"), 0, null, null, null, "14c6219a-395c-4ae6-89cb-1ea855e253e1", 4, "TranHungDao@gmail.com", true, null, null, false, null, "TRANHUNGDAO@GMAIL.COM", "TRANHUNGDAO", null, "AQAAAAEAACcQAAAAEM0KJPJW1phpdWNUMxw9qGO/uHeC0vgcKxhHcN17wesXoRaWWbJo6kLXTFRTbbBMuA==", null, true, "4684a342-3ab2-4166-a481-287f282d36f8", true, true, "TranHungDao" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDay", "ClassId", "ConcurrencyStamp", "EducationId", "Email", "EmailConfirmed", "FullName", "Img", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "ParentFullName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7c85649c-2d04-4846-a5f2-212ea550291b"), 0, null, new DateTime(2018, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "ff630956-52ce-4029-b613-57e407a2b150", 1, "Lamnt@gmail.com", true, "Nguyễn Thành Lâm", null, false, null, "LAMNT@GMAIL.COM", "LAMNT", "Nguyễn Văn A", "AQAAAAEAACcQAAAAEF6K7B8THeZZ1okNxOOY9pnlX4nua547WwwZ8vVFOychI4AGJLSDjMbbsxrTgLUNNA==", "0912345678", true, "68124207-5ffa-4fcd-b3b3-3d451231fa92", true, true, "Lamnt" });
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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c85649c-2d04-4846-a5f2-212ea550291b"));

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

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassId",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "ParentPhone",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "78df5252-3cf4-4e4d-969e-1c8def2c2762", "Staff", "STAFF" });

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
