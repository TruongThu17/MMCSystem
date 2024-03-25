using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class MealPlanDetailsSeeder
    {
        private readonly ModelBuilder modelBuilder;
        public MealPlanDetailsSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<MealPlanDetail>().HasData(
                new MealPlanDetail()
                {
                    MealPlanID = 1,
                    DishId = 1,
                    Quantity = 1
                },
                 new MealPlanDetail()
                 {
                     MealPlanID = 4,
                     DishId = 1,
                     Quantity = 1
                 },
                 new MealPlanDetail()
                 {
                     MealPlanID = 7,
                     DishId = 1,
                     Quantity = 1
                 },
                 new MealPlanDetail()
                 {
                     MealPlanID = 10,
                     DishId = 1,
                     Quantity = 1
                 },
                 new MealPlanDetail()
                 {
                     MealPlanID = 13,
                     DishId = 1,
                     Quantity = 1
                 },
                 // lớp 1
                 new MealPlanDetail()
                 {
                     MealPlanID = 2,
                     DishId = 9,
                     Quantity = 1
                 },
                 new MealPlanDetail()
                 {
                     MealPlanID = 2,
                     DishId = 10,
                     Quantity = 1
                 }
                 ,
                 new MealPlanDetail()
                 {
                     MealPlanID = 2,
                     DishId = 13,
                     Quantity = 1
                 },
                 new MealPlanDetail()
                 {
                     MealPlanID = 2,
                     DishId = 28,
                     Quantity = 1
                 },
                 new MealPlanDetail()
                 {
                     MealPlanID = 3,
                     DishId = 34,
                     Quantity = 1
                 }
                 // lớp 2
                 ,
                 new MealPlanDetail()
                 {
                     MealPlanID = 5,
                     DishId = 9,
                     Quantity = 1
                 },
                 new MealPlanDetail()
                 {
                     MealPlanID = 5,
                     DishId = 10,
                     Quantity = 1
                 }
                 ,
                 new MealPlanDetail()
                 {
                     MealPlanID = 5,
                     DishId = 13,
                     Quantity = 1
                 },
                 new MealPlanDetail()
                 {
                     MealPlanID = 5,
                     DishId = 28,
                     Quantity = 1
                 },
                 new MealPlanDetail()
                 {
                     MealPlanID = 6,
                     DishId = 34,
                     Quantity = 1
                 }
                 // lớp 3
                 ,
                 new MealPlanDetail()
                 {
                     MealPlanID = 8,
                     DishId = 9,
                     Quantity = 1
                 },
                 new MealPlanDetail()
                 {
                     MealPlanID =8,
                     DishId = 10,
                     Quantity = 1
                 }
                 ,
                 new MealPlanDetail()
                 {
                     MealPlanID = 8,
                     DishId = 13,
                     Quantity = 1
                 },
                 new MealPlanDetail()
                 {
                     MealPlanID = 8,
                     DishId = 28,
                     Quantity = 1
                 },
                 new MealPlanDetail()
                 {
                     MealPlanID = 9,
                     DishId = 34,
                     Quantity = 1
                 }
                 // lớp 4
                 ,
                 new MealPlanDetail()
                 {
                     MealPlanID = 11,
                     DishId = 9,
                     Quantity = 1
                 },
                 new MealPlanDetail()
                 {
                     MealPlanID = 11,
                     DishId = 10,
                     Quantity = 1
                 }
                 ,
                 new MealPlanDetail()
                 {
                     MealPlanID = 11,
                     DishId = 13,
                     Quantity = 1
                 },
                 new MealPlanDetail()
                 {
                     MealPlanID = 11,
                     DishId = 28,
                     Quantity = 1
                 },
                 new MealPlanDetail()
                 {
                     MealPlanID = 12,
                     DishId = 34,
                     Quantity = 1
                 }//lớp 5
                 ,
                 new MealPlanDetail()
                 {
                     MealPlanID = 14,
                     DishId = 9,
                     Quantity = 1
                 },
                 new MealPlanDetail()
                 {
                     MealPlanID = 14,
                     DishId = 10,
                     Quantity = 1
                 }
                 ,
                 new MealPlanDetail()
                 {
                     MealPlanID = 14,
                     DishId = 13,
                     Quantity = 1
                 },
                 new MealPlanDetail()
                 {
                     MealPlanID = 14,
                     DishId = 28,
                     Quantity = 1
                 },
                 new MealPlanDetail()
                 {
                     MealPlanID = 15,
                     DishId = 34,
                     Quantity = 1
                 }
            );
        }
    }
}
