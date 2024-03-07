using Data.Configuration;
using Data.Models;
using Data.Seeding;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
            builder.ApplyConfiguration(new ClassConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new MenuConfiguration());
            builder.ApplyConfiguration(new MealTypeConfiguration());
            builder.ApplyConfiguration(new MealsConfiguration());
            builder.ApplyConfiguration(new MealItemsConfiguration());
            builder.ApplyConfiguration(new AboutConfiguration());
            builder.ApplyConfiguration(new BlogConfiguration());
            builder.ApplyConfiguration(new EducationConfiguration());

            new AccountSeeder(builder).Seed();
            new AboutSeeder(builder).Seed();
            new BlogSeeder(builder).Seed();
            base.OnModelCreating(builder);
        }
        #region
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MealType> MealTypes { get; set; }
        public virtual DbSet<Meals> Meals { get; set; }
        public virtual DbSet<MealItems> MealItems { get; set; }
        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        #endregion
    }
}
