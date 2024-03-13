using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class UpdateClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MealItems");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.AddColumn<int>(
                name: "ClassTypeId",
                table: "Class",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ClassType",
                columns: table => new
                {
                    ClassTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassType", x => x.ClassTypeId);
                });

            migrationBuilder.CreateTable(
                name: "MealPlan",
                columns: table => new
                {
                    MealPlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MealPlanName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassTypeId = table.Column<int>(type: "int", nullable: false),
                    MealTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPlan", x => x.MealPlanID);
                    table.ForeignKey(
                        name: "FK_MealPlan_ClassType_MealTypeId",
                        column: x => x.MealTypeId,
                        principalTable: "ClassType",
                        principalColumn: "ClassTypeId");
                    table.ForeignKey(
                        name: "FK_MealPlan_MealType_MealTypeId",
                        column: x => x.MealTypeId,
                        principalTable: "MealType",
                        principalColumn: "Id");
                });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fcc1d9f-aee1-4a60-ad94-10e4f5797344", "AQAAAAEAACcQAAAAEENpKMVcJ7pyx0ap/XbHinMPfSyR8t+EeDE4YpZs8cn8+uSGc0ZeOnt4t5b63H350Q==", "0ea8a518-8893-4ef5-bfa3-5bc9bcd3ff41" });

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

            migrationBuilder.InsertData(
                table: "ClassType",
                columns: new[] { "ClassTypeId", "ClassTypeName" },
                values: new object[,]
                {
                    { 1, "Lớp 1" },
                    { 2, "Lớp 2" },
                    { 3, "Lớp 3" },
                    { 4, "Lớp 4" },
                    { 5, "Lớp 5" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Trường Tiểu học Đống Đa" },
                    { 2, "Trường Tiểu học Nguyễn Du" },
                    { 3, "Trường Tiểu học Phan Chu Trinh" },
                    { 4, "Trường Tiểu học Trần Hưng Đạo " },
                    { 5, "Trường Tiểu học Lê Lợi" }
                });

            migrationBuilder.InsertData(
                table: "MealType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bữa sáng" },
                    { 2, "Bữa trưa" },
                    { 3, "Bữa chiều" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Class_ClassTypeId",
                table: "Class",
                column: "ClassTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MealPlan_MealTypeId",
                table: "MealPlan",
                column: "MealTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_ClassType_ClassTypeId",
                table: "Class",
                column: "ClassTypeId",
                principalTable: "ClassType",
                principalColumn: "ClassTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_ClassType_ClassTypeId",
                table: "Class");

            migrationBuilder.DropTable(
                name: "MealPlan");

            migrationBuilder.DropTable(
                name: "ClassType");

            migrationBuilder.DropIndex(
                name: "IX_Class_ClassTypeId",
                table: "Class");

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MealType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MealType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MealType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ClassTypeId",
                table: "Class");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    MealID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealTypeId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.MealID);
                    table.ForeignKey(
                        name: "FK_Meals_MealType_MealTypeId",
                        column: x => x.MealTypeId,
                        principalTable: "MealType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    DishID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NutritionInformation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.DishID);
                    table.ForeignKey(
                        name: "FK_Menu_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MealItems",
                columns: table => new
                {
                    DishID = table.Column<int>(type: "int", nullable: false),
                    MealID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealItems", x => x.DishID);
                    table.ForeignKey(
                        name: "FK_MealItems_Meals_MealID",
                        column: x => x.MealID,
                        principalTable: "Meals",
                        principalColumn: "MealID");
                    table.ForeignKey(
                        name: "FK_MealItems_Menu_DishID",
                        column: x => x.DishID,
                        principalTable: "Menu",
                        principalColumn: "DishID");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "6023a42b-f00b-4fd7-89ac-87114b6dc492");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "7b4e1e47-0c9d-4241-962a-3a963027fb5f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "fc60626a-a5cf-41d4-b2b7-a4ce0ab302eb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fe0e9c2d-6abd-4f73-a635-63fc58ec700e"),
                column: "ConcurrencyStamp",
                value: "e6c928a2-a757-4770-8945-f58f11c22ff7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0952d9a-9bb4-4237-9224-9d9bede7fb55", "AQAAAAEAACcQAAAAEFKSAa7xJ1Y2Cvkx8Ikclwgmj47zBDamiSxbtM+172Voew7zUIcvpbBDEACySsp/nQ==", "24ceddd2-ced7-4b9f-a9fc-e41a625c901b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45004df9-1db2-4af5-9778-11394201771d", "AQAAAAEAACcQAAAAEIWg30ES46YRzxkVVDvugelvcCjkr1wsX42k2TFrhT7fbcSoYA6DC3byoVKQqeovyQ==", "9c2c2354-3ba7-4ac8-8adb-bcabf812887f" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 11, 22, 48, 19, 505, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 11, 22, 48, 19, 505, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 11, 22, 48, 19, 505, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 11, 22, 48, 19, 505, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 11, 22, 48, 19, 505, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 11, 22, 48, 19, 505, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 11, 22, 48, 19, 505, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 11, 22, 48, 19, 505, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 11, 22, 48, 19, 505, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.CreateIndex(
                name: "IX_MealItems_MealID",
                table: "MealItems",
                column: "MealID");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_MealTypeId",
                table: "Meals",
                column: "MealTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_CategoryId",
                table: "Menu",
                column: "CategoryId");
        }
    }
}
