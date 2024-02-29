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
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.ToTable(nameof(Blog));
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Img).IsRequired(false);
            builder.Property(x => x.Tilte).IsRequired();
            builder.Property(x => x.Date).IsRequired();
        }
    }
}