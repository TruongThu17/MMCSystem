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
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.ToTable(nameof(Supplier));
            builder.HasKey(x => x.SupplierId);
            builder.Property(x => x.SupplierName).IsRequired();
            builder.HasOne(x => x.Education).WithMany(x => x.Suppliers).HasForeignKey(x => x.EducationId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}