using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddIngredient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitInStock = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UnitImport = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateImport = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: true),
                    EducationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.IngredientId);
                    table.ForeignKey(
                        name: "FK_Ingredient_Education_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Education",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ingredient_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "SupplierId");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "d8c91b35-ad09-417f-87bc-c7408d1f12a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "fb1c179d-7d5a-4a95-bccb-1cc4e8fc8f7b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "56cc1d7b-ba4c-4395-bd28-1cfc8ce3193b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0ee3e5a7-89ed-4bd2-8729-c66311b30033"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c005b41-0f57-4371-880f-bb993fd2047b", "AQAAAAEAACcQAAAAEAacHt/9ykUnuemzY/gyxS2ekZM6s/RLOOerrmbzM8qy7c+ocdBDDO2TQlN9Eq3BfQ==", "4a3bb830-591f-44e4-96a7-c817be9532f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "990b2695-d3b6-4f5c-bbcd-814a4ea2bd3f", "AQAAAAEAACcQAAAAEMnGCZ81h7scNFbDNA0uFGSR2p+OIJAaRZ2kC1FB2wPy9Wg4gsrmX1YacrkEtxcrQQ==", "b1327470-0601-4e77-82d2-b58660c9e764" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c85649c-2d04-4846-a5f2-212ea550291b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "655ac58f-30a0-4926-afaa-649bd02a1095", "AQAAAAEAACcQAAAAEB4gu7lx7T+Af7ZSPRRDwkrXb2idGKSZ3l0zgWE1VqvikXwz8Vn1RqnQAzbTDdpb3A==", "251bc48a-1834-4cc4-9cf5-6a47c96e46ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdd6dd34-cedd-488b-b9aa-c870050359cb", "AQAAAAEAACcQAAAAEIQ7POoS2vYntfMOqHRiDBjIJm5ic06YNiEaCcamP6vKHHC40OHkXMKkH+LP2eJbZA==", "9b661833-d499-4907-a25f-ef54babd602e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b551fd08-76d9-4040-b0fa-fb2e7aacbe7d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc74b0cc-f74b-40a0-a84d-cb53aa4a008d", "AQAAAAEAACcQAAAAEHW6taiZFjv7tUWG2miyDkBmiM8xp5s9xi5/bMTPkW+Xi+QgXA7yWEN9X6X43595rA==", "164bfdae-16a4-4ce8-9bfd-c0215407d87f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8ddc2e0-8b14-4c37-869e-7ca5bad4671a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1ff4bcf-7bc9-421e-ac02-e8d653a90a65", "AQAAAAEAACcQAAAAEMucU7SiyseTaHY7NiPXBKYx9dJUnDVqXywgdfV05Y7qWsXQ+bheLpWKLslBhfQMvg==", "76e40267-5f90-48aa-a4e9-36caddbb1f12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c3a4a2eb-1703-4fc5-8511-f68acdb3a1d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b71590d7-3c37-4baf-a185-738710dc04e6", "AQAAAAEAACcQAAAAEJiEmUHe1d04sTQT8wkWVmKY84ltSKWKNl9TYKOW1I50oVm942OSS4V7798763+R7w==", "dbf46158-c2ed-4e01-8703-fe413eee844d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7d19c1e-a674-4d77-978a-47bbacd6910e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e82796d-528c-41a7-a811-848373a942dd", "AQAAAAEAACcQAAAAECb5sPbiRgwrUZWZhT8belCVoiDKE0mDuNQap83uE6QSKfhnEfI19GkG4e2cbvt8GA==", "5e6536ca-243d-41c6-bec4-2e21634a7e7a" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 24, 1, 19, 36, 561, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 24, 1, 19, 36, 561, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 24, 1, 19, 36, 561, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 24, 1, 19, 36, 561, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 24, 1, 19, 36, 561, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 24, 1, 19, 36, 561, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 24, 1, 19, 36, 561, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 24, 1, 19, 36, 561, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 24, 1, 19, 36, 561, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "IngredientId", "DateImport", "EducationId", "IngredientName", "Price", "SupplierId", "Unit", "UnitImport", "UnitInStock" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Rau cải", 5000m, 1, "Kg", 10m, 10m },
                    { 2, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Rau bắp cải", 10000m, 1, "kg", 10m, 10m },
                    { 3, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Đậu phụ", 5000m, 1, "Miếng", 30m, 30m },
                    { 4, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Thịt lợn", 100000m, 1, "Kg", 20m, 20m },
                    { 5, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Thịt bò", 200000m, 1, "Kg", 30m, 30m },
                    { 6, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Thịt gà", 100000m, 2, "Kg", 30m, 30m },
                    { 7, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Rau cải", 5000m, 1, "Kg", 10m, 10m },
                    { 8, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Rau bắp cải", 10000m, 1, "kg", 10m, 10m },
                    { 9, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Đậu phụ", 5000m, 1, "Miếng", 30m, 30m },
                    { 10, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Thịt lợn", 100000m, 1, "Kg", 20m, 20m },
                    { 11, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Thịt bò", 200000m, 1, "Kg", 30m, 30m },
                    { 12, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Thịt gà", 100000m, 2, "Kg", 30m, 30m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_EducationId",
                table: "Ingredient",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_SupplierId",
                table: "Ingredient",
                column: "SupplierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "79f68830-7b5f-48c9-9351-8900299119d4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "f4b77b34-5c16-4849-b4ee-41f290d26bcd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "fd026356-a05a-4cc8-8cbc-a0b9f141e5d3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0ee3e5a7-89ed-4bd2-8729-c66311b30033"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "641d0e1f-ecb0-43e7-8d4e-2b822ca617c1", "AQAAAAEAACcQAAAAELx5bgNkSKkBkvLQiF9y6e4XnFY2VipV6U+d1Fs+j5Fpef4Tom0ODC68RvF0TKrHSg==", "d6a58ccf-e6bb-4080-9762-6946c7deeb78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7692990-43a4-4a26-a931-4cc8ad2683e6", "AQAAAAEAACcQAAAAEAJWxG/hK2m5fA3fG8PGB3wIZ+8mZCi7TETs9Kc+HEi2mZuQstQeKZMMqoZhwY8qbg==", "129dcad5-1cf5-4dc1-aff7-d53d24e6a376" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c85649c-2d04-4846-a5f2-212ea550291b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e449a5f2-ae38-400b-8485-b182722c9280", "AQAAAAEAACcQAAAAEIIIsprrtaiIyeUhoRbTPPSd8HqIBp6NCiFt+R0OOLXsWIoMLJlcBMw7TU1x/k2yyw==", "9c0c8206-b35a-4b0d-b9fe-9698744d23d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b38b5946-376d-4c14-96c4-73022812caf1", "AQAAAAEAACcQAAAAELnqXKMfZQJaRPD/aCf5eZBBuNRMctcrXB3YI+oveQMdDobgTt1UjVzk2qtx6bdSOw==", "56bacacf-6fa8-4071-9d97-a005d33c4596" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b551fd08-76d9-4040-b0fa-fb2e7aacbe7d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfc4c82d-9333-4234-be79-0f5abcf325b9", "AQAAAAEAACcQAAAAEDwZOjbc+0Qy1upYzkKo2Av8t2OR8KTeH7gFaTcEXPEATkRar0JGK1oE+CQDg2pcCA==", "4d57fbde-6781-4522-a7fd-50c18d6847e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8ddc2e0-8b14-4c37-869e-7ca5bad4671a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b90a6f5a-67fc-44fe-b65a-5fa32f1c5cfd", "AQAAAAEAACcQAAAAENcHg0Qtt++eV0WIDzpk/eW//qEX8HUV9b3eRV7hshzbf3U48skVjZF3PQ2cY/g1Uw==", "2185c036-e58a-4422-914f-456ee4183fa3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c3a4a2eb-1703-4fc5-8511-f68acdb3a1d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22511a03-232b-44df-90d4-12f2cf7b909c", "AQAAAAEAACcQAAAAEEho/uzm71NtFlG5uV3psEZQItf/ftdtCZVbqG7xUPfSD0hpKKBMFcdY6yynnRIiog==", "c44d7000-ed68-4a55-af7d-8f369137ff70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7d19c1e-a674-4d77-978a-47bbacd6910e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57e0dab2-cedb-4b84-9411-f6ccb80967a3", "AQAAAAEAACcQAAAAENMIhnk6m03Q/SmbUen1Jgwjn4wJIcP5/NU9Qbk2fGoco7E4dfAwJzIKuNn9nWff/w==", "f3e38f60-b073-48db-b8d3-64266c1b6a47" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 23, 17, 1, 37, 346, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 23, 17, 1, 37, 346, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 23, 17, 1, 37, 346, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 23, 17, 1, 37, 346, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 23, 17, 1, 37, 346, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 23, 17, 1, 37, 346, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 23, 17, 1, 37, 346, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 23, 17, 1, 37, 346, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 23, 17, 1, 37, 346, DateTimeKind.Local).AddTicks(2404));
        }
    }
}
