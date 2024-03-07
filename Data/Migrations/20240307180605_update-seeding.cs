using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class updateseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "28685835-19aa-4d7c-ad2f-c3b8dc7e9246");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "f327318d-3452-4e9e-ae53-90bdbe0f04e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "a6077daf-e79d-4fc2-a3cc-f8ffab377689");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fe0e9c2d-6abd-4f73-a635-63fc58ec700e"),
                column: "ConcurrencyStamp",
                value: "d2ea9149-4f82-4dce-a5e8-fe482e0433d0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4f8ac36-1561-45a0-a7a9-5a49bd341add", "AQAAAAEAACcQAAAAENPoOIha5TdJj5C799nZaLPnTV4o+yZr0MGKxJnrbg9cR4Oelb1xiBXGJSRcWDrnhw==", "3c4ce554-ba09-42e5-90e1-d8c209bde5ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca9f0e43-c614-40fa-bab9-63e992975684", "AQAAAAEAACcQAAAAEFT91GlW9FRde8uHBWTEOYmIsVkLmjD5pmh1bbRZXL/Vj3nr7hOVU1xvM6Y1jAd0MQ==", "1099ed38-95fd-4e9d-aa3b-87c75e2b5260" });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "ID", "Date", "Description", "Img", "Tilte" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 8, 1, 6, 5, 365, DateTimeKind.Local).AddTicks(4491), "Tự động hóa việc quản lý suất ăn bán trú cho trẻ em tiểu học với MMC System\r\n\r\nMMC System là một nền tảng quản lý suất ăn bán trú được thiết kế để giúp các trường tiểu học dễ dàng tổ chức và theo dõi thực đơn, đặt hàng, và ghi nhận thông tin liên quan đến việc cung cấp suất ăn cho học sinh một cách hiệu quả.\r\n\r\n### 1. Tính Tiện Ích và Linh Hoạt\r\n\r\nMMC System mang lại trải nghiệm quản lý linh hoạt và tiện ích cho những người đảm nhận việc quản lý suất ăn bán trú. Với giao diện người dùng thân thiện, bạn có thể dễ dàng xác định các thực đơn, theo dõi số lượng suất ăn, và quản lý thông tin học sinh một cách hiệu quả.\r\n\r\n### 2. Quản Lý Thực Đơn Hiệu Quả\r\n\r\nMMC System cho phép bạn tạo và quản lý các thực đơn dựa trên các yếu tố như chế độ ăn, loại thực phẩm, và các yêu cầu dinh dưỡng. Điều này giúp đảm bảo rằng học sinh nhận được bữa ăn cân đối và phù hợp với nhu cầu dinh dưỡng của họ.\r\n\r\n### 3. Đặt Hàng và Theo Dõi Chi Tiết\r\n\r\nKhông còn phải lo lắng về việc đặt hàng và theo dõi số lượng suất ăn cần chuẩn bị. MMC System cung cấp chức năng đặt hàng tự động dựa trên số lượng học sinh và thực đơn đã chọn. Bạn có thể dễ dàng theo dõi và điều chỉnh đơn đặt hàng của mình thông qua giao diện đơn giản và thuận tiện.\r\n\r\n### 4. Thông Tin Học Sinh Đầy Đủ\r\n\r\nMỗi học sinh đều có một hồ sơ chi tiết trong hệ thống, nơi bạn có thể xem xét thông tin về thực đơn ưa thích, dị ứng thực phẩm, và bất kỳ yêu cầu dinh dưỡng nào khác. Điều này giúp đảm bảo rằng mọi bữa ăn đều đáp ứng đúng nhu cầu cụ thể của từng học sinh.\r\n\r\n### 5. Bảo Mật và Dữ Liệu An Toàn\r\n\r\nMMC System cam kết bảo vệ an toàn thông tin cá nhân và dữ liệu về dinh dưỡng. Với các biện pháp bảo mật hàng đầu, bạn có thể yên tâm rằng dữ liệu của bạn được bảo vệ chặt chẽ.\r\n\r\nKhám phá MMC System ngay hôm nay để trải nghiệm sự tiện lợi và linh hoạt trong việc quản lý suất ăn bán trú, giúp tăng cường chất lượng cuộc sống học đường và đảm bảo sức khỏe của học sinh.", "https://firebasestorage.googleapis.com/v0/b/mmcsytem.appspot.com/o/images%2Fintro.jpg?alt=media&token=4b9098af-363d-4162-91af-1eeb6e709aaa", "Blog 1" },
                    { 2, new DateTime(2024, 3, 8, 1, 6, 5, 365, DateTimeKind.Local).AddTicks(4501), "Tự động hóa việc quản lý suất ăn bán trú cho trẻ em tiểu học với MMC System\r\n\r\nMMC System là một nền tảng quản lý suất ăn bán trú được thiết kế để giúp các trường tiểu học dễ dàng tổ chức và theo dõi thực đơn, đặt hàng, và ghi nhận thông tin liên quan đến việc cung cấp suất ăn cho học sinh một cách hiệu quả.\r\n\r\n### 1. Tính Tiện Ích và Linh Hoạt\r\n\r\nMMC System mang lại trải nghiệm quản lý linh hoạt và tiện ích cho những người đảm nhận việc quản lý suất ăn bán trú. Với giao diện người dùng thân thiện, bạn có thể dễ dàng xác định các thực đơn, theo dõi số lượng suất ăn, và quản lý thông tin học sinh một cách hiệu quả.\r\n\r\n### 2. Quản Lý Thực Đơn Hiệu Quả\r\n\r\nMMC System cho phép bạn tạo và quản lý các thực đơn dựa trên các yếu tố như chế độ ăn, loại thực phẩm, và các yêu cầu dinh dưỡng. Điều này giúp đảm bảo rằng học sinh nhận được bữa ăn cân đối và phù hợp với nhu cầu dinh dưỡng của họ.\r\n\r\n### 3. Đặt Hàng và Theo Dõi Chi Tiết\r\n\r\nKhông còn phải lo lắng về việc đặt hàng và theo dõi số lượng suất ăn cần chuẩn bị. MMC System cung cấp chức năng đặt hàng tự động dựa trên số lượng học sinh và thực đơn đã chọn. Bạn có thể dễ dàng theo dõi và điều chỉnh đơn đặt hàng của mình thông qua giao diện đơn giản và thuận tiện.\r\n\r\n### 4. Thông Tin Học Sinh Đầy Đủ\r\n\r\nMỗi học sinh đều có một hồ sơ chi tiết trong hệ thống, nơi bạn có thể xem xét thông tin về thực đơn ưa thích, dị ứng thực phẩm, và bất kỳ yêu cầu dinh dưỡng nào khác. Điều này giúp đảm bảo rằng mọi bữa ăn đều đáp ứng đúng nhu cầu cụ thể của từng học sinh.\r\n\r\n### 5. Bảo Mật và Dữ Liệu An Toàn\r\n\r\nMMC System cam kết bảo vệ an toàn thông tin cá nhân và dữ liệu về dinh dưỡng. Với các biện pháp bảo mật hàng đầu, bạn có thể yên tâm rằng dữ liệu của bạn được bảo vệ chặt chẽ.\r\n\r\nKhám phá MMC System ngay hôm nay để trải nghiệm sự tiện lợi và linh hoạt trong việc quản lý suất ăn bán trú, giúp tăng cường chất lượng cuộc sống học đường và đảm bảo sức khỏe của học sinh.", "https://firebasestorage.googleapis.com/v0/b/mmcsytem.appspot.com/o/images%2Fintro.jpg?alt=media&token=4b9098af-363d-4162-91af-1eeb6e709aaa", "Blog 2" },
                    { 3, new DateTime(2024, 3, 8, 1, 6, 5, 365, DateTimeKind.Local).AddTicks(4503), "Tự động hóa việc quản lý suất ăn bán trú cho trẻ em tiểu học với MMC System\r\n\r\nMMC System là một nền tảng quản lý suất ăn bán trú được thiết kế để giúp các trường tiểu học dễ dàng tổ chức và theo dõi thực đơn, đặt hàng, và ghi nhận thông tin liên quan đến việc cung cấp suất ăn cho học sinh một cách hiệu quả.\r\n\r\n### 1. Tính Tiện Ích và Linh Hoạt\r\n\r\nMMC System mang lại trải nghiệm quản lý linh hoạt và tiện ích cho những người đảm nhận việc quản lý suất ăn bán trú. Với giao diện người dùng thân thiện, bạn có thể dễ dàng xác định các thực đơn, theo dõi số lượng suất ăn, và quản lý thông tin học sinh một cách hiệu quả.\r\n\r\n### 2. Quản Lý Thực Đơn Hiệu Quả\r\n\r\nMMC System cho phép bạn tạo và quản lý các thực đơn dựa trên các yếu tố như chế độ ăn, loại thực phẩm, và các yêu cầu dinh dưỡng. Điều này giúp đảm bảo rằng học sinh nhận được bữa ăn cân đối và phù hợp với nhu cầu dinh dưỡng của họ.\r\n\r\n### 3. Đặt Hàng và Theo Dõi Chi Tiết\r\n\r\nKhông còn phải lo lắng về việc đặt hàng và theo dõi số lượng suất ăn cần chuẩn bị. MMC System cung cấp chức năng đặt hàng tự động dựa trên số lượng học sinh và thực đơn đã chọn. Bạn có thể dễ dàng theo dõi và điều chỉnh đơn đặt hàng của mình thông qua giao diện đơn giản và thuận tiện.\r\n\r\n### 4. Thông Tin Học Sinh Đầy Đủ\r\n\r\nMỗi học sinh đều có một hồ sơ chi tiết trong hệ thống, nơi bạn có thể xem xét thông tin về thực đơn ưa thích, dị ứng thực phẩm, và bất kỳ yêu cầu dinh dưỡng nào khác. Điều này giúp đảm bảo rằng mọi bữa ăn đều đáp ứng đúng nhu cầu cụ thể của từng học sinh.\r\n\r\n### 5. Bảo Mật và Dữ Liệu An Toàn\r\n\r\nMMC System cam kết bảo vệ an toàn thông tin cá nhân và dữ liệu về dinh dưỡng. Với các biện pháp bảo mật hàng đầu, bạn có thể yên tâm rằng dữ liệu của bạn được bảo vệ chặt chẽ.\r\n\r\nKhám phá MMC System ngay hôm nay để trải nghiệm sự tiện lợi và linh hoạt trong việc quản lý suất ăn bán trú, giúp tăng cường chất lượng cuộc sống học đường và đảm bảo sức khỏe của học sinh.", "https://firebasestorage.googleapis.com/v0/b/mmcsytem.appspot.com/o/images%2Fintro.jpg?alt=media&token=4b9098af-363d-4162-91af-1eeb6e709aaa", "Blog 3" },
                    { 4, new DateTime(2024, 3, 8, 1, 6, 5, 365, DateTimeKind.Local).AddTicks(4503), "Tự động hóa việc quản lý suất ăn bán trú cho trẻ em tiểu học với MMC System\r\n\r\nMMC System là một nền tảng quản lý suất ăn bán trú được thiết kế để giúp các trường tiểu học dễ dàng tổ chức và theo dõi thực đơn, đặt hàng, và ghi nhận thông tin liên quan đến việc cung cấp suất ăn cho học sinh một cách hiệu quả.\r\n\r\n### 1. Tính Tiện Ích và Linh Hoạt\r\n\r\nMMC System mang lại trải nghiệm quản lý linh hoạt và tiện ích cho những người đảm nhận việc quản lý suất ăn bán trú. Với giao diện người dùng thân thiện, bạn có thể dễ dàng xác định các thực đơn, theo dõi số lượng suất ăn, và quản lý thông tin học sinh một cách hiệu quả.\r\n\r\n### 2. Quản Lý Thực Đơn Hiệu Quả\r\n\r\nMMC System cho phép bạn tạo và quản lý các thực đơn dựa trên các yếu tố như chế độ ăn, loại thực phẩm, và các yêu cầu dinh dưỡng. Điều này giúp đảm bảo rằng học sinh nhận được bữa ăn cân đối và phù hợp với nhu cầu dinh dưỡng của họ.\r\n\r\n### 3. Đặt Hàng và Theo Dõi Chi Tiết\r\n\r\nKhông còn phải lo lắng về việc đặt hàng và theo dõi số lượng suất ăn cần chuẩn bị. MMC System cung cấp chức năng đặt hàng tự động dựa trên số lượng học sinh và thực đơn đã chọn. Bạn có thể dễ dàng theo dõi và điều chỉnh đơn đặt hàng của mình thông qua giao diện đơn giản và thuận tiện.\r\n\r\n### 4. Thông Tin Học Sinh Đầy Đủ\r\n\r\nMỗi học sinh đều có một hồ sơ chi tiết trong hệ thống, nơi bạn có thể xem xét thông tin về thực đơn ưa thích, dị ứng thực phẩm, và bất kỳ yêu cầu dinh dưỡng nào khác. Điều này giúp đảm bảo rằng mọi bữa ăn đều đáp ứng đúng nhu cầu cụ thể của từng học sinh.\r\n\r\n### 5. Bảo Mật và Dữ Liệu An Toàn\r\n\r\nMMC System cam kết bảo vệ an toàn thông tin cá nhân và dữ liệu về dinh dưỡng. Với các biện pháp bảo mật hàng đầu, bạn có thể yên tâm rằng dữ liệu của bạn được bảo vệ chặt chẽ.\r\n\r\nKhám phá MMC System ngay hôm nay để trải nghiệm sự tiện lợi và linh hoạt trong việc quản lý suất ăn bán trú, giúp tăng cường chất lượng cuộc sống học đường và đảm bảo sức khỏe của học sinh.", "https://firebasestorage.googleapis.com/v0/b/mmcsytem.appspot.com/o/images%2Fintro.jpg?alt=media&token=4b9098af-363d-4162-91af-1eeb6e709aaa", "Blog 4" },
                    { 5, new DateTime(2024, 3, 8, 1, 6, 5, 365, DateTimeKind.Local).AddTicks(4504), "Tự động hóa việc quản lý suất ăn bán trú cho trẻ em tiểu học với MMC System\r\n\r\nMMC System là một nền tảng quản lý suất ăn bán trú được thiết kế để giúp các trường tiểu học dễ dàng tổ chức và theo dõi thực đơn, đặt hàng, và ghi nhận thông tin liên quan đến việc cung cấp suất ăn cho học sinh một cách hiệu quả.\r\n\r\n### 1. Tính Tiện Ích và Linh Hoạt\r\n\r\nMMC System mang lại trải nghiệm quản lý linh hoạt và tiện ích cho những người đảm nhận việc quản lý suất ăn bán trú. Với giao diện người dùng thân thiện, bạn có thể dễ dàng xác định các thực đơn, theo dõi số lượng suất ăn, và quản lý thông tin học sinh một cách hiệu quả.\r\n\r\n### 2. Quản Lý Thực Đơn Hiệu Quả\r\n\r\nMMC System cho phép bạn tạo và quản lý các thực đơn dựa trên các yếu tố như chế độ ăn, loại thực phẩm, và các yêu cầu dinh dưỡng. Điều này giúp đảm bảo rằng học sinh nhận được bữa ăn cân đối và phù hợp với nhu cầu dinh dưỡng của họ.\r\n\r\n### 3. Đặt Hàng và Theo Dõi Chi Tiết\r\n\r\nKhông còn phải lo lắng về việc đặt hàng và theo dõi số lượng suất ăn cần chuẩn bị. MMC System cung cấp chức năng đặt hàng tự động dựa trên số lượng học sinh và thực đơn đã chọn. Bạn có thể dễ dàng theo dõi và điều chỉnh đơn đặt hàng của mình thông qua giao diện đơn giản và thuận tiện.\r\n\r\n### 4. Thông Tin Học Sinh Đầy Đủ\r\n\r\nMỗi học sinh đều có một hồ sơ chi tiết trong hệ thống, nơi bạn có thể xem xét thông tin về thực đơn ưa thích, dị ứng thực phẩm, và bất kỳ yêu cầu dinh dưỡng nào khác. Điều này giúp đảm bảo rằng mọi bữa ăn đều đáp ứng đúng nhu cầu cụ thể của từng học sinh.\r\n\r\n### 5. Bảo Mật và Dữ Liệu An Toàn\r\n\r\nMMC System cam kết bảo vệ an toàn thông tin cá nhân và dữ liệu về dinh dưỡng. Với các biện pháp bảo mật hàng đầu, bạn có thể yên tâm rằng dữ liệu của bạn được bảo vệ chặt chẽ.\r\n\r\nKhám phá MMC System ngay hôm nay để trải nghiệm sự tiện lợi và linh hoạt trong việc quản lý suất ăn bán trú, giúp tăng cường chất lượng cuộc sống học đường và đảm bảo sức khỏe của học sinh.", "https://firebasestorage.googleapis.com/v0/b/mmcsytem.appspot.com/o/images%2Fintro.jpg?alt=media&token=4b9098af-363d-4162-91af-1eeb6e709aaa", "Blog 5" },
                    { 6, new DateTime(2024, 3, 8, 1, 6, 5, 365, DateTimeKind.Local).AddTicks(4505), "Tự động hóa việc quản lý suất ăn bán trú cho trẻ em tiểu học với MMC System\r\n\r\nMMC System là một nền tảng quản lý suất ăn bán trú được thiết kế để giúp các trường tiểu học dễ dàng tổ chức và theo dõi thực đơn, đặt hàng, và ghi nhận thông tin liên quan đến việc cung cấp suất ăn cho học sinh một cách hiệu quả.\r\n\r\n### 1. Tính Tiện Ích và Linh Hoạt\r\n\r\nMMC System mang lại trải nghiệm quản lý linh hoạt và tiện ích cho những người đảm nhận việc quản lý suất ăn bán trú. Với giao diện người dùng thân thiện, bạn có thể dễ dàng xác định các thực đơn, theo dõi số lượng suất ăn, và quản lý thông tin học sinh một cách hiệu quả.\r\n\r\n### 2. Quản Lý Thực Đơn Hiệu Quả\r\n\r\nMMC System cho phép bạn tạo và quản lý các thực đơn dựa trên các yếu tố như chế độ ăn, loại thực phẩm, và các yêu cầu dinh dưỡng. Điều này giúp đảm bảo rằng học sinh nhận được bữa ăn cân đối và phù hợp với nhu cầu dinh dưỡng của họ.\r\n\r\n### 3. Đặt Hàng và Theo Dõi Chi Tiết\r\n\r\nKhông còn phải lo lắng về việc đặt hàng và theo dõi số lượng suất ăn cần chuẩn bị. MMC System cung cấp chức năng đặt hàng tự động dựa trên số lượng học sinh và thực đơn đã chọn. Bạn có thể dễ dàng theo dõi và điều chỉnh đơn đặt hàng của mình thông qua giao diện đơn giản và thuận tiện.\r\n\r\n### 4. Thông Tin Học Sinh Đầy Đủ\r\n\r\nMỗi học sinh đều có một hồ sơ chi tiết trong hệ thống, nơi bạn có thể xem xét thông tin về thực đơn ưa thích, dị ứng thực phẩm, và bất kỳ yêu cầu dinh dưỡng nào khác. Điều này giúp đảm bảo rằng mọi bữa ăn đều đáp ứng đúng nhu cầu cụ thể của từng học sinh.\r\n\r\n### 5. Bảo Mật và Dữ Liệu An Toàn\r\n\r\nMMC System cam kết bảo vệ an toàn thông tin cá nhân và dữ liệu về dinh dưỡng. Với các biện pháp bảo mật hàng đầu, bạn có thể yên tâm rằng dữ liệu của bạn được bảo vệ chặt chẽ.\r\n\r\nKhám phá MMC System ngay hôm nay để trải nghiệm sự tiện lợi và linh hoạt trong việc quản lý suất ăn bán trú, giúp tăng cường chất lượng cuộc sống học đường và đảm bảo sức khỏe của học sinh.", "https://firebasestorage.googleapis.com/v0/b/mmcsytem.appspot.com/o/images%2Fintro.jpg?alt=media&token=4b9098af-363d-4162-91af-1eeb6e709aaa", "Blog 6" },
                    { 7, new DateTime(2024, 3, 8, 1, 6, 5, 365, DateTimeKind.Local).AddTicks(4506), "Tự động hóa việc quản lý suất ăn bán trú cho trẻ em tiểu học với MMC System\r\n\r\nMMC System là một nền tảng quản lý suất ăn bán trú được thiết kế để giúp các trường tiểu học dễ dàng tổ chức và theo dõi thực đơn, đặt hàng, và ghi nhận thông tin liên quan đến việc cung cấp suất ăn cho học sinh một cách hiệu quả.\r\n\r\n### 1. Tính Tiện Ích và Linh Hoạt\r\n\r\nMMC System mang lại trải nghiệm quản lý linh hoạt và tiện ích cho những người đảm nhận việc quản lý suất ăn bán trú. Với giao diện người dùng thân thiện, bạn có thể dễ dàng xác định các thực đơn, theo dõi số lượng suất ăn, và quản lý thông tin học sinh một cách hiệu quả.\r\n\r\n### 2. Quản Lý Thực Đơn Hiệu Quả\r\n\r\nMMC System cho phép bạn tạo và quản lý các thực đơn dựa trên các yếu tố như chế độ ăn, loại thực phẩm, và các yêu cầu dinh dưỡng. Điều này giúp đảm bảo rằng học sinh nhận được bữa ăn cân đối và phù hợp với nhu cầu dinh dưỡng của họ.\r\n\r\n### 3. Đặt Hàng và Theo Dõi Chi Tiết\r\n\r\nKhông còn phải lo lắng về việc đặt hàng và theo dõi số lượng suất ăn cần chuẩn bị. MMC System cung cấp chức năng đặt hàng tự động dựa trên số lượng học sinh và thực đơn đã chọn. Bạn có thể dễ dàng theo dõi và điều chỉnh đơn đặt hàng của mình thông qua giao diện đơn giản và thuận tiện.\r\n\r\n### 4. Thông Tin Học Sinh Đầy Đủ\r\n\r\nMỗi học sinh đều có một hồ sơ chi tiết trong hệ thống, nơi bạn có thể xem xét thông tin về thực đơn ưa thích, dị ứng thực phẩm, và bất kỳ yêu cầu dinh dưỡng nào khác. Điều này giúp đảm bảo rằng mọi bữa ăn đều đáp ứng đúng nhu cầu cụ thể của từng học sinh.\r\n\r\n### 5. Bảo Mật và Dữ Liệu An Toàn\r\n\r\nMMC System cam kết bảo vệ an toàn thông tin cá nhân và dữ liệu về dinh dưỡng. Với các biện pháp bảo mật hàng đầu, bạn có thể yên tâm rằng dữ liệu của bạn được bảo vệ chặt chẽ.\r\n\r\nKhám phá MMC System ngay hôm nay để trải nghiệm sự tiện lợi và linh hoạt trong việc quản lý suất ăn bán trú, giúp tăng cường chất lượng cuộc sống học đường và đảm bảo sức khỏe của học sinh.", "https://firebasestorage.googleapis.com/v0/b/mmcsytem.appspot.com/o/images%2Fintro.jpg?alt=media&token=4b9098af-363d-4162-91af-1eeb6e709aaa", "Blog 7" },
                    { 8, new DateTime(2024, 3, 8, 1, 6, 5, 365, DateTimeKind.Local).AddTicks(4507), "Tự động hóa việc quản lý suất ăn bán trú cho trẻ em tiểu học với MMC System\r\n\r\nMMC System là một nền tảng quản lý suất ăn bán trú được thiết kế để giúp các trường tiểu học dễ dàng tổ chức và theo dõi thực đơn, đặt hàng, và ghi nhận thông tin liên quan đến việc cung cấp suất ăn cho học sinh một cách hiệu quả.\r\n\r\n### 1. Tính Tiện Ích và Linh Hoạt\r\n\r\nMMC System mang lại trải nghiệm quản lý linh hoạt và tiện ích cho những người đảm nhận việc quản lý suất ăn bán trú. Với giao diện người dùng thân thiện, bạn có thể dễ dàng xác định các thực đơn, theo dõi số lượng suất ăn, và quản lý thông tin học sinh một cách hiệu quả.\r\n\r\n### 2. Quản Lý Thực Đơn Hiệu Quả\r\n\r\nMMC System cho phép bạn tạo và quản lý các thực đơn dựa trên các yếu tố như chế độ ăn, loại thực phẩm, và các yêu cầu dinh dưỡng. Điều này giúp đảm bảo rằng học sinh nhận được bữa ăn cân đối và phù hợp với nhu cầu dinh dưỡng của họ.\r\n\r\n### 3. Đặt Hàng và Theo Dõi Chi Tiết\r\n\r\nKhông còn phải lo lắng về việc đặt hàng và theo dõi số lượng suất ăn cần chuẩn bị. MMC System cung cấp chức năng đặt hàng tự động dựa trên số lượng học sinh và thực đơn đã chọn. Bạn có thể dễ dàng theo dõi và điều chỉnh đơn đặt hàng của mình thông qua giao diện đơn giản và thuận tiện.\r\n\r\n### 4. Thông Tin Học Sinh Đầy Đủ\r\n\r\nMỗi học sinh đều có một hồ sơ chi tiết trong hệ thống, nơi bạn có thể xem xét thông tin về thực đơn ưa thích, dị ứng thực phẩm, và bất kỳ yêu cầu dinh dưỡng nào khác. Điều này giúp đảm bảo rằng mọi bữa ăn đều đáp ứng đúng nhu cầu cụ thể của từng học sinh.\r\n\r\n### 5. Bảo Mật và Dữ Liệu An Toàn\r\n\r\nMMC System cam kết bảo vệ an toàn thông tin cá nhân và dữ liệu về dinh dưỡng. Với các biện pháp bảo mật hàng đầu, bạn có thể yên tâm rằng dữ liệu của bạn được bảo vệ chặt chẽ.\r\n\r\nKhám phá MMC System ngay hôm nay để trải nghiệm sự tiện lợi và linh hoạt trong việc quản lý suất ăn bán trú, giúp tăng cường chất lượng cuộc sống học đường và đảm bảo sức khỏe của học sinh.", "https://firebasestorage.googleapis.com/v0/b/mmcsytem.appspot.com/o/images%2Fintro.jpg?alt=media&token=4b9098af-363d-4162-91af-1eeb6e709aaa", "Blog 8" },
                    { 9, new DateTime(2024, 3, 8, 1, 6, 5, 365, DateTimeKind.Local).AddTicks(4507), "Tự động hóa việc quản lý suất ăn bán trú cho trẻ em tiểu học với MMC System\r\n\r\nMMC System là một nền tảng quản lý suất ăn bán trú được thiết kế để giúp các trường tiểu học dễ dàng tổ chức và theo dõi thực đơn, đặt hàng, và ghi nhận thông tin liên quan đến việc cung cấp suất ăn cho học sinh một cách hiệu quả.\r\n\r\n### 1. Tính Tiện Ích và Linh Hoạt\r\n\r\nMMC System mang lại trải nghiệm quản lý linh hoạt và tiện ích cho những người đảm nhận việc quản lý suất ăn bán trú. Với giao diện người dùng thân thiện, bạn có thể dễ dàng xác định các thực đơn, theo dõi số lượng suất ăn, và quản lý thông tin học sinh một cách hiệu quả.\r\n\r\n### 2. Quản Lý Thực Đơn Hiệu Quả\r\n\r\nMMC System cho phép bạn tạo và quản lý các thực đơn dựa trên các yếu tố như chế độ ăn, loại thực phẩm, và các yêu cầu dinh dưỡng. Điều này giúp đảm bảo rằng học sinh nhận được bữa ăn cân đối và phù hợp với nhu cầu dinh dưỡng của họ.\r\n\r\n### 3. Đặt Hàng và Theo Dõi Chi Tiết\r\n\r\nKhông còn phải lo lắng về việc đặt hàng và theo dõi số lượng suất ăn cần chuẩn bị. MMC System cung cấp chức năng đặt hàng tự động dựa trên số lượng học sinh và thực đơn đã chọn. Bạn có thể dễ dàng theo dõi và điều chỉnh đơn đặt hàng của mình thông qua giao diện đơn giản và thuận tiện.\r\n\r\n### 4. Thông Tin Học Sinh Đầy Đủ\r\n\r\nMỗi học sinh đều có một hồ sơ chi tiết trong hệ thống, nơi bạn có thể xem xét thông tin về thực đơn ưa thích, dị ứng thực phẩm, và bất kỳ yêu cầu dinh dưỡng nào khác. Điều này giúp đảm bảo rằng mọi bữa ăn đều đáp ứng đúng nhu cầu cụ thể của từng học sinh.\r\n\r\n### 5. Bảo Mật và Dữ Liệu An Toàn\r\n\r\nMMC System cam kết bảo vệ an toàn thông tin cá nhân và dữ liệu về dinh dưỡng. Với các biện pháp bảo mật hàng đầu, bạn có thể yên tâm rằng dữ liệu của bạn được bảo vệ chặt chẽ.\r\n\r\nKhám phá MMC System ngay hôm nay để trải nghiệm sự tiện lợi và linh hoạt trong việc quản lý suất ăn bán trú, giúp tăng cường chất lượng cuộc sống học đường và đảm bảo sức khỏe của học sinh.", "https://firebasestorage.googleapis.com/v0/b/mmcsytem.appspot.com/o/images%2Fintro.jpg?alt=media&token=4b9098af-363d-4162-91af-1eeb6e709aaa", "Blog 9" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9);

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
    }
}
