using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class ClassTypeSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public ClassTypeSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<ClassType>().HasData(
                new ClassType()
                {
                    ClassTypeId = 1,
                    ClassTypeName = "Lớp 1"
                },
                new ClassType()
                {
                    ClassTypeId = 2,
                    ClassTypeName = "Lớp 2"
                },
                new ClassType()
                {
                    ClassTypeId = 3,
                    ClassTypeName = "Lớp 3"
                },
                new ClassType()
                {
                    ClassTypeId = 4,
                    ClassTypeName = "Lớp 4"
                },
                new ClassType()
                {
                    ClassTypeId = 5,
                    ClassTypeName = "Lớp 5"
                }
            );
        }
    }
}
