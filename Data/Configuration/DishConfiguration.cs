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
    public class DishConfiguration : IEntityTypeConfiguration<Dish>
    {
        public void Configure(EntityTypeBuilder<Dish> builder)
        {
            builder.ToTable(nameof(Dish));
            builder.HasKey(x => x.DishId);
            builder.Property(x => x.Description).IsRequired(false);
            builder.Property(x => x.DishName).IsRequired();
            builder.HasOne(x => x.MealType).WithMany(x => x.Dishs).HasForeignKey(x => x.MealTypeId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Education).WithMany(x => x.Dishs).HasForeignKey(x => x.EducationId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}