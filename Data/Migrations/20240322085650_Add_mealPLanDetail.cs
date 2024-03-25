using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Add_mealPLanDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DatePlan",
                table: "MealPlan",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "MealPlan",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MealPlanDetail",
                columns: table => new
                {
                    MealPlanID = table.Column<int>(type: "int", nullable: false),
                    DishId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPlanDetail", x => new { x.MealPlanID, x.DishId });
                    table.ForeignKey(
                        name: "FK_MealPlanDetail_Dish_DishId",
                        column: x => x.DishId,
                        principalTable: "Dish",
                        principalColumn: "DishId");
                    table.ForeignKey(
                        name: "FK_MealPlanDetail_MealPlan_MealPlanID",
                        column: x => x.MealPlanID,
                        principalTable: "MealPlan",
                        principalColumn: "MealPlanID");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "caaa4dc4-60ef-4198-ae9e-194037b6ef16");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "9de15dc2-5a67-4a08-8020-2461a2d4ab11");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "9631fe72-9a8b-4640-8090-519069ade262");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0ee3e5a7-89ed-4bd2-8729-c66311b30033"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b83fa8a-119d-428d-89b4-b69807c0fdc1", "AQAAAAEAACcQAAAAEELnDJ9Xw1iONrO1bwxgY8O3rZ7HFExHzXFTZMUlkwKfzVsmik5+OOnzTa6p+wDBsA==", "61be19e0-545f-410c-b433-a6e13ecdbd66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2465dad-f8f1-4a51-924c-afe0c66abfdd", "AQAAAAEAACcQAAAAEMKL3Zvy1icFLqSCJ6tO1rWk0NvFMDYAPeUavNLIFckQnsi9uRT5Yfb5v6raT5bMyA==", "4239dd10-5252-4013-8412-917b62dbf339" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c85649c-2d04-4846-a5f2-212ea550291b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4f6549f-d54c-4125-955f-f0c7015894ec", "AQAAAAEAACcQAAAAEB2Iqn1tOZIIWwzqiF0tcYYv9nnJXvUCYheP5uDqsYKLr310l+KdKIr9HnRflTiF4g==", "5aec7e47-7058-4799-86e4-3308a374277a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dabe045f-61eb-4777-ae5c-560529bae7dc", "AQAAAAEAACcQAAAAECzTjJTDz/E8abhsGFw7XyLnfChbXH35kj3Z0CBsqInRlNFXnrqeKPRjLsnlUgJs6g==", "c43ea983-177d-4d23-93ed-97473c31b93f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b551fd08-76d9-4040-b0fa-fb2e7aacbe7d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d94bfba-6ced-42f1-9958-63dfd20f3ccd", "AQAAAAEAACcQAAAAEBGqopIeqHVF8r64ghuQwqhcWaIdRHVdtQmEx9WhRRqVd+Wrui1kPMJKuSAa12TnWg==", "59f275b9-7029-491a-98de-25c48078a337" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8ddc2e0-8b14-4c37-869e-7ca5bad4671a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e86d287-4652-45ae-a2cb-b7a2beb80c9a", "AQAAAAEAACcQAAAAEFj+Y5bcyVhyp36PgOfpDWQB6xigeEIrlVIzlksf8T4yAtp/TZWfXxi9UQPvyrEvWg==", "91ec4863-780c-4603-b8c1-7d9b773e9548" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c3a4a2eb-1703-4fc5-8511-f68acdb3a1d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "228999b2-7ac9-4bad-9fdc-cb20b712477e", "AQAAAAEAACcQAAAAEFOtrPtkM3gdS9xCOSWZdEOPBLHBeFdbPyoEGwOdk28TpiKUvf3ZGkRXAJ3/3daPug==", "a6913150-2884-42aa-828a-53ac3357cd58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7d19c1e-a674-4d77-978a-47bbacd6910e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c5e883a-9861-4f70-b23f-8adcb73d996f", "AQAAAAEAACcQAAAAEPIZq/tdffbcutC840Z/luDVcE9qOEOgHR6qNZ8KgesXvYbhlYWODDtRt9UlrkhdVA==", "cee7725c-86a9-435d-aa1d-c893863e8c51" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 22, 15, 56, 49, 7, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 22, 15, 56, 49, 7, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 22, 15, 56, 49, 7, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 22, 15, 56, 49, 7, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 22, 15, 56, 49, 7, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 22, 15, 56, 49, 7, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 22, 15, 56, 49, 7, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 22, 15, 56, 49, 7, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 22, 15, 56, 49, 7, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.InsertData(
                table: "MealPlan",
                columns: new[] { "MealPlanID", "ClassTypeId", "DatePlan", "Description", "EducationId", "MealPlanName", "MealTypeId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trẻ em ở độ tuổi lớp 1 cần có một chế độ ăn uống vào buổi sáng cân đối và giàu dinh dưỡng thúc đẩy tăng trưởng chiều cao.", 1, "Kế hoạch ăn uống cho trẻ em lớp 1", 1 },
                    { 2, 1, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trẻ em ở độ tuổi lớp 1 cần có một chế độ ăn uống vào buổi trưa hợp lý cân đối và giàu dinh dưỡng.", 1, "Kế hoạch ăn uống cho trẻ em lớp 1", 2 },
                    { 3, 1, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thức ăn tráng miệng đầy chất sơ cho trẻ", 1, "Kế hoạch ăn uống cho trẻ em lớp 1", 3 },
                    { 4, 2, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trẻ em lớp 2 cần có bữa sáng cung cấp đủ dinh dưỡng để hỗ trợ sự phát triển và học tập.", 1, "Kế hoạch ăn uống cho trẻ em lớp 2", 1 },
                    { 5, 2, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trẻ em lớp 2 cần có bữa trưa cung cấp đủ dinh dưỡng để hỗ trợ sự phát triển và học tập.", 1, "Kế hoạch ăn uống cho trẻ em lớp 2", 2 },
                    { 6, 2, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thức ăn tráng miệng đầy chất sơ cho trẻ", 1, "Kế hoạch ăn uống cho trẻ em lớp 2", 3 },
                    { 7, 3, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trẻ em lớp 3 cần có bữa tối cung cấp đủ năng lượng và dinh dưỡng để hỗ trợ sự phát triển và hoạt động học tập.", 1, "Kế hoạch ăn uống cho trẻ em lớp 3", 1 },
                    { 8, 3, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trẻ em lớp 3 cần có bữa tối cung cấp đủ năng lượng và dinh dưỡng để hỗ trợ sự phát triển và hoạt động học tập.", 1, "Kế hoạch ăn uống cho trẻ em lớp 3", 2 },
                    { 9, 3, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thức ăn tráng miệng đầy chất sơ cho trẻ", 1, "Kế hoạch ăn uống cho trẻ em lớp 3", 3 },
                    { 10, 4, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trẻ em lớp 4 đang trong giai đoạn phát triển nhanh chóng, cần có bữa sáng cung cấp đủ dinh dưỡng và năng lượng.", 1, "Kế hoạch ăn uống cho trẻ em lớp 4", 1 },
                    { 11, 4, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trẻ em lớp 4 đang trong giai đoạn phát triển nhanh chóng, cần có bữa trưa cung cấp đủ dinh dưỡng và năng lượng.", 1, "Kế hoạch ăn uống cho trẻ em lớp 4", 2 },
                    { 12, 4, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thức ăn tráng miệng đầy chất sơ cho trẻ", 1, "Kế hoạch ăn uống cho trẻ em lớp 4", 3 },
                    { 13, 4, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trẻ em lớp 5 cần có bữa sáng cung cấp chế độ ăn uống cân đối và giàu dinh dưỡng để duy trì sức khỏe và năng lượng suốt cả ngày.", 1, "Kế hoạch ăn uống cho trẻ em lớp 5", 1 },
                    { 14, 4, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trẻ em lớp 5 cần có ở bữa trưa cung cấp chế độ ăn uống cân đối và giàu dinh dưỡng để duy trì sức khỏe và năng lượng suốt cả ngày.", 1, "Kế hoạch ăn uống cho trẻ em lớp 5", 2 },
                    { 15, 4, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thức ăn tráng miệng đầy chất sơ cho trẻ", 1, "Kế hoạch ăn uống cho trẻ em lớp 5", 3 }
                });

            migrationBuilder.InsertData(
                table: "MealPlanDetail",
                columns: new[] { "DishId", "MealPlanID", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1m },
                    { 9, 2, 1m },
                    { 10, 2, 1m },
                    { 13, 2, 1m },
                    { 28, 2, 1m },
                    { 34, 3, 1m },
                    { 1, 4, 1m },
                    { 9, 5, 1m },
                    { 10, 5, 1m },
                    { 13, 5, 1m },
                    { 28, 5, 1m },
                    { 34, 6, 1m },
                    { 1, 7, 1m },
                    { 9, 8, 1m },
                    { 10, 8, 1m },
                    { 13, 8, 1m },
                    { 28, 8, 1m },
                    { 34, 9, 1m },
                    { 1, 10, 1m },
                    { 9, 11, 1m },
                    { 10, 11, 1m },
                    { 13, 11, 1m },
                    { 28, 11, 1m },
                    { 34, 12, 1m },
                    { 1, 13, 1m },
                    { 9, 14, 1m },
                    { 10, 14, 1m },
                    { 13, 14, 1m },
                    { 28, 14, 1m },
                    { 34, 15, 1m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MealPlanDetail_DishId",
                table: "MealPlanDetail",
                column: "DishId");

            migrationBuilder.AddForeignKey(
                name: "FK_MealPlan_Education_MealTypeId",
                table: "MealPlan",
                column: "MealTypeId",
                principalTable: "Education",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealPlan_Education_MealTypeId",
                table: "MealPlan");

            migrationBuilder.DropTable(
                name: "MealPlanDetail");

            migrationBuilder.DeleteData(
                table: "MealPlan",
                keyColumn: "MealPlanID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MealPlan",
                keyColumn: "MealPlanID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MealPlan",
                keyColumn: "MealPlanID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MealPlan",
                keyColumn: "MealPlanID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MealPlan",
                keyColumn: "MealPlanID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MealPlan",
                keyColumn: "MealPlanID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MealPlan",
                keyColumn: "MealPlanID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MealPlan",
                keyColumn: "MealPlanID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MealPlan",
                keyColumn: "MealPlanID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MealPlan",
                keyColumn: "MealPlanID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MealPlan",
                keyColumn: "MealPlanID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MealPlan",
                keyColumn: "MealPlanID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MealPlan",
                keyColumn: "MealPlanID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MealPlan",
                keyColumn: "MealPlanID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MealPlan",
                keyColumn: "MealPlanID",
                keyValue: 15);

            migrationBuilder.DropColumn(
                name: "DatePlan",
                table: "MealPlan");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "MealPlan");

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
        }
    }
}
