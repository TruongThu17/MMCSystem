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
                    Id = Guid.Parse("55D0CC53-0678-4604-B3FC-68BCA03A3D44"),
                    UserName = "DongDa",
                    NormalizedUserName = "DONGDA",
                    Email = "DongDa@gmail.com",
                    NormalizedEmail = "DONGDA@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "DongDa@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = true,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    Status = true,
                    EducationId =1
                },
                new User()
                {
                    Id = Guid.Parse("B8DDC2E0-8B14-4C37-869E-7CA5BAD4671A"),
                    UserName = "NguyenDu",
                    NormalizedUserName = "NGUYENDU",
                    Email = "NguyenDu@gmail.com",
                    NormalizedEmail = "NGUYENDU@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "NguyenDu@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = true,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    Status = true,
                    EducationId = 2
                },
                new User()
                {
                    Id = Guid.Parse("C3A4A2EB-1703-4FC5-8511-F68ACDB3A1D9"),
                    UserName = "PhanChuTrinh",
                    NormalizedUserName = "PHANCHUTRINH",
                    Email = "PhanChuTrinh@gmail.com",
                    NormalizedEmail = "PHANCHUTRINH@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "PhanChuTrinh@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = true,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    Status = true,
                    EducationId = 3
                },
                new User()
                {
                    Id = Guid.Parse("E7D19C1E-A674-4D77-978A-47BBACD6910E"),
                    UserName = "TranHungDao",
                    NormalizedUserName = "TRANHUNGDAO",
                    Email = "TranHungDao@gmail.com",
                    NormalizedEmail = "TRANHUNGDAO@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "TranHungDao@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = true,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    Status = true,
                    EducationId = 4
                },
                new User()
                {
                    Id = Guid.Parse("B551FD08-76D9-4040-B0FA-FB2E7AACBE7D"),
                    UserName = "LeLoi",
                    NormalizedUserName = "LELOI",
                    Email = "LeLoi@gmail.com",
                    NormalizedEmail = "LELOI@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "LeLoi@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = true,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    Status = true,
                    EducationId = 5
                });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
               new IdentityUserRole<Guid> { UserId = Guid.Parse("9D9D014C-AF65-447A-A8C0-6475358BFFF9"), RoleId = Guid.Parse("6335DEDA-9F1C-43D4-908F-58073FF07896") },
               new IdentityUserRole<Guid> { UserId = Guid.Parse("55D0CC53-0678-4604-B3FC-68BCA03A3D44"), RoleId = Guid.Parse("30A990C6-33C7-4884-9DCB-718CE356EB0D") },
               new IdentityUserRole<Guid> { UserId = Guid.Parse("B8DDC2E0-8B14-4C37-869E-7CA5BAD4671A"), RoleId = Guid.Parse("30A990C6-33C7-4884-9DCB-718CE356EB0D") },
               new IdentityUserRole<Guid> { UserId = Guid.Parse("C3A4A2EB-1703-4FC5-8511-F68ACDB3A1D9"), RoleId = Guid.Parse("30A990C6-33C7-4884-9DCB-718CE356EB0D") },
               new IdentityUserRole<Guid> { UserId = Guid.Parse("E7D19C1E-A674-4D77-978A-47BBACD6910E"), RoleId = Guid.Parse("30A990C6-33C7-4884-9DCB-718CE356EB0D") },
               new IdentityUserRole<Guid> { UserId = Guid.Parse("B551FD08-76D9-4040-B0FA-FB2E7AACBE7D"), RoleId = Guid.Parse("30A990C6-33C7-4884-9DCB-718CE356EB0D") }
           );
        }
    }
}
