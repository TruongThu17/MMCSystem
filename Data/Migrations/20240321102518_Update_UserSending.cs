using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Update_UserSending : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "c2beb321-c5c9-4c1c-ac0d-aafe86548afc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "1f524155-ad29-49ab-af5d-18b86d4b9d9b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "f2c2e3d0-ebe5-42e3-b0d4-7936765b56db");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"), new Guid("7c85649c-2d04-4846-a5f2-212ea550291b") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9855f609-501a-4bff-a37c-a9062b30676b", "AQAAAAEAACcQAAAAEBLSBc/x5HRqGsiGGJucTmCK5N9Bb7lLR58oZbNyImprlPJiyth+LJ+SHqYSov7WfA==", "96274f77-f7ed-49be-a7e1-5415bab9e8b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c85649c-2d04-4846-a5f2-212ea550291b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StudentCode", "UserName" },
                values: new object[] { "52f189df-4107-49ae-b255-1df666a518dd", "AQAAAAEAACcQAAAAEDj6BFfCEnrvjc4e7T5CWxfYs9JwcczHa8A7wGb43oVxjDNf1aZh3C9lSBvNow6f5g==", "6cb41d2a-516c-474b-95d0-3a2cd4d433dc", "DongDa10001", "LamntDongDa10001" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7c64bef-fd41-4766-a33d-ea3841c10acc", "AQAAAAEAACcQAAAAECNJpXAfq/6kA3djsIDdsIXad2SpL2qMmz93y2dJ1FU5qpumMmrPkq8nbCcH7G9Nfg==", "3fa4a98f-b070-4f08-8080-fb395fee1ab4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b551fd08-76d9-4040-b0fa-fb2e7aacbe7d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9284ac17-d057-445d-9f85-fd588a0e2b73", "AQAAAAEAACcQAAAAEIOuRdzyLkUpCSS/B4AVS9WeCL5enG5b1COJas0jgCg8bdCzKibwNvZ8PBrzCXtIzg==", "8a90c30f-9eee-44a7-b24d-aec6f4d6a2d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8ddc2e0-8b14-4c37-869e-7ca5bad4671a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a32eaa5-60cf-4961-9c3f-c6d8ade26943", "AQAAAAEAACcQAAAAEFLBT/YjuFhc021AXPG+AqblzygCQq8TfxKiRBZ6ojVOrDese/xwnOtVXsz13ljCCA==", "61de6a2b-5f5d-4237-ab63-3646af1e1856" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c3a4a2eb-1703-4fc5-8511-f68acdb3a1d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64a50424-c630-4174-885f-7264eb4b2b9f", "AQAAAAEAACcQAAAAEC578aTnMWqgp3NNRrMkYdbiutqQ6hta4kAnKUrHgcmqfHKtjKMWtkzH/W4ZcfkdOw==", "47ba437f-fd3d-4e53-8233-4885d0abe55a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7d19c1e-a674-4d77-978a-47bbacd6910e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a453d94e-fc22-4ad7-aff0-b8e3c3ce46b6", "AQAAAAEAACcQAAAAEL+Ac5Mz/sGPw0FXnbSoC6VpjnUVTLn0CeNu7vjJHxyznAGPiC/BcqLWlTNRsTn4oQ==", "cd137890-0bf6-445a-bce0-c0e429aa7c7d" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDay", "ClassId", "ConcurrencyStamp", "EducationId", "Email", "EmailConfirmed", "FullName", "Img", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "ParentFullName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "StudentCode", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("0ee3e5a7-89ed-4bd2-8729-c66311b30033"), 0, null, new DateTime(2018, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "3bb5b3f1-6a9e-42fe-8b6d-3469396c9485", 1, "Ductv@gmail.com", true, "Trần Văn Đức", null, false, null, "DUCTV@GMAIL.COM", "DUCTV", "Nguyễn Văn A", "AQAAAAEAACcQAAAAEM88W9aTZiZsg8ZKm72bDl7qwxgFTMVT35vj6Se0LRO6KfgrIY8Yle+t2Yl0bf3kpQ==", "0912345679", true, "52eb4237-976e-4bf5-9786-804c87a0535c", true, "DongDa10002", true, "DuctvDongDa10002" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 25, 17, 309, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 25, 17, 309, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 25, 17, 309, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 25, 17, 309, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 25, 17, 309, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 25, 17, 309, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 25, 17, 309, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 25, 17, 309, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 21, 17, 25, 17, 309, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"), new Guid("0ee3e5a7-89ed-4bd2-8729-c66311b30033") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"), new Guid("0ee3e5a7-89ed-4bd2-8729-c66311b30033") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"), new Guid("7c85649c-2d04-4846-a5f2-212ea550291b") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0ee3e5a7-89ed-4bd2-8729-c66311b30033"));

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StudentCode", "UserName" },
                values: new object[] { "4eccef76-b2cd-4098-ae8a-a75dcd2569f6", "AQAAAAEAACcQAAAAEKgIsTLPJ+ZdXpkep9ZRLwGoGoVr5fNwEs696JSLN+E3cAsfK9NGYyCQUhiTaA7cJA==", "0d05a40d-324e-4485-a29b-2eb7db31b8b2", "LamntDongDa10001", "Lamnt" });

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
    }
}
