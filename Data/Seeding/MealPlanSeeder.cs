using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class MealPlanSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public MealPlanSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<MealPlan>().HasData(
                // Lớp 1
                new MealPlan()
                {
                    MealPlanID = 1,
                    MealPlanName = "Kế hoạch ăn uống cho trẻ em lớp 1",
                    Description = "Trẻ em ở độ tuổi lớp 1 cần có một chế độ ăn uống vào buổi sáng cân đối và giàu dinh dưỡng thúc đẩy tăng trưởng chiều cao.",
                    ClassTypeId = 1,
                    MealTypeId = 1, // Bữa sáng

                    EducationId = 1,
                    DatePlan = new DateTime(2024, 3, 22),
                },
                new MealPlan()
                {
                    MealPlanID = 2,
                    MealPlanName = "Kế hoạch ăn uống cho trẻ em lớp 1",
                    Description = "Trẻ em ở độ tuổi lớp 1 cần có một chế độ ăn uống vào buổi trưa hợp lý cân đối và giàu dinh dưỡng.",
                    ClassTypeId = 1,
                    MealTypeId = 2, // Bữa trưa
                    EducationId = 1,
                    DatePlan = new DateTime(2024, 3, 22),
                },
                new MealPlan()
                {
                    MealPlanID = 3,
                    MealPlanName = "Kế hoạch ăn uống cho trẻ em lớp 1",
                    Description = "Thức ăn tráng miệng đầy chất sơ cho trẻ",
                    ClassTypeId = 1,
                    MealTypeId = 3,
                    EducationId = 1,
                    DatePlan = new DateTime(2024, 3, 22),
                },

                // Lớp 2
                new MealPlan()
                {
                    MealPlanID = 4,
                    MealPlanName = "Kế hoạch ăn uống cho trẻ em lớp 2",
                    Description = "Trẻ em lớp 2 cần có bữa sáng cung cấp đủ dinh dưỡng để hỗ trợ sự phát triển và học tập.",
                    ClassTypeId = 2,
                    MealTypeId = 1, // Bữa sáng
                    EducationId = 1,
                    DatePlan = new DateTime(2024, 3, 22),
                },
                new MealPlan()
                {
                    MealPlanID = 5,
                    MealPlanName = "Kế hoạch ăn uống cho trẻ em lớp 2",
                    Description = "Trẻ em lớp 2 cần có bữa trưa cung cấp đủ dinh dưỡng để hỗ trợ sự phát triển và học tập.",
                    ClassTypeId = 2,
                    MealTypeId = 2, // Bữa trưa
                    EducationId = 1,
                    DatePlan = new DateTime(2024, 3, 22),
                },
                new MealPlan()
                {
                    MealPlanID = 6,
                    MealPlanName = "Kế hoạch ăn uống cho trẻ em lớp 2",
                    Description = "Thức ăn tráng miệng đầy chất sơ cho trẻ",
                    ClassTypeId = 2,
                    MealTypeId = 3,
                    EducationId = 1,
                    DatePlan = new DateTime(2024, 3, 22),
                }, new MealPlan()
                {
                    MealPlanID = 7,
                    MealPlanName = "Kế hoạch ăn uống cho trẻ em lớp 3",
                    Description = "Trẻ em lớp 3 cần có bữa tối cung cấp đủ năng lượng và dinh dưỡng để hỗ trợ sự phát triển và hoạt động học tập.",
                    ClassTypeId = 3,
                    MealTypeId = 1, // Bữa sáng
                    EducationId = 1,
                    DatePlan = new DateTime(2024, 3, 22),
                },
                new MealPlan()
                {
                    MealPlanID = 8,
                    MealPlanName = "Kế hoạch ăn uống cho trẻ em lớp 3",
                    Description = "Trẻ em lớp 3 cần có bữa tối cung cấp đủ năng lượng và dinh dưỡng để hỗ trợ sự phát triển và hoạt động học tập.",
                    ClassTypeId = 3,
                    MealTypeId = 2, // Bữa trưa
                    EducationId = 1,
                    DatePlan = new DateTime(2024, 3, 22),
                },
                new MealPlan()
                {
                    MealPlanID = 9,
                    MealPlanName = "Kế hoạch ăn uống cho trẻ em lớp 3",
                    Description = "Thức ăn tráng miệng đầy chất sơ cho trẻ",
                    ClassTypeId = 3,
                    MealTypeId = 3,
                    EducationId = 1,
                    DatePlan = new DateTime(2024, 3, 22),
                }, new MealPlan()
                {
                    MealPlanID = 10,
                    MealPlanName = "Kế hoạch ăn uống cho trẻ em lớp 4",
                    Description = "Trẻ em lớp 4 đang trong giai đoạn phát triển nhanh chóng, cần có bữa sáng cung cấp đủ dinh dưỡng và năng lượng.",
                    ClassTypeId = 4, // Bữa sáng
                    MealTypeId= 1,
                    EducationId = 1,
                    DatePlan = new DateTime(2024, 3, 22),
                },
                new MealPlan()
                {
                    MealPlanID = 11,
                    MealPlanName = "Kế hoạch ăn uống cho trẻ em lớp 4",
                    Description = "Trẻ em lớp 4 đang trong giai đoạn phát triển nhanh chóng, cần có bữa trưa cung cấp đủ dinh dưỡng và năng lượng.",
                    ClassTypeId = 4, 
                    MealTypeId = 2,
                    EducationId = 1,
                    DatePlan = new DateTime(2024, 3, 22),
                },
                new MealPlan()
                {
                    MealPlanID = 12,
                    MealPlanName = "Kế hoạch ăn uống cho trẻ em lớp 4",
                    Description = "Thức ăn tráng miệng đầy chất sơ cho trẻ",
                    ClassTypeId = 4, 
                    EducationId = 1,
                    MealTypeId = 3,
                    DatePlan = new DateTime(2024, 3, 22),
                }, new MealPlan()
                {
                    MealPlanID = 13,
                    MealPlanName = "Kế hoạch ăn uống cho trẻ em lớp 5",
                    Description = "Trẻ em lớp 5 cần có bữa sáng cung cấp chế độ ăn uống cân đối và giàu dinh dưỡng để duy trì sức khỏe và năng lượng suốt cả ngày.",
                    ClassTypeId = 4,
                    MealTypeId = 1,
                    EducationId = 1,
                    DatePlan = new DateTime(2024, 3, 22),
                }, new MealPlan()
                {
                    MealPlanID = 14,
                    MealPlanName = "Kế hoạch ăn uống cho trẻ em lớp 5",
                    Description = "Trẻ em lớp 5 cần có ở bữa trưa cung cấp chế độ ăn uống cân đối và giàu dinh dưỡng để duy trì sức khỏe và năng lượng suốt cả ngày.",
                    ClassTypeId = 4,
                    EducationId = 1,
                    MealTypeId = 2,
                    DatePlan = new DateTime(2024, 3, 22),
                }, new MealPlan()
                {
                    MealPlanID = 15,
                    MealPlanName = "Kế hoạch ăn uống cho trẻ em lớp 5",
                    Description = "Thức ăn tráng miệng đầy chất sơ cho trẻ",
                    ClassTypeId = 4,
                    EducationId = 1,
                    MealTypeId= 3,
                    DatePlan = new DateTime(2024, 3, 22),
                }
            );
        }
    }
}
