using Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    internal class MealTypeDetailsConfiguration : IEntityTypeConfiguration<MealPlanDetail>
    {
        public void Configure(EntityTypeBuilder<MealPlanDetail> builder)
        {
            builder.ToTable(nameof(MealPlanDetail));
            builder.HasKey(x => new { x.MealPlanID, x.DishId});
            builder.Property(x => x.Quantity).IsRequired(false);
            builder.HasOne(x => x.MealPlan).WithMany(x => x.MealPlanDetails).HasForeignKey(x => x.MealPlanID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Dish).WithMany(x => x.MealPlanDetails).HasForeignKey(x => x.DishId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
