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
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable(nameof(Menu));
            builder.HasKey(x => x.DishID);
            builder.Property(x => x.DishName).IsRequired();
            builder.Property(x => x.Description).IsRequired(false);
            builder.Property(x => x.NutritionInformation).IsRequired(false);
            builder.HasOne(x => x.Category).WithMany(x => x.Menus).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}