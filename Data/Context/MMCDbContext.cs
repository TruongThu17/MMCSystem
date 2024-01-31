using Data.Configuration;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class MMCDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public MMCDbContext(DbContextOptions options) : base(options)
        {
        }

        public MMCDbContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                                 .SetBasePath(Directory.GetCurrentDirectory())
                                 .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                IConfigurationRoot configuration = builder.Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("MMCSystem"));
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.Entity<IdentityRole<Guid>>().HasData(
               new IdentityRole<Guid>() { Id = Guid.Parse("30A990C6-33C7-4884-9DCB-718CE356EB0D"), Name = "Admin", NormalizedName = "ADMIN" },
               new IdentityRole<Guid>() { Id = Guid.Parse("B8FD818F-63F1-49EE-BEC5-F7B66CAFBFCA"), Name = "Manage", NormalizedName = "MANAGE" },
               new IdentityRole<Guid>() { Id = Guid.Parse("FE0E9C2D-6ABD-4F73-A635-63FC58EC700E"), Name = "Cashier", NormalizedName = "CASHIER" }
           );
            builder.Entity<User>().HasData(
                new User()
                {
                    Id = Guid.Parse("30A990C6-33C7-4884-9DCB-718CE356EB0D"),
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "Admin@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = true,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    Status = true,
                });
            base.OnModelCreating(builder);
        }
        #region
        public virtual DbSet<User> Users { get; set; }
        #endregion
    }
}
