using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class MealTypeSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public MealTypeSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<MealType>().HasData(
                new MealType()
                {
                    Id = 1,
                    Name = "Bữa sáng"
                },
                new MealType()
                {
                    Id = 2,
                    Name = "Bữa trưa"
                },
                new MealType()
                {
                    Id = 3,
                    Name = "Bữa chiều"
                }
            );
        }
    }
}
