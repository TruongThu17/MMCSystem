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
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.ToTable(nameof(Class));
            builder.HasKey(x => x.ClassId);
            builder.Property(x => x.ClassName).IsRequired();
            builder.HasOne(x => x.Education).WithMany(x => x.Classes).HasForeignKey(x => x.EducationId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.ClassType).WithMany(x => x.Classes).HasForeignKey(x => x.ClassTypeId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}