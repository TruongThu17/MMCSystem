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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable(nameof(Order));
            builder.HasKey(x => x.OrderId);
            builder.Property(x => x.Date).IsRequired();
            builder.Property(x => x.Quantity).IsRequired();
            builder.HasOne(x => x.Class).WithMany(x => x.Orders).HasForeignKey(x => x.ClassId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.MealPlan).WithMany(x => x.Orders).HasForeignKey(x => x.MealPlanId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Education).WithMany(x => x.Orders).HasForeignKey(x => x.EducationId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}