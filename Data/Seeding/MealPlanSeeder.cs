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
                new MealPlan()
                {
                    //MealTypeId =1,
                    //Description = "",

                    //Name = "Bữa sáng"
                }
            );
        }
    }
}
