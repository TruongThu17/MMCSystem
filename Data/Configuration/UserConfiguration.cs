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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));
            builder.Property(x => x.FullName).IsRequired(false);
            builder.Property(x => x.BirthDay).IsRequired(false);
            builder.Property(x => x.Address).IsRequired(false);
            builder.Property(x => x.Phone).IsRequired(false);
            builder.Property(x => x.ParentFullName).IsRequired(false);
            builder.Property(x => x.ParentPhone).IsRequired(false);
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.ClassId).IsRequired(false);
            builder.HasOne(x => x.Class).WithMany(x => x.Users).HasForeignKey(x => x.ClassId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
