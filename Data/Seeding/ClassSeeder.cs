using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class ClassSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public ClassSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<Class>().HasData(
                new Class()
                {
                    ClassId = 1,
                    ClassName = "Lớp 1a",
                    ClassTypeId = 1,
                    EducationId = 1
                },
                new Class()
                {
                    ClassId = 2,
                    ClassName = "Lớp 1b",
                    ClassTypeId = 1,
                    EducationId = 1
                },
                new Class()
                {
                    ClassId = 3,
                    ClassName = "Lớp 1c",
                    ClassTypeId = 1,
                    EducationId = 1
                },
                new Class()
                {
                    ClassId = 4,
                    ClassName = "Lớp 2a",
                    ClassTypeId = 2,
                    EducationId = 1
                },
                new Class()
                {
                    ClassId = 5,
                    ClassName = "Lớp 2b",
                    ClassTypeId = 2,
                    EducationId = 1
                },
                new Class()
                {
                    ClassId = 6,
                    ClassName = "Lớp 2c",
                    ClassTypeId = 2,
                    EducationId = 1
                },
                new Class()
                {
                    ClassId = 7,
                    ClassName = "Lớp 3a",
                    ClassTypeId = 3,
                    EducationId = 1
                },
                new Class()
                {
                    ClassId = 8,
                    ClassName = "Lớp 3b",
                    ClassTypeId = 3,
                    EducationId = 1
                },
                new Class()
                {
                    ClassId = 9,
                    ClassName = "Lớp 3c",
                    ClassTypeId = 3,
                    EducationId = 1
                },
                new Class()
                {
                    ClassId = 10,
                    ClassName = "Lớp 4a",
                    ClassTypeId = 4,
                    EducationId = 1
                },
                new Class()
                {
                    ClassId = 11,
                    ClassName = "Lớp 4b",
                    ClassTypeId = 4,
                    EducationId = 1
                },
                new Class()
                {
                    ClassId = 12,
                    ClassName = "Lớp 4c",
                    ClassTypeId = 4,
                    EducationId = 1
                },
                new Class()
                {
                    ClassId = 13,
                    ClassName = "Lớp 5a",
                    ClassTypeId = 5,
                    EducationId = 1
                },
                new Class()
                {
                    ClassId = 14,
                    ClassName = "Lớp 5b",
                    ClassTypeId = 5,
                    EducationId = 1
                },
                new Class()
                {
                    ClassId = 15,
                    ClassName = "Lớp 5c",
                    ClassTypeId = 5,
                    EducationId = 1
                }
            );
        }
    }
}
