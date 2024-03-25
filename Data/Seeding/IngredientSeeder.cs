using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class IngredientSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public IngredientSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient()
                {
                    IngredientId =1,
                    IngredientName = "Rau cải",
                    DateImport = new DateTime(2024, 3, 21),
                    EducationId = 1,
                    Price = 5000,
                    Unit = "Kg",
                    SupplierId = 1,
                    UnitImport = 10,
                    UnitInStock = 10
                },
                new Ingredient()
                {
                    IngredientId = 2,
                    IngredientName = "Rau bắp cải",
                    DateImport = new DateTime(2024, 3, 21),
                    EducationId = 1,
                    Price = 10000,
                    Unit = "kg",
                    SupplierId = 1,
                    UnitImport = 10,
                    UnitInStock = 10
                },
                new Ingredient()
                {
                    IngredientId = 3,
                    IngredientName = "Đậu phụ",
                    DateImport = new DateTime(2024, 3, 21),
                    EducationId = 1,
                    Price = 5000,
                    Unit = "Miếng",
                    SupplierId = 1,
                    UnitImport = 30,
                    UnitInStock = 30
                },
                new Ingredient()
                {
                    IngredientId = 4,
                    IngredientName = "Thịt lợn",
                    DateImport = new DateTime(2024, 3, 21),
                    EducationId = 1,
                    Price = 100000,
                    Unit = "Kg",
                    SupplierId = 1,
                    UnitImport = 20,
                    UnitInStock = 20
                },
                new Ingredient()
                {
                    IngredientId = 5,
                    IngredientName = "Thịt bò",
                    DateImport = new DateTime(2024, 3, 21),
                    EducationId = 1,
                    Price = 200000,
                    Unit = "Kg",
                    SupplierId = 1,
                    UnitImport = 30,
                    UnitInStock = 30
                }
                ,
                new Ingredient()
                {
                    IngredientId = 6,
                    IngredientName = "Thịt gà",
                    DateImport = new DateTime(2024, 3, 21),
                    EducationId = 1,
                    Price = 100000,
                    Unit = "Kg",
                    SupplierId = 2,
                    UnitImport = 30,
                    UnitInStock = 30
                },
                new Ingredient()
                {
                    IngredientId = 7,
                    IngredientName = "Rau cải",
                    DateImport = new DateTime(2024, 3, 22),
                    EducationId = 1,
                    Price = 5000,
                    Unit = "Kg",
                    SupplierId = 1,
                    UnitImport = 10,
                    UnitInStock = 10
                },
                new Ingredient()
                {
                    IngredientId = 8,
                    IngredientName = "Rau bắp cải",
                    DateImport = new DateTime(2024, 3, 22),
                    EducationId = 1,
                    Price = 10000,
                    Unit = "kg",
                    SupplierId = 1,
                    UnitImport = 10,
                    UnitInStock = 10
                },
                new Ingredient()
                {
                    IngredientId = 9,
                    IngredientName = "Đậu phụ",
                    DateImport = new DateTime(2024, 3, 23),
                    EducationId = 1,
                    Price = 5000,
                    Unit = "Miếng",
                    SupplierId = 1,
                    UnitImport = 30,
                    UnitInStock = 30
                },
                new Ingredient()
                {
                    IngredientId = 10,
                    IngredientName = "Thịt lợn",
                    DateImport = new DateTime(2024, 3, 22),
                    EducationId = 1,
                    Price = 100000,
                    Unit = "Kg",
                    SupplierId = 1,
                    UnitImport = 20,
                    UnitInStock = 20
                },
                new Ingredient()
                {
                    IngredientId = 11,
                    IngredientName = "Thịt bò",
                    DateImport = new DateTime(2024, 3, 23),
                    EducationId = 1,
                    Price = 200000,
                    Unit = "Kg",
                    SupplierId = 1,
                    UnitImport = 30,
                    UnitInStock = 30
                }
                ,
                new Ingredient()
                {
                    IngredientId = 12,
                    IngredientName = "Thịt gà",
                    DateImport = new DateTime(2024, 3, 22),
                    EducationId = 1,
                    Price = 100000,
                    Unit = "Kg",
                    SupplierId = 2,
                    UnitImport = 30,
                    UnitInStock = 30
                }
            );
        }
    }
}
