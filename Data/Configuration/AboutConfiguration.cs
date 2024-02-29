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
    public class AboutConfiguration : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.ToTable(nameof(About));
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Description).IsRequired(false);
            builder.Property(x => x.Img).IsRequired(false);
        }
    }
}