using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddSupplier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierId);
                    table.ForeignKey(
                        name: "FK_Supplier_Education_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Education",
                        principalColumn: "Id");
                });

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

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "SupplierId", "EducationId", "Email", "Phone", "SupplierName" },
                values: new object[,]
                {
                    { 1, 1, "info@thucphamsach.com", "0987654321", "Công ty Thực phẩm Sạch" },
                    { 2, 1, "nguyenlieuxanh@gmail.com", "0912345678", "Nhà cung cấp Nguyên liệu Xanh" },
                    { 3, 1, "info@thucphamhuuco.com", "0909090909", "Công ty Thực phẩm Hữu cơ" },
                    { 4, 1, "info@thucphamhaisan.com", "0977123456", "Công ty Thực phẩm Hải sản tươi" },
                    { 5, 1, "rausachorganic@gmail.com", "0967123456", "Nhà cung cấp Rau sạch Organic" },
                    { 6, 1, "info@thucphamchay.com", "0968123456", "Công ty Thực phẩm Chay" },
                    { 7, 1, "thitbosach@gmail.com", "0969123456", "Nhà cung cấp Thịt bò sạch" },
                    { 8, 1, "info@thucphamtraicay.com", "0970123456", "Công ty Thực phẩm Trái cây tươi" },
                    { 9, 1, "info@thucphamnuocgiakhat.com", "0981123456", "Công ty Thực phẩm Nước giải khát" },
                    { 10, 1, "hatgiomgorganic@gmail.com", "0964123456", "Nhà cung cấp Hạt giống Organic" },
                    { 11, 1, "thucphamdonglanh@gmail.com", "0965123456", "Cửa hàng Thực phẩm Đông lạnh" },
                    { 12, 1, "thucphamdinhdưỡng@gmail.com", "0966123456", "Nhà cung cấp Thực phẩm Dinh dưỡng" },
                    { 13, 1, "info@thucphamcaocap.com", "0962123456", "Công ty Thực phẩm Cao cấp" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_EducationId",
                table: "Supplier",
                column: "EducationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Supplier");

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
        }
    }
}
