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
    public class MealTypeConfiguration : IEntityTypeConfiguration<MealType>
    {
        public void Configure(EntityTypeBuilder<MealType> builder)
        {
            builder.ToTable(nameof(MealType));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
        }
    }
}