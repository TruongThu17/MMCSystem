using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Add_DishSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Dish",
                columns: new[] { "DishId", "Description", "DishName", "MealTypeId", "Nutrition" },
                values: new object[,]
                {
                    { 1, "Bánh mì với xúc xích và sốt cà chua", "Bánh mì xúc xích", 1, "Calo: 300, Protein: 12g, Chất béo: 8g, Carbohydrate: 35g" },
                    { 2, "Cháo gà với gà và gạo nấu mềm", "Cháo gà", 1, "Calo: 200, Protein: 10g, Chất béo: 5g, Carbohydrate: 25g" },
                    { 3, "Bánh bao nhân thịt xay và trứng cút", "Bánh bao 2 trứng", 1, "Calo: 250, Protein: 8g, Chất béo: 6g, Carbohydrate: 30g" },
                    { 4, "Bánh bao nhân phô mai mềm mịn", "Bánh bao phô mai", 1, "Calo: 280, Protein: 7g, Chất béo: 12g, Carbohydrate: 35g" },
                    { 5, "Bánh bao nhân xá xíu thơm ngon", "Bánh bao xá xíu", 1, "Calo: 300, Protein: 10g, Chất béo: 15g, Carbohydrate: 25g" },
                    { 6, "Cháo gạo nấu mềm với thịt băm nhỏ", "Cháo thịt băm", 1, "Calo: 220, Protein: 12g, Chất béo: 8g, Carbohydrate: 30g" },
                    { 7, "Cháo gạo nấu mềm, giàu chất dinh dưỡng", "Cháo dinh dưỡng", 1, "Calo: 180, Protein: 6g, Chất béo: 5g, Carbohydrate: 25g" },
                    { 8, "Bánh mì pate, trứng, xúc xích", "Bánh mì pate", 1, "Calo: 300, Protein: 12g, Chất béo: 8g, Carbohydrate: 35g" },
                    { 9, "Thịt băm xào với rau cải tươi ngon", "Thịt Băm Xào Rau Cải", 2, "Calo: 300, Protein: 20g, Chất béo: 15g, Carbohydrate: 25g" },
                    { 10, "Thịt xắt lát kèm sốt cà chua", "Thịt Xốt Cà Chua", 2, "Calo: 350, Protein: 25g, Chất béo: 18g, Carbohydrate: 20g" },
                    { 11, "Thịt heo rang cháy cạnh", "Thịt Rang", 2, "Calo: 400, Protein: 30g, Chất béo: 25g, Carbohydrate: 10g" },
                    { 12, "Gà chiên giòn với muối và tiêu", "Gà Rang Muối", 2, "Calo: 380, Protein: 28g, Chất béo: 20g, Carbohydrate: 15g" },
                    { 13, "Cá kho tộ kho với sốt nước mắm", "Cá Kho Tộ", 2, "Calo: 350, Protein: 25g, Chất béo: 15g, Carbohydrate: 20g" },
                    { 14, "Thịt kho dừa nấu chín mềm", "Thịt Kho Dừa", 2, "Calo: 300, Protein: 20g, Chất béo: 15g, Carbohydrate: 25g" },
                    { 15, "Thịt kho với trứng cút nấu chín", "Thịt Kho Trứng", 2, "Calo: 280, Protein: 18g, Chất béo: 12g, Carbohydrate: 20g" },
                    { 16, "Trứng gà chiên giòn", "Trứng Chiên", 2, "Calo: 180, Protein: 10g, Chất béo: 12g, Carbohydrate: 5g" },
                    { 17, "Trứng gà luộc vừa chín", "Trứng Luộc", 2, "Calo: 70, Protein: 6g, Chất béo: 5g, Carbohydrate: 1g" },
                    { 18, "Xúc xích chiên giòn", "Xúc Xích Chiên", 2, "Calo: 250, Protein: 8g, Chất béo: 20g, Carbohydrate: 10g" },
                    { 19, "Thịt băm xào với rau củ tươi ngon", "Thịt Băm Xào Rau Củ", 2, "Calo: 250, Protein: 15g, Chất béo: 10g, Carbohydrate: 20g" },
                    { 20, "Cá chiên xù giòn rụm", "Cá Chiên Xù", 2, "Calo: 200, Protein: 15g, Chất béo: 12g, Carbohydrate: 5g" },
                    { 21, "Cá hấp nhẹ nhàng với gia vị tự nhiên", "Cá Hấp", 2, "Calo: 150, Protein: 20g, Chất béo: 5g, Carbohydrate: 2g" },
                    { 22, "Thịt bò xào với rau cải tươi ngon", "Thịt Bò Xào Rau Cải", 2, "Calo: 280, Protein: 25g, Chất béo: 15g, Carbohydrate: 10g" }
                });

            migrationBuilder.InsertData(
                table: "Dish",
                columns: new[] { "DishId", "Description", "DishName", "MealTypeId", "Nutrition" },
                values: new object[,]
                {
                    { 23, "Thịt bò xào với rau rút tươi ngon", "Thịt Bò Xào Rau Rút", 2, "Calo: 270, Protein: 23g, Chất béo: 14g, Carbohydrate: 12g" },
                    { 24, "Gà chiên giòn ngoài, mềm trong", "Gà Chiên Giòn", 2, "Calo: 280, Protein: 20g, Chất béo: 18g, Carbohydrate: 10g" },
                    { 25, "Thịt gà xào cùng ớt sừng và gia vị", "Gà Xào Ớt Sừng", 2, "Calo: 300, Protein: 22g, Chất béo: 15g, Carbohydrate: 10g" },
                    { 26, "Thịt gà xào cùng hành và các loại gia vị", "Gà Xào Hành", 2, "Calo: 290, Protein: 24g, Chất béo: 16g, Carbohydrate: 8g" },
                    { 27, "Thịt gà xào cùng gừng và các loại gia vị", "Gà Xào Gừng", 2, "Calo: 280, Protein: 23g, Chất béo: 15g, Carbohydrate: 10g" },
                    { 28, "Cải bắp xào với tỏi và dầu ăn", "Cải Bắp Xào", 2, "Calo: 70, Protein: 4g, Chất béo: 3g, Carbohydrate: 10g" },
                    { 29, "Rau muống xào với tỏi và dầu ăn", "Rau Muống Xào", 2, "Calo: 60, Protein: 3g, Chất béo: 2g, Carbohydrate: 8g" },
                    { 30, "Rau lang luộc với nước mắm pha", "Rau Lang Luộc", 2, "Calo: 40, Protein: 2g, Chất béo: 1g, Carbohydrate: 6g" },
                    { 31, "Canh cải bắp nấu với thịt heo và nước dừa", "Canh Cải Bắp", 2, "Calo: 80, Protein: 5g, Chất béo: 4g, Carbohydrate: 10g" },
                    { 32, "Canh rau cải nấu với tôm và hành", "Canh Rau Cải", 2, "Calo: 70, Protein: 4g, Chất béo: 3g, Carbohydrate: 8g" },
                    { 33, "Canh đậu hủ nấu với nấm và hành", "Canh Đậu Hủ", 2, "Calo: 60, Protein: 5g, Chất béo: 2g, Carbohydrate: 6g" },
                    { 34, "Xoài chín ngọt, 50g", "Xoài", 3, "Calo: 110, Carbohydrate: 30g" },
                    { 35, "Dưa hấu tươi mát, 50g", "Dưa Hấu", 3, "Calo: 95, Carbohydrate: 25g" },
                    { 36, "Chuối chín mọng, 50g", "Chuối", 3, "Calo: 140, Carbohydrate: 38g" },
                    { 37, "Cam chín mọng, 50g", "Cam", 3, "Calo: 60, Carbohydrate: 15g" },
                    { 38, "Nho tươi mát, 50g", "Nho", 3, "Calo: 40, Carbohydrate: 10g" },
                    { 39, "Lê chín mềm, 50g", "Lê", 3, "Calo: 30, Carbohydrate: 8g" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 39);

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
        }
    }
}
