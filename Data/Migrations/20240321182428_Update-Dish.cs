using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class UpdateDish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "MealType",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "Dish",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "4e0bef16-a068-450b-a638-db7ce22082b1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "a9e36a2e-8c00-4115-9278-37f6e4a21add");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "23d157fd-3df7-4702-873d-58e35ce812ab");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0ee3e5a7-89ed-4bd2-8729-c66311b30033"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e95bf500-b0d0-46fb-94e8-00778015d88b", "AQAAAAEAACcQAAAAEPDlnfwIlsbvySBSpxCT3oUJ3nu5+6Li1op3+re1UGenRFUhf92ZW0cc26DLzPNPTA==", "39a56082-084a-4574-a757-27497c58a037" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03de8476-0540-4796-b9c4-b0374a567f68", "AQAAAAEAACcQAAAAEOWcyEBdR0DbFIEHk4VMm/+kJXtJrFgaEVjLsWsMiy5/jdzABdc3AbXIq3lBv2kcXQ==", "de90c26d-6b63-4d6c-9754-967728a64532" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c85649c-2d04-4846-a5f2-212ea550291b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff8a6d18-1768-4e3a-bbf2-6a4c17aba5d9", "AQAAAAEAACcQAAAAEHciQsAgvsUH0yD1QFY+zqsIAN+gBdd/1vRit2jWSv/KRckgZBtnkV7QSM9VfqYDFQ==", "27e17922-d2d8-4e1f-ab8e-bdc532faceaa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5488908b-13b2-40f6-89ae-fc5fa918453a", "AQAAAAEAACcQAAAAEC+zTi1mAlDvks0P7eqtpwWG5lWD89pXDQOj2gWzWnco2Dk1oIamraPnC4Q9RdpUfA==", "c0c1a8a3-8ff7-4cae-a9f2-44eaf8860c8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b551fd08-76d9-4040-b0fa-fb2e7aacbe7d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f7820ff-27a0-46e3-8100-2b28e5a8944d", "AQAAAAEAACcQAAAAEG8ayzycewQy4xgZDB3R8to6gna2yLioA/BNtZCRZiqlOJNnVp2WYug+dwckGLf2bg==", "c10c96c1-545c-41e7-b11a-2082b6882ba2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8ddc2e0-8b14-4c37-869e-7ca5bad4671a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f664ced-42e6-4a5d-9270-fd168ec5c414", "AQAAAAEAACcQAAAAEENJ3BG4vq3bMpIGlHlYLaTRYPcS5O4yA8qEWlU9QVWI1xAZd/MW2XVL2Zt6DYAecw==", "56f9e797-8077-49f1-8c9b-70bacf40a0a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c3a4a2eb-1703-4fc5-8511-f68acdb3a1d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e81a6619-b8d0-4cdd-834f-984f6666f374", "AQAAAAEAACcQAAAAEAjlUuQSA/HOpOB8Lg8ZEWO2FRY5TaLwUeOt1NwxKlDh4sKGtAtxvIcco0wQa4qtXw==", "4e019189-2d95-4f79-813c-a5f7a4a69d55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7d19c1e-a674-4d77-978a-47bbacd6910e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17e6fd2a-83d6-466b-821d-77b21a9dd2d6", "AQAAAAEAACcQAAAAEC0izS9qb4OBq4ZiCWuAAtSD45p6y7elbjRWBUc+ltQZUkYBos0zXqt0MYocDUDKnQ==", "caf07b3b-4f17-49f4-904c-dc8d480db169" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 22, 1, 24, 27, 23, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 22, 1, 24, 27, 23, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 22, 1, 24, 27, 23, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 22, 1, 24, 27, 23, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 22, 1, 24, 27, 23, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 22, 1, 24, 27, 23, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 22, 1, 24, 27, 23, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 22, 1, 24, 27, 23, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 22, 1, 24, 27, 23, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 1,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 2,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 3,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 4,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 5,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 6,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 7,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 8,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 9,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 10,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 11,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 12,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 13,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 14,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 15,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 16,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 17,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 18,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 19,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 20,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 21,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 22,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 23,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 24,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 25,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 26,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 27,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 28,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 29,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 30,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 31,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 32,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 33,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 34,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 35,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 36,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 37,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 38,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 39,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MealType",
                keyColumn: "Id",
                keyValue: 1,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MealType",
                keyColumn: "Id",
                keyValue: 2,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MealType",
                keyColumn: "Id",
                keyValue: 3,
                column: "EducationId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_MealType_EducationId",
                table: "MealType",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Dish_EducationId",
                table: "Dish",
                column: "EducationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dish_Education_EducationId",
                table: "Dish",
                column: "EducationId",
                principalTable: "Education",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MealType_Education_EducationId",
                table: "MealType",
                column: "EducationId",
                principalTable: "Education",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dish_Education_EducationId",
                table: "Dish");

            migrationBuilder.DropForeignKey(
                name: "FK_MealType_Education_EducationId",
                table: "MealType");

            migrationBuilder.DropIndex(
                name: "IX_MealType_EducationId",
                table: "MealType");

            migrationBuilder.DropIndex(
                name: "IX_Dish_EducationId",
                table: "Dish");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "MealType");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "Dish");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "c750bde7-1512-4fbb-9968-6bc429a26ac2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "02ac8c08-d20f-4126-b7a3-e54bc469074c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "6b0535f7-5d94-40ad-b357-dfaf874929d5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0ee3e5a7-89ed-4bd2-8729-c66311b30033"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a94c5ef7-01e9-4cee-9471-5bd11d83c287", "AQAAAAEAACcQAAAAEO/iE/YF2dqAbvNmraESs4LzVkRXNzCmn85slMAQoXHh8zUBNscEcN2S/wMrFTwsYg==", "4ce0b9cd-bdde-4d68-90b0-bdb85f16c8bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12f8f7fe-6f2a-4b33-b512-befabb1fddd9", "AQAAAAEAACcQAAAAEHNCrUQHF9ea0860Pi1o7GNDHBLviIqfPPnqGVPLPMmtnP6FnEfwvlIZ2NT8v1IuZQ==", "b1569bc9-a182-482a-9c4a-58c0cce5b8cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c85649c-2d04-4846-a5f2-212ea550291b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef8d3890-d7f1-411b-a48e-eef24db937a1", "AQAAAAEAACcQAAAAEHbJ1ZaCPvYbG6PD+YJ3ByU137maR6g3+G+ZupHnjx+doioLWGIqQ8xwWBSpH2X3zQ==", "06e21dad-41df-4f6b-8bd3-e78f60d8bca2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17d8c1b1-ee72-45c4-8fa2-dd885e49a366", "AQAAAAEAACcQAAAAEM1hMcDT4hjHEi7XsI1U6OHy0z41BcFwbSRhFUi3pIXeez8meGUmcczacHvuvXttmg==", "c2360028-d6c8-4fb4-a3bf-b71e6d138cec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b551fd08-76d9-4040-b0fa-fb2e7aacbe7d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fd0aa7e-650c-4dc9-aa87-28c516fa577f", "AQAAAAEAACcQAAAAEOWSZd3M9TJPhy6NW1FvU1prvyWIIrvlk5G0WHeKj8NEB8LihaSHe9KfTAifNosu9w==", "8fbcad5c-765d-40c4-b039-073e2ee24045" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8ddc2e0-8b14-4c37-869e-7ca5bad4671a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c25d11b-1bdf-43ae-9fca-b948475ec2dc", "AQAAAAEAACcQAAAAEM7NcB/SWQZG3vvqS3Riku6/Z2luKu7srvUZCrZw3e+/JLvXbfxQv427YWNpt3v1qA==", "732db71a-0d47-4291-9936-96a33f6154e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c3a4a2eb-1703-4fc5-8511-f68acdb3a1d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c5716c0-a259-42ed-9082-d1db20c31576", "AQAAAAEAACcQAAAAENmnPnrYANO3kpPNsfYq/lWo9pgdA+1fAO+FkocGh+Mmux8WglGEzMh4jyL8efSR/A==", "621967ef-84cf-4d8b-af47-f9367810a351" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7d19c1e-a674-4d77-978a-47bbacd6910e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d208e42e-dca1-4e9f-827c-ec3945b7675a", "AQAAAAEAACcQAAAAEP8RXoP3r4rbeHjIEDdQjWA8I1rk95FyKUQrOURFIR2aU7WzCyQtxxc4tgi+1HghXg==", "bcca436d-65ba-4876-82da-59a90432f5b8" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 22, 0, 19, 17, 514, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 22, 0, 19, 17, 514, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 22, 0, 19, 17, 514, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 22, 0, 19, 17, 514, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 22, 0, 19, 17, 514, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 22, 0, 19, 17, 514, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 22, 0, 19, 17, 514, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 22, 0, 19, 17, 514, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 22, 0, 19, 17, 514, DateTimeKind.Local).AddTicks(1592));
        }
    }
}
