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
    public class MealsConfiguration : IEntityTypeConfiguration<Meals>
    {
        public void Configure(EntityTypeBuilder<Meals> builder)
        {
            builder.ToTable(nameof(Meals));
            builder.HasKey(x => x.MealID);
            builder.Property(x => x.Date).IsRequired();
            builder.Property(x => x.MealTypeId).IsRequired();
            builder.HasOne(x => x.MealType).WithMany(x => x.Meals).HasForeignKey(x => x.MealTypeId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
