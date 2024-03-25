using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class updateseederl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "9ca85219-8181-4282-b667-4eca7586bd11");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "e3cfa36b-c712-4331-b08d-df1ffac7ef4c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "f1dfa591-3110-4c63-b5e7-55df1bf53c8c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0ee3e5a7-89ed-4bd2-8729-c66311b30033"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StudentCode" },
                values: new object[] { "55fa0f48-b90b-49a5-b874-4c5fda49a41d", "AQAAAAEAACcQAAAAEGnxUO5CxKioBgToKEUFfeEZrBs15VuacjqyvnrAlj50Nq1YPbLh/XdDjdYxhVd5uQ==", "68f82b2b-33a1-4a50-aa0d-d1ad304b7673", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d22fa4dc-2245-48b6-97ef-a8c5ef36b5c7", "AQAAAAEAACcQAAAAELwIfXw+i5sytVHN61Nq8p82LW69V1sQIuoPwqsHPdOD2NqtDc7vIhxXvB6Jb755Iw==", "c06fb495-7eeb-43c7-b39f-37c3a3ca16ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c85649c-2d04-4846-a5f2-212ea550291b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StudentCode" },
                values: new object[] { "91d8b21a-6761-4895-8b53-70dc858f3469", "AQAAAAEAACcQAAAAEDZbGWz065wgM14Fcyxn6yblLr3jn6vz2a7NP0jC55YNe4t/cmgS67/7CGYUR62pEA==", "69e8fd8a-94f7-4fea-92eb-46257d261f3b", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e6a3d7d-ed52-4a4a-91f8-836be904b041", "AQAAAAEAACcQAAAAEBsAzfGD7TpAVcplhSzI8ugtsi1hWymMLdW12CslTA4ozt6CumwK9BMx+xpvQRvRZg==", "99a72555-b048-4835-81de-492bbe7c7db6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b551fd08-76d9-4040-b0fa-fb2e7aacbe7d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6356558-bae9-4104-8e54-9fab0228c1e4", "AQAAAAEAACcQAAAAEONqC8+Hmf2N+8jMUq7gLUJg+VDlae3m8Odv2Gty8kC24D0yJHoSd/bj7TUtiq/nCA==", "beffe991-0468-4041-9956-01b7aaded2ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8ddc2e0-8b14-4c37-869e-7ca5bad4671a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22e2b51b-7907-4736-9d71-fd57dc3d88c3", "AQAAAAEAACcQAAAAEErWa9UnMLcyrrB8r8wKmbilW87oEwnzXKkprQncZT/wxIzdK/pWHpPr9s5cB7iWEA==", "3e3e4833-555f-4903-94bd-29f0166832b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c3a4a2eb-1703-4fc5-8511-f68acdb3a1d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b9f1dfa-a828-4b7c-9d48-54fa8b15cb99", "AQAAAAEAACcQAAAAEAKd1atDKXsYyKrlLUPqw6wyUjtKuF95QkD7mP2wrCq6U00xlzo16RLZePKx6voXtw==", "162f45c9-3a52-4987-a2ee-30e6ac83fdcb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7d19c1e-a674-4d77-978a-47bbacd6910e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18036779-5c73-4b8f-aa5f-01f949bd459d", "AQAAAAEAACcQAAAAEAoA1S5xaly/eXbegovp/iqxQfZjNxHAXqBWaqMPmzt61RCz/+rFglX0lnP/A2je7g==", "62aecce0-a6e2-41ee-8c89-3ec18f19d456" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDay", "ClassId", "ConcurrencyStamp", "EducationId", "Email", "EmailConfirmed", "FullName", "Img", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "ParentFullName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "StudentCode", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1b2b8425-274b-4444-93c6-44536e2aaf2d"), 0, null, new DateTime(2018, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "5472c530-cffc-475c-b09c-ecff90cc5321", 1, "MaiVu@gmail.com", true, "Vũ Thị Mai", null, false, null, "MaiVu@GMAIL.COM", "MaiVu", "Nguyễn Văn A", "AQAAAAEAACcQAAAAELnavnO9ofZtkQ4j6zjmOpvJneSBNp+u+anMGlwBtAqr7tyuJG/PxYpx37EHli1grQ==", "0912345679", true, "8a98ade5-c301-4d2c-8ddc-b56bf9192cb2", true, null, true, "MaiVu" },
                    { new Guid("1e7f04a2-e884-469d-ba8d-421d45ee1b79"), 0, null, new DateTime(2018, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "b0a7d259-c75c-4509-8d75-fa343a7bd425", 1, "QuynhVu@gmail.com", true, "Vũ Thị Quỳnh", null, false, null, "QuynhVu@GMAIL.COM", "QuynhVu", "Nguyễn Văn A", "AQAAAAEAACcQAAAAEIE2BGSxtILlEEB/veY1q/RG++pEFmApIuXeAb7P8Er1Nbf1yk8TKzlklDJhf7wfNw==", "0912345679", true, "cbcad1dd-fc78-44a9-8948-55b448665109", true, null, true, "QuynhVu" },
                    { new Guid("59b4cc83-a2e2-4153-ba43-1d399cfc6b0a"), 0, null, new DateTime(2018, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "1783acd1-fc24-498a-94e2-d64acc797ace", 1, "HuynhVu@gmail.com", true, "Vũ Văn Huynh", null, false, null, "HuynhVu@GMAIL.COM", "HuynhVu", "Nguyễn Văn A", "AQAAAAEAACcQAAAAEEySHqryt0GDI8GhE1R248hSsrtC150r5bTWK7C1UQD5iiimU4Mmc1tlKDWdq/UZkg==", "0912345679", true, "b686a652-319d-4e7e-9c72-d5f0ce4c8c3f", true, null, true, "HuynhVu" },
                    { new Guid("895de26a-d181-423e-9ce0-8efddfa5562a"), 0, null, new DateTime(2018, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "f91f51af-aa00-482e-b54e-cebc3b267e49", 1, "PhiNguyen@gmail.com", true, "Nguyễn Quốc Phi", null, false, null, "PhiNguyen@GMAIL.COM", "PhiNguyen", "Nguyễn Văn A", "AQAAAAEAACcQAAAAEPDfuOdGygil3q1dSeQfHOyTdFmWwA3PAcYlv8uPgWw8IkSsz1mclAb4Bs0Jz1DBqw==", "0912345679", true, "17571926-7d84-4a3a-9bc7-c63d496dd2e3", true, null, true, "PhiNguyen" }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 25, 6, 25, 17, 943, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 25, 6, 25, 17, 943, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 25, 6, 25, 17, 943, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 25, 6, 25, 17, 943, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 25, 6, 25, 17, 943, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 25, 6, 25, 17, 943, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 25, 6, 25, 17, 943, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 25, 6, 25, 17, 943, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 25, 6, 25, 17, 943, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"), new Guid("1b2b8425-274b-4444-93c6-44536e2aaf2d") },
                    { new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"), new Guid("1e7f04a2-e884-469d-ba8d-421d45ee1b79") },
                    { new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"), new Guid("59b4cc83-a2e2-4153-ba43-1d399cfc6b0a") },
                    { new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"), new Guid("895de26a-d181-423e-9ce0-8efddfa5562a") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"), new Guid("1b2b8425-274b-4444-93c6-44536e2aaf2d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"), new Guid("1e7f04a2-e884-469d-ba8d-421d45ee1b79") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"), new Guid("59b4cc83-a2e2-4153-ba43-1d399cfc6b0a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"), new Guid("895de26a-d181-423e-9ce0-8efddfa5562a") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1b2b8425-274b-4444-93c6-44536e2aaf2d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e7f04a2-e884-469d-ba8d-421d45ee1b79"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59b4cc83-a2e2-4153-ba43-1d399cfc6b0a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("895de26a-d181-423e-9ce0-8efddfa5562a"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "adbd9eaa-41d3-4780-922a-b7105dedbdf4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "7877a67c-4450-47a6-921a-29bbb10e6121");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "7faeaa76-64a0-4ca6-b4f3-5d4622174679");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0ee3e5a7-89ed-4bd2-8729-c66311b30033"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StudentCode" },
                values: new object[] { "f5ff58cf-f36f-4e2d-b551-075e4c06d818", "AQAAAAEAACcQAAAAEOnsytRcNTuwTO77jOnqyiWmvYUe1J50phmO9ecN9NJQI18Q2IaYRJ8s47e6dXgRRw==", "ef67d520-584c-40bf-9a26-8d0afe9d59e0", "DongDa10002" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bc33f98-d863-485d-ab47-c112ca2840ff", "AQAAAAEAACcQAAAAEFzpBnGIpKgnY/lv8qdfHTR4sQ0s9GZRD+N3H0FamTqwpzHL+Pt7nbQYLiwvK5hTDw==", "ce409c4a-8294-4b55-9afe-e49de2c011ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c85649c-2d04-4846-a5f2-212ea550291b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StudentCode" },
                values: new object[] { "16b53ae9-58b6-42df-9726-7b03a5e27915", "AQAAAAEAACcQAAAAEOedJPWD9568zqOMDLeszetPBScmd8q+fzEAeFCvQ4mhFPesXX9UtrPz8Fta7C7Yvg==", "c625c28b-de5a-4ee3-8c26-fe7f4998bafd", "DongDa10001" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "272e84f8-d2a5-496a-9f55-e588c89b71a4", "AQAAAAEAACcQAAAAEMmw13La8Pz8KPAlxEt5zBOd9DFnKb8PzXb/Q7/kpN9rqkDXKyCqr5cX0kTzYUNM2Q==", "7ce1e679-a3c0-46de-97ab-9bca2e043670" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b551fd08-76d9-4040-b0fa-fb2e7aacbe7d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10cb4758-54c4-4d95-8005-b4c2b1e4310b", "AQAAAAEAACcQAAAAEGUbV6LdiZF+NNRw+8vQcvvL2KefrFVB9MmlnvRsDbgLf+dUTQNvz1L7avOjxeDQbQ==", "a1e4d8a3-f623-4409-ac87-cf0e65161f6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8ddc2e0-8b14-4c37-869e-7ca5bad4671a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "303ea5b5-2bb8-43e5-a1e2-3ed7ad1c3a73", "AQAAAAEAACcQAAAAENd1cTh0AKbAB3uXyzXkRuh0+j2WY0yoUdN4a+8p6peahH6ZMZQc86908Drv08brEQ==", "9fc16d94-e38b-4171-b2a5-e338edfe47b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c3a4a2eb-1703-4fc5-8511-f68acdb3a1d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8a26849-b327-4011-935e-2c0e7837c835", "AQAAAAEAACcQAAAAEABlyQmnMutgUTjRGY9007OhvzTPneUSTlk6PYK7pDj8TXzKs4TY8qIB4Bis+Jg2AA==", "a013f279-2e7a-489b-9ea7-233ffa074a0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7d19c1e-a674-4d77-978a-47bbacd6910e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df64dfa3-c72d-4ebd-9391-8005400aba33", "AQAAAAEAACcQAAAAEHOkH1ICmaB1sKcBl1R1fTI0XRSOFTlc0RSYyYslCe7uwaHJAdPxWSEpjXuWplF+tA==", "0ee96c37-41bc-404e-bb07-9f74e0b59c95" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 25, 5, 4, 53, 634, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 25, 5, 4, 53, 634, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 25, 5, 4, 53, 634, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 25, 5, 4, 53, 634, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 25, 5, 4, 53, 634, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 25, 5, 4, 53, 634, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 25, 5, 4, 53, 634, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 25, 5, 4, 53, 634, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 25, 5, 4, 53, 634, DateTimeKind.Local).AddTicks(8911));
        }
    }
}
