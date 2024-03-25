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
    public class MealPlanConfiguration : IEntityTypeConfiguration<MealPlan>
    {
        public void Configure(EntityTypeBuilder<MealPlan> builder)
        {
            builder.ToTable(nameof(MealPlan));
            builder.HasKey(x => x.MealPlanID);
            builder.Property(x => x.Description).IsRequired(false);
            builder.Property(x => x.MealPlanName).IsRequired(false);
            builder.HasOne(x => x.MealType).WithMany(x => x.MealPlans).HasForeignKey(x => x.MealTypeId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.ClassType).WithMany(x => x.MealPlans).HasForeignKey(x => x.MealTypeId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Education).WithMany(x => x.MealPlans).HasForeignKey(x => x.MealTypeId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
