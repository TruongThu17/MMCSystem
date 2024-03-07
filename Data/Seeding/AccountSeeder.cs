using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class AccountSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public AccountSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<IdentityRole<Guid>>().HasData(
                 new IdentityRole<Guid>() { Id = Guid.Parse("6335DEDA-9F1C-43D4-908F-58073FF07896"), Name = "SuperAdmin", NormalizedName = "SUPERADMIN" },
                new IdentityRole<Guid>() { Id = Guid.Parse("30A990C6-33C7-4884-9DCB-718CE356EB0D"), Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole<Guid>() { Id = Guid.Parse("B8FD818F-63F1-49EE-BEC5-F7B66CAFBFCA"), Name = "Staff", NormalizedName = "STAFF" },
                new IdentityRole<Guid>() { Id = Guid.Parse("FE0E9C2D-6ABD-4F73-A635-63FC58EC700E"), Name = "Parent", NormalizedName = "PARENT" }
            );
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = Guid.Parse("9D9D014C-AF65-447A-A8C0-6475358BFFF9"),
                    UserName = "SuperAdmin",
                    NormalizedUserName = "SUPERADMIN",
                    Email = "superadmin@gmail.com",
                    NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "SuperAdmin@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = true,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    Status = true,
                },
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
        }
    }
}
