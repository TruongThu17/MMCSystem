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
    internal class MealItemsConfiguration : IEntityTypeConfiguration<MealItems>
    {
        public void Configure(EntityTypeBuilder<MealItems> builder)
        {
            builder.ToTable(nameof(MealItems));
            builder.HasKey(x => new { x.MealID, x.DishID });
            builder.HasKey(x => x.DishID);
            builder.Property(x => x.Unit).IsRequired(false);
            builder.Property(x => x.Quantity).IsRequired(false);
            builder.HasOne(x => x.Meals).WithMany(x => x.MealItems).HasForeignKey(x => x.MealID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Menu).WithMany(x => x.MealItems).HasForeignKey(x => x.DishID).OnDelete(DeleteBehavior.NoAction);
        }
    }
}