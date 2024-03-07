using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class seeding_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "ID", "Description", "Img" },
                values: new object[] { 1, "Chào mừng đến với trang web quản lý suất ăn bán trú dành cho trẻ em tiểu học - MMC System!\r\n\r\n## Giới Thiệu\r\n\r\nMMC System là một hệ thống quản lý suất ăn chuyên nghiệp, thiết kế đặc biệt để đáp ứng nhu cầu dinh dưỡng của các em học sinh tiểu học. Chúng tôi cam kết mang đến trải nghiệm an toàn, tiện lợi và đảm bảo chất lượng cho cả học sinh, phụ huynh và nhà trường.\r\n\r\n## Đặc Điểm Nổi Bật\r\n\r\n### 1. **Dinh Dưỡng Đa Dạng**\r\n   Chúng tôi chú trọng đến việc cung cấp các bữa ăn đa dạng, cân đối và phù hợp với lứa tuổi của học sinh tiểu học. Thực đơn được thiết kế theo chuẩn dinh dưỡng, giúp trẻ phát triển toàn diện.\r\n\r\n### 2. **Quản Lý Thuận Tiện**\r\n   MMC System giúp phụ huynh và nhà trường dễ dàng quản lý thông tin về suất ăn, theo dõi chất lượng bữa ăn, và đặt lịch trực tuyến một cách thuận tiện.\r\n\r\n### 3. **An Toàn và Nhanh Chóng**\r\n   Đội ngũ chuyên gia chế biến thực phẩm của chúng tôi tuân thủ nghiêm ngặt các tiêu chuẩn vệ sinh và an toàn thực phẩm, đảm bảo rằng mỗi bữa ăn đều đạt chuẩn chất lượng cao.\r\n\r\n### 4. **Hỗ Trợ Tận Tâm**\r\n   Chúng tôi luôn lắng nghe và hỗ trợ mọi nhu cầu của phụ huynh và nhà trường. Đội ngũ hỗ trợ của chúng tôi sẽ luôn sẵn lòng giải đáp mọi thắc mắc và đảm bảo sự hài lòng của quý vị.\r\n\r\n## Hãy Đăng Ký Ngay!\r\n\r\nHãy đồng hành cùng MMC System để đảm bảo chất lượng dinh dưỡng và sức khỏe cho tương lai của con em chúng ta. Đăng ký ngay để trải nghiệm sự thuận tiện và chất lượng từ dịch vụ của chúng tôi!\r\n\r\nCảm ơn bạn đã ghé thăm MMC System!", "https://firebasestorage.googleapis.com/v0/b/mmcsytem.appspot.com/o/images%2Fintro.jpg?alt=media&token=4b9098af-363d-4162-91af-1eeb6e709aaa" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "526dbea5-095c-4cb5-bf0c-432b157b05de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "ce0fbffc-16c6-4fde-baae-14789ce77707");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "c721f1a7-fe30-4ad0-a821-5e0139a53a5f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fe0e9c2d-6abd-4f73-a635-63fc58ec700e"),
                column: "ConcurrencyStamp",
                value: "78d6cfce-0e1c-4b95-b515-a0c3902b1851");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7a0b62c-5a81-43ea-9035-7548a3b39259", "AQAAAAEAACcQAAAAEMI+F8xN5ifzZjnbrlSCmm7TvXzfZX/q9JMMmgnM6+ahsnWBuPhXK2HfsYt+kfmxfg==", "4208617d-1912-4132-8385-50f99fae82b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8c6d5a4-ed9e-4f94-b5e8-ccd0e40a7f1d", "AQAAAAEAACcQAAAAEG/uaXjJEFxnivBuuy6XLvX1EQ+SbHZcTSd7jr6br3EHCcl6fBvHvTnABz09m83+YA==", "d9e9ec33-efe0-450a-8e32-b34654337bcd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "About",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "a9e6c530-2f08-41d3-93a8-7a29dd6a60d2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "e4c97408-80d8-40be-974b-1d9526c70566");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "45f5dfa5-6349-48f9-bdb4-ed32de8b8fe2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fe0e9c2d-6abd-4f73-a635-63fc58ec700e"),
                column: "ConcurrencyStamp",
                value: "2d150cec-85e1-4a92-a2ab-411cd2df665b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec1fb9ff-ab9e-46ca-bb43-f21caecc6c2f", "AQAAAAEAACcQAAAAEDOyS71yf0rZ88vLZmqSvxo5+m1sHU0DGUlEgPu0rmirykr//fLd53zMoQDRPj82LQ==", "02f8626a-a7d6-4e4a-b4db-9d433b454c5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0b087b7-eefd-4ac3-a4e6-cc3bcedfcc9d", "AQAAAAEAACcQAAAAEDHryxv5bg2/ioQL3hYZy1tFCuPXclJmanEigh2Ui9ERLM0jZ3ZsmWtgDMrNrXQCQA==", "b7efe980-f115-4955-98af-3b4dfa17a81e" });
        }
    }
}
