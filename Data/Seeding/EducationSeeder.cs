using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class EducationSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public EducationSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<Education>().HasData(
                new Education()
                {
                    Id = 1,
                    Name = "Trường Tiểu học Đống Đa"
                },
                new Education()
                {
                    Id = 2,
                    Name = "Trường Tiểu học Nguyễn Du"
                },
                new Education()
                {
                    Id = 3,
                    Name = "Trường Tiểu học Phan Chu Trinh"
                },
                new Education()
                {
                    Id = 4,
                    Name = "Trường Tiểu học Trần Hưng Đạo "
                },
                new Education()
                {
                    Id = 5,
                    Name = "Trường Tiểu học Lê Lợi"
                }
            );
        }
    }
}
