using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class OrderSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public OrderSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    OrderId =1,
                    MealPlanId =1,
                    ClassId = 1,
                    Date = new DateTime(2024, 3, 25),
                    Note = "",
                    EducationId = 1,
                    Quantity =30
                },
                new Order
                {
                    OrderId = 2,
                    MealPlanId = 1,
                    ClassId = 2,
                    Date = new DateTime(2024, 3, 25),
                    Note = "",
                    EducationId = 1,
                    Quantity = 30
                },
                new Order
                {
                    OrderId = 3,
                    MealPlanId = 1,
                    ClassId = 3,
                    Date = new DateTime(2024, 3, 25),
                    Note = "",
                    EducationId = 1,
                    Quantity = 30
                },
                new Order
                {
                    OrderId = 4,
                    MealPlanId = 2,
                    ClassId = 4,
                    Date = new DateTime(2024, 3, 25),
                    Note = "",
                    EducationId = 1,
                    Quantity = 30
                }, new Order
                {
                    OrderId = 5,
                    MealPlanId = 2,
                    ClassId = 5,
                    Date = new DateTime(2024, 3, 25),
                    Note = "",
                    EducationId = 1,
                    Quantity = 30
                }, new Order
                {
                    OrderId = 6,
                    MealPlanId = 2,
                    ClassId = 6,
                    Date = new DateTime(2024, 3, 25),
                    Note = "",
                    EducationId = 1,
                    Quantity = 30
                }, new Order
                {
                    OrderId = 7,
                    MealPlanId = 3,
                    ClassId = 7,
                    Date = new DateTime(2024, 3, 25),
                    Note = "",
                    EducationId = 1,
                    Quantity = 30
                }
                , new Order
                {
                    OrderId = 8,
                    MealPlanId = 3,
                    ClassId = 8,
                    Date = new DateTime(2024, 3, 25),
                    Note = "",
                    EducationId = 1,
                    Quantity = 30
                }
                , new Order
                {
                    OrderId = 9,
                    MealPlanId = 3,
                    ClassId = 9,
                    Date = new DateTime(2024, 3, 25),
                    Note = "",
                    EducationId = 1,
                    Quantity = 30
                }, new Order
                {
                    OrderId = 10,
                    MealPlanId = 4,
                    ClassId = 10,
                    Date = new DateTime(2024, 3, 25),
                    Note = "",
                    EducationId = 1,
                    Quantity = 30
                }, new Order
                {
                    OrderId = 11,
                    MealPlanId = 4,
                    ClassId = 11,
                    Date = new DateTime(2024, 3, 25),
                    Note = "",
                    EducationId = 1,
                    Quantity = 30
                }, new Order
                {
                    OrderId = 12,
                    MealPlanId = 4,
                    ClassId = 12,
                    Date = new DateTime(2024, 3, 25),
                    Note = "",
                    EducationId = 1,
                    Quantity = 30
                }, new Order
                {
                    OrderId = 13,
                    MealPlanId = 5,
                    ClassId = 6,
                    Date = new DateTime(2024, 3, 25),
                    Note = "",
                    EducationId = 1,
                    Quantity = 30
                }, new Order
                {
                    OrderId = 14,
                    MealPlanId = 5,
                    ClassId = 14,
                    Date = new DateTime(2024, 3, 25),
                    Note = "",
                    EducationId = 1,
                    Quantity = 30
                }, new Order
                {
                    OrderId = 15,
                    MealPlanId = 5,
                    ClassId = 15,
                    Date = new DateTime(2024, 3, 25),
                    Note = "",
                    EducationId = 1,
                    Quantity = 30
                }
            );
        }
    }
}
