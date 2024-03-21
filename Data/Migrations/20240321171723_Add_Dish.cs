using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Add_Dish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dish",
                columns: table => new
                {
                    DishId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nutrition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MealTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dish", x => x.DishId);
                    table.ForeignKey(
                        name: "FK_Dish_MealType_MealTypeId",
                        column: x => x.MealTypeId,
                        principalTable: "MealType",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "90248e25-a882-407c-9ac6-1841953903ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "e7a70a0e-a60b-4597-bfe4-b908518fa1a3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "2b9b6750-4cea-44df-a2a3-447537e63475");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0ee3e5a7-89ed-4bd2-8729-c66311b30033"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a50ec10f-97f2-4de5-b931-9844b46f5acc", "AQAAAAEAACcQAAAAEL2+rEgwVp1U5ElgDMS9StSwQyQq5m3QQ95ENwBkAD/+Ey5+Rlx8VXpcBxRAS6SAYA==", "aafa6919-823e-4a3d-be38-5ebc1bf97e57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5d360ea-76fe-43f9-af6c-f9307669561a", "AQAAAAEAACcQAAAAEEy1MXvd8/yOUrAVWHMHTVe0ze1cwRmZpl7sTxLg+6itn6wx6VBuW3+//qmDRKz0TQ==", "4bf3b702-dba1-4c8f-bc20-1165f1fa012b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c85649c-2d04-4846-a5f2-212ea550291b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f32923a9-7d03-47f3-a169-3451e97e64dd", "AQAAAAEAACcQAAAAEK8j676n9BHa8agboiG2L9Ex0MPfc9jjVG2p9M96+jWetWLX1L3LRDlgn/nwjfTJ/g==", "48f7515c-d4a6-4706-aee3-9492dbf0c999" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dade131d-39ef-4e1d-a714-e06e52e04a93", "AQAAAAEAACcQAAAAEFdEZlq798a3Xa0MyeiCT09kKTMs+xF1r61aQtRT/wtr0xf0LdPaGyyESvP/H/tzcg==", "f9695002-b1a3-4dd3-84c6-43d3520f7819" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b551fd08-76d9-4040-b0fa-fb2e7aacbe7d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af49aecb-22b1-44b4-a348-59abd7a7b5b2", "AQAAAAEAACcQAAAAEHcdqbapECkVxElFKOSOo+z7DvO+XDMHFldITRhhMBoRTXD6er7JUJfvE17wvr0AVQ==", "81c670b6-6834-4b67-accc-3451b8c6d8dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8ddc2e0-8b14-4c37-869e-7ca5bad4671a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd5ca47a-81a9-4ded-b147-7335f205bae3", "AQAAAAEAACcQAAAAELffRznvDLgKhYtyDon+yo4Lw8zmn+bHy/nqTWArJ47CW74QIyJpp+Ll1osyN3pZGg==", "da8176ee-e806-4c63-9f41-bf46a557f2bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c3a4a2eb-1703-4fc5-8511-f68acdb3a1d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2e084b3-e667-422d-ab19-bcce6f00e9aa", "AQAAAAEAACcQAAAAEECz0rQG+AeDvMt8nQOSrbZgKq2oGBwUtGKsdpb4bzN0wgcq63iLut3mNbhm85SxlA==", "82daae6c-4e9e-477c-a79a-8e47d719faba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7d19c1e-a674-4d77-978a-47bbacd6910e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8392909-4128-4110-a2e3-9bf5fcee2992", "AQAAAAEAACcQAAAAELWKXGab/bbNnejIhJBJZH4xQXPSaywYSRgSxXBTzAKkwZ6ARNSqlukmPB424NXGrg==", "ecc789fd-bc0f-4553-a1d9-391602d0ac49" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 22, 0, 17, 22, 442, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 22, 0, 17, 22, 442, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 22, 0, 17, 22, 442, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 22, 0, 17, 22, 442, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 22, 0, 17, 22, 442, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 22, 0, 17, 22, 442, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 22, 0, 17, 22, 442, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 22, 0, 17, 22, 442, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 22, 0, 17, 22, 442, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "MealType",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Bữa trưa, tối");

            migrationBuilder.UpdateData(
                table: "MealType",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Tráng miệng");

            migrationBuilder.CreateIndex(
                name: "IX_Dish_MealTypeId",
                table: "Dish",
                column: "MealTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dish");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0ee3e5a7-89ed-4bd2-8729-c66311b30033"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bb5b3f1-6a9e-42fe-8b6d-3469396c9485", "AQAAAAEAACcQAAAAEM88W9aTZiZsg8ZKm72bDl7qwxgFTMVT35vj6Se0LRO6KfgrIY8Yle+t2Yl0bf3kpQ==", "52eb4237-976e-4bf5-9786-804c87a0535c" });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52f189df-4107-49ae-b255-1df666a518dd", "AQAAAAEAACcQAAAAEDj6BFfCEnrvjc4e7T5CWxfYs9JwcczHa8A7wGb43oVxjDNf1aZh3C9lSBvNow6f5g==", "6cb41d2a-516c-474b-95d0-3a2cd4d433dc" });

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

            migrationBuilder.UpdateData(
                table: "MealType",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Bữa trưa");

            migrationBuilder.UpdateData(
                table: "MealType",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Bữa chiều");
        }
    }
}
