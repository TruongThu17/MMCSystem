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
    public class IngredientConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.ToTable(nameof(Ingredient));
            builder.HasKey(x => x.IngredientId);
            builder.Property(x => x.IngredientName).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.DateImport).IsRequired();
            builder.HasOne(x => x.Education).WithMany(x => x.Ingredients).HasForeignKey(x => x.EducationId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
