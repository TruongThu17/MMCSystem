using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class AboutSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public AboutSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<About>().HasData(
                new About() {
                    ID=1, 
                    Img= "https://firebasestorage.googleapis.com/v0/b/mmcsytem.appspot.com/o/about%2F65d281d1-f625-4a1c-ba4d-dea4987aa274.jpg?alt=media",
                    Description= "Chào mừng đến với trang web quản lý suất ăn bán trú dành cho trẻ em tiểu học - MMC System!\r\n\r\n## Giới Thiệu\r\n\r\nMMC System là một hệ thống quản lý suất ăn chuyên nghiệp, thiết kế đặc biệt để đáp ứng nhu cầu dinh dưỡng của các em học sinh tiểu học. Chúng tôi cam kết mang đến trải nghiệm an toàn, tiện lợi và đảm bảo chất lượng cho cả học sinh, phụ huynh và nhà trường.\r\n\r\n## Đặc Điểm Nổi Bật\r\n\r\n### 1. **Dinh Dưỡng Đa Dạng**\r\n   Chúng tôi chú trọng đến việc cung cấp các bữa ăn đa dạng, cân đối và phù hợp với lứa tuổi của học sinh tiểu học. Thực đơn được thiết kế theo chuẩn dinh dưỡng, giúp trẻ phát triển toàn diện.\r\n\r\n### 2. **Quản Lý Thuận Tiện**\r\n   MMC System giúp phụ huynh và nhà trường dễ dàng quản lý thông tin về suất ăn, theo dõi chất lượng bữa ăn, và đặt lịch trực tuyến một cách thuận tiện.\r\n\r\n### 3. **An Toàn và Nhanh Chóng**\r\n   Đội ngũ chuyên gia chế biến thực phẩm của chúng tôi tuân thủ nghiêm ngặt các tiêu chuẩn vệ sinh và an toàn thực phẩm, đảm bảo rằng mỗi bữa ăn đều đạt chuẩn chất lượng cao.\r\n\r\n### 4. **Hỗ Trợ Tận Tâm**\r\n   Chúng tôi luôn lắng nghe và hỗ trợ mọi nhu cầu của phụ huynh và nhà trường. Đội ngũ hỗ trợ của chúng tôi sẽ luôn sẵn lòng giải đáp mọi thắc mắc và đảm bảo sự hài lòng của quý vị.\r\n\r\n## Hãy Đăng Ký Ngay!\r\n\r\nHãy đồng hành cùng MMC System để đảm bảo chất lượng dinh dưỡng và sức khỏe cho tương lai của con em chúng ta. Đăng ký ngay để trải nghiệm sự thuận tiện và chất lượng từ dịch vụ của chúng tôi!\r\n\r\nCảm ơn bạn đã ghé thăm MMC System!"
                }
            );
        }

     }
}
