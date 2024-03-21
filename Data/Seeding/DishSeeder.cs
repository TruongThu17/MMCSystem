using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class DishSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public DishSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<Dish>().HasData(
                new Dish()
                {
                    DishId = 1,
                    DishName = "Bánh mì xúc xích",
                    Description = "Bánh mì với xúc xích và sốt cà chua",
                    Nutrition = "Calo: 300, Protein: 12g, Chất béo: 8g, Carbohydrate: 35g",
                    MealTypeId = 1,
                    EducationId = 1,
                },
                new Dish()
                {
                    DishId = 2,
                    DishName = "Cháo gà",
                    Description = "Cháo gà với gà và gạo nấu mềm",
                    Nutrition = "Calo: 200, Protein: 10g, Chất béo: 5g, Carbohydrate: 25g",
                    MealTypeId = 1,
                    EducationId = 1,
                }
                ,
                new Dish()
                {
                    DishId = 3,
                    DishName = "Bánh bao 2 trứng",
                    Description = "Bánh bao nhân thịt xay và trứng cút",
                    Nutrition = "Calo: 250, Protein: 8g, Chất béo: 6g, Carbohydrate: 30g",
                    MealTypeId = 1,
                    EducationId = 1,
                },
                new Dish()
                {
                    DishId = 4,
                    DishName = "Bánh bao phô mai",
                    Description = "Bánh bao nhân phô mai mềm mịn",
                    Nutrition = "Calo: 280, Protein: 7g, Chất béo: 12g, Carbohydrate: 35g",
                    MealTypeId = 1,
                    EducationId = 1,
                },
                new Dish()
                {
                    DishId = 5,
                    DishName = "Bánh bao xá xíu",
                    Description = "Bánh bao nhân xá xíu thơm ngon",
                    Nutrition = "Calo: 300, Protein: 10g, Chất béo: 15g, Carbohydrate: 25g",
                    MealTypeId = 1,
                    EducationId = 1,
                },
                new Dish()
                {
                    DishId = 6,
                    DishName = "Cháo thịt băm",
                    Description = "Cháo gạo nấu mềm với thịt băm nhỏ",
                    Nutrition = "Calo: 220, Protein: 12g, Chất béo: 8g, Carbohydrate: 30g",
                    MealTypeId = 1,
                    EducationId = 1,
                },
                new Dish()
                {
                    DishId = 7,
                    DishName = "Cháo dinh dưỡng",
                    Description = "Cháo gạo nấu mềm, giàu chất dinh dưỡng",
                    Nutrition = "Calo: 180, Protein: 6g, Chất béo: 5g, Carbohydrate: 25g",
                    MealTypeId = 1,
                    EducationId = 1,
                },
                new Dish()
                {
                    DishId = 8,
                    DishName = "Bánh mì pate",
                    Description = "Bánh mì pate, trứng, xúc xích",
                    Nutrition = "Calo: 300, Protein: 12g, Chất béo: 8g, Carbohydrate: 35g",
                    MealTypeId = 1,
                    EducationId = 1,
                },
                new Dish()
                {
                    DishId = 9,
                    DishName = "Thịt Băm Xào Rau Cải",
                    Description = "Thịt băm xào với rau cải tươi ngon",
                    Nutrition = "Calo: 300, Protein: 20g, Chất béo: 15g, Carbohydrate: 25g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish()
                {
                    DishId = 10,
                    DishName = "Thịt Xốt Cà Chua",
                    Description = "Thịt xắt lát kèm sốt cà chua",
                    Nutrition = "Calo: 350, Protein: 25g, Chất béo: 18g, Carbohydrate: 20g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish()
                {
                    DishId = 11,
                    DishName = "Thịt Rang",
                    Description = "Thịt heo rang cháy cạnh",
                    Nutrition = "Calo: 400, Protein: 30g, Chất béo: 25g, Carbohydrate: 10g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish()
                {
                    DishId = 12,
                    DishName = "Gà Rang Muối",
                    Description = "Gà chiên giòn với muối và tiêu",
                    Nutrition = "Calo: 380, Protein: 28g, Chất béo: 20g, Carbohydrate: 15g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish()
                {
                    DishId = 13,
                    DishName = "Cá Kho Tộ",
                    Description = "Cá kho tộ kho với sốt nước mắm",
                    Nutrition = "Calo: 350, Protein: 25g, Chất béo: 15g, Carbohydrate: 20g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 14,
                    DishName = "Thịt Kho Dừa",
                    Description = "Thịt kho dừa nấu chín mềm",
                    Nutrition = "Calo: 300, Protein: 20g, Chất béo: 15g, Carbohydrate: 25g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 15,
                    DishName = "Thịt Kho Trứng",
                    Description = "Thịt kho với trứng cút nấu chín",
                    Nutrition = "Calo: 280, Protein: 18g, Chất béo: 12g, Carbohydrate: 20g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 16,
                    DishName = "Trứng Chiên",
                    Description = "Trứng gà chiên giòn",
                    Nutrition = "Calo: 180, Protein: 10g, Chất béo: 12g, Carbohydrate: 5g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 17,
                    DishName = "Trứng Luộc",
                    Description = "Trứng gà luộc vừa chín",
                    Nutrition = "Calo: 70, Protein: 6g, Chất béo: 5g, Carbohydrate: 1g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 18,
                    DishName = "Xúc Xích Chiên",
                    Description = "Xúc xích chiên giòn",
                    Nutrition = "Calo: 250, Protein: 8g, Chất béo: 20g, Carbohydrate: 10g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 19,
                    DishName = "Thịt Băm Xào Rau Củ",
                    Description = "Thịt băm xào với rau củ tươi ngon",
                    Nutrition = "Calo: 250, Protein: 15g, Chất béo: 10g, Carbohydrate: 20g",
                    MealTypeId = 2,
                    EducationId = 1,
                },new Dish
                {
                    DishId = 20,
                    DishName = "Cá Chiên Xù",
                    Description = "Cá chiên xù giòn rụm",
                    Nutrition = "Calo: 200, Protein: 15g, Chất béo: 12g, Carbohydrate: 5g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 21,
                    DishName = "Cá Hấp",
                    Description = "Cá hấp nhẹ nhàng với gia vị tự nhiên",
                    Nutrition = "Calo: 150, Protein: 20g, Chất béo: 5g, Carbohydrate: 2g",
                    MealTypeId = 2 ,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 22,
                    DishName = "Thịt Bò Xào Rau Cải",
                    Description = "Thịt bò xào với rau cải tươi ngon",
                    Nutrition = "Calo: 280, Protein: 25g, Chất béo: 15g, Carbohydrate: 10g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 23,
                    DishName = "Thịt Bò Xào Rau Rút",
                    Description = "Thịt bò xào với rau rút tươi ngon",
                    Nutrition = "Calo: 270, Protein: 23g, Chất béo: 14g, Carbohydrate: 12g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 24,
                    DishName = "Gà Chiên Giòn",
                    Description = "Gà chiên giòn ngoài, mềm trong",
                    Nutrition = "Calo: 280, Protein: 20g, Chất béo: 18g, Carbohydrate: 10g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 25,
                    DishName = "Gà Xào Ớt Sừng",
                    Description = "Thịt gà xào cùng ớt sừng và gia vị",
                    Nutrition = "Calo: 300, Protein: 22g, Chất béo: 15g, Carbohydrate: 10g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 26,
                    DishName = "Gà Xào Hành",
                    Description = "Thịt gà xào cùng hành và các loại gia vị",
                    Nutrition = "Calo: 290, Protein: 24g, Chất béo: 16g, Carbohydrate: 8g",
                    MealTypeId = 2,
                    EducationId = 1,
                }, new Dish
                {
                    DishId = 27,
                    DishName = "Gà Xào Gừng",
                    Description = "Thịt gà xào cùng gừng và các loại gia vị",
                    Nutrition = "Calo: 280, Protein: 23g, Chất béo: 15g, Carbohydrate: 10g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 28,
                    DishName = "Cải Bắp Xào",
                    Description = "Cải bắp xào với tỏi và dầu ăn",
                    Nutrition = "Calo: 70, Protein: 4g, Chất béo: 3g, Carbohydrate: 10g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 29,
                    DishName = "Rau Muống Xào",
                    Description = "Rau muống xào với tỏi và dầu ăn",
                    Nutrition = "Calo: 60, Protein: 3g, Chất béo: 2g, Carbohydrate: 8g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 30,
                    DishName = "Rau Lang Luộc",
                    Description = "Rau lang luộc với nước mắm pha",
                    Nutrition = "Calo: 40, Protein: 2g, Chất béo: 1g, Carbohydrate: 6g",
                    MealTypeId = 2,
                    EducationId = 1,
                },new Dish
                {
                    DishId = 31,
                    DishName = "Canh Cải Bắp",
                    Description = "Canh cải bắp nấu với thịt heo và nước dừa",
                    Nutrition = "Calo: 80, Protein: 5g, Chất béo: 4g, Carbohydrate: 10g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 32,
                    DishName = "Canh Rau Cải",
                    Description = "Canh rau cải nấu với tôm và hành",
                    Nutrition = "Calo: 70, Protein: 4g, Chất béo: 3g, Carbohydrate: 8g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 33,
                    DishName = "Canh Đậu Hủ",
                    Description = "Canh đậu hủ nấu với nấm và hành",
                    Nutrition = "Calo: 60, Protein: 5g, Chất béo: 2g, Carbohydrate: 6g",
                    MealTypeId = 2,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 34,
                    DishName = "Xoài",
                    Description = "Xoài chín ngọt, 50g",
                    Nutrition = "Calo: 110, Carbohydrate: 30g",
                    MealTypeId = 3,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 35,
                    DishName = "Dưa Hấu",
                    Description = "Dưa hấu tươi mát, 50g",
                    Nutrition = "Calo: 95, Carbohydrate: 25g",
                    MealTypeId = 3,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 36,
                    DishName = "Chuối",
                    Description = "Chuối chín mọng, 50g",
                    Nutrition = "Calo: 140, Carbohydrate: 38g",
                    MealTypeId = 3,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 37,
                    DishName = "Cam",
                    Description = "Cam chín mọng, 50g",
                    Nutrition = "Calo: 60, Carbohydrate: 15g",
                    MealTypeId = 3,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 38,
                    DishName = "Nho",
                    Description = "Nho tươi mát, 50g",
                    Nutrition = "Calo: 40, Carbohydrate: 10g",
                    MealTypeId = 3,
                    EducationId = 1,
                },
                new Dish
                {
                    DishId = 39,
                    DishName = "Lê",
                    Description = "Lê chín mềm, 50g",
                    Nutrition = "Calo: 30, Carbohydrate: 8g",
                    MealTypeId = 3,
                    EducationId = 1,
                }
            );
        }
    }
}
