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
                new IdentityRole<Guid>() { Id = Guid.Parse("B8FD818F-63F1-49EE-BEC5-F7B66CAFBFCA"), Name = "Student", NormalizedName = "STUDENT" }
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
                },
                new User()
                {
                    Id = Guid.Parse("7C85649C-2D04-4846-A5F2-212EA550291B"),
                    UserName = "LamntDongDa10001",
                    NormalizedUserName = "LamntDongDa10001",
                    Email = "Lamnt@gmail.com",
                    NormalizedEmail = "LAMNT@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "Lamnt@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = true,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    Status = true,
                    EducationId = 1,
                    ClassId = 1,
                    BirthDay = new DateTime(2018, 3, 21),
                    FullName = "Nguyễn Thành Lâm",
                    PhoneNumber = "0912345678",
                    ParentFullName = "Nguyễn Văn A"
                },
                new User()
                {
                    Id = Guid.Parse("0EE3E5A7-89ED-4BD2-8729-C66311B30033"),
                    UserName = "DuctvDongDa10002",
                    NormalizedUserName = "DuctvDongDa10002",
                    Email = "Ductv@gmail.com",
                    NormalizedEmail = "DUCTV@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "Ductv@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = true,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    Status = true,
                    EducationId = 1,
                    ClassId = 1,
                    BirthDay = new DateTime(2018, 4, 21),
                    FullName = "Trần Văn Đức",
                    PhoneNumber = "0912345679",
                    ParentFullName = "Nguyễn Văn A"
                },
                new User()
                {
                    Id = Guid.Parse("59B4CC83-A2E2-4153-BA43-1D399CFC6B0A"),
                    UserName = "HuynhVu",
                    NormalizedUserName = "HuynhVu",
                    Email = "HuynhVu@gmail.com",
                    NormalizedEmail = "HuynhVu@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "HuynhVu@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = true,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    Status = true,
                    EducationId = 1,
                    ClassId = 1,
                    BirthDay = new DateTime(2018, 4, 21),
                    FullName = "Vũ Văn Huynh",
                    PhoneNumber = "0912345679",
                    ParentFullName = "Nguyễn Văn A"
                },
                new User()
                {
                    Id = Guid.Parse("895DE26A-D181-423E-9CE0-8EFDDFA5562A"),
                    UserName = "PhiNguyen",
                    NormalizedUserName = "PhiNguyen",
                    Email = "PhiNguyen@gmail.com",
                    NormalizedEmail = "PhiNguyen@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "PhiNguyen@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = true,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    Status = true,
                    EducationId = 1,
                    ClassId = 1,
                    BirthDay = new DateTime(2018, 4, 21),
                    FullName = "Nguyễn Quốc Phi",
                    PhoneNumber = "0912345679",
                    ParentFullName = "Nguyễn Văn A"
                },
                new User()
                {
                    Id = Guid.Parse("1B2B8425-274B-4444-93C6-44536E2AAF2D"),
                    UserName = "MaiVu",
                    NormalizedUserName = "MaiVu",
                    Email = "MaiVu@gmail.com",
                    NormalizedEmail = "MaiVu@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "MaiVu@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = true,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    Status = true,
                    EducationId = 1,
                    ClassId = 1,
                    BirthDay = new DateTime(2018, 4, 21),
                    FullName = "Vũ Thị Mai",
                    PhoneNumber = "0912345679",
                    ParentFullName = "Nguyễn Văn A"
                },
                new User()
                {
                    Id = Guid.Parse("1E7F04A2-E884-469D-BA8D-421D45EE1B79"),
                    UserName = "QuynhVu",
                    NormalizedUserName = "QuynhVu",
                    Email = "QuynhVu@gmail.com",
                    NormalizedEmail = "QuynhVu@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "QuynhVu@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = true,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    Status = true,
                    EducationId = 1,
                    ClassId = 1,
                    BirthDay = new DateTime(2018, 4, 21),
                    FullName = "Vũ Thị Quỳnh",
                    PhoneNumber = "0912345679",
                    ParentFullName = "Nguyễn Văn A"
                }); 
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
               new IdentityUserRole<Guid> { UserId = Guid.Parse("9D9D014C-AF65-447A-A8C0-6475358BFFF9"), RoleId = Guid.Parse("6335DEDA-9F1C-43D4-908F-58073FF07896") },
               new IdentityUserRole<Guid> { UserId = Guid.Parse("55D0CC53-0678-4604-B3FC-68BCA03A3D44"), RoleId = Guid.Parse("30A990C6-33C7-4884-9DCB-718CE356EB0D") },
               new IdentityUserRole<Guid> { UserId = Guid.Parse("B8DDC2E0-8B14-4C37-869E-7CA5BAD4671A"), RoleId = Guid.Parse("30A990C6-33C7-4884-9DCB-718CE356EB0D") },
               new IdentityUserRole<Guid> { UserId = Guid.Parse("C3A4A2EB-1703-4FC5-8511-F68ACDB3A1D9"), RoleId = Guid.Parse("30A990C6-33C7-4884-9DCB-718CE356EB0D") },
               new IdentityUserRole<Guid> { UserId = Guid.Parse("E7D19C1E-A674-4D77-978A-47BBACD6910E"), RoleId = Guid.Parse("30A990C6-33C7-4884-9DCB-718CE356EB0D") },
               new IdentityUserRole<Guid> { UserId = Guid.Parse("B551FD08-76D9-4040-B0FA-FB2E7AACBE7D"), RoleId = Guid.Parse("30A990C6-33C7-4884-9DCB-718CE356EB0D") },
               new IdentityUserRole<Guid> { UserId = Guid.Parse("7C85649C-2D04-4846-A5F2-212EA550291B"), RoleId = Guid.Parse("B8FD818F-63F1-49EE-BEC5-F7B66CAFBFCA") },
               new IdentityUserRole<Guid> { UserId = Guid.Parse("0EE3E5A7-89ED-4BD2-8729-C66311B30033"), RoleId = Guid.Parse("B8FD818F-63F1-49EE-BEC5-F7B66CAFBFCA") },
               new IdentityUserRole<Guid> { UserId = Guid.Parse("1E7F04A2-E884-469D-BA8D-421D45EE1B79"), RoleId = Guid.Parse("B8FD818F-63F1-49EE-BEC5-F7B66CAFBFCA") },
               new IdentityUserRole<Guid> { UserId = Guid.Parse("1B2B8425-274B-4444-93C6-44536E2AAF2D"), RoleId = Guid.Parse("B8FD818F-63F1-49EE-BEC5-F7B66CAFBFCA") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("895DE26A-D181-423E-9CE0-8EFDDFA5562A"), RoleId = Guid.Parse("B8FD818F-63F1-49EE-BEC5-F7B66CAFBFCA") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("59B4CC83-A2E2-4153-BA43-1D399CFC6B0A"), RoleId = Guid.Parse("B8FD818F-63F1-49EE-BEC5-F7B66CAFBFCA") }
           );
        }
    }
}
