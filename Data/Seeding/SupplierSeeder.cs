using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class SupplierSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public SupplierSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier
                {
                    SupplierId = 1,
                    SupplierName = "Công ty Thực phẩm Sạch",
                    Email = "info@thucphamsach.com",
                    Phone = "0987654321",
                    EducationId = 1
                },
                new Supplier
                {
                    SupplierId = 2,
                    SupplierName = "Nhà cung cấp Nguyên liệu Xanh",
                    Email = "nguyenlieuxanh@gmail.com",
                    Phone = "0912345678",
                    EducationId = 1
                },
                new Supplier
                {
                    SupplierId = 3,
                    SupplierName = "Công ty Thực phẩm Hữu cơ",
                    Email = "info@thucphamhuuco.com",
                    Phone = "0909090909",
                    EducationId = 1
                },
                new Supplier
                {
                    SupplierId = 4,
                    SupplierName = "Công ty Thực phẩm Hải sản tươi",
                    Email = "info@thucphamhaisan.com",
                    Phone = "0977123456",
                    EducationId = 1
                },
                new Supplier
                {
                    SupplierId = 5,
                    SupplierName = "Nhà cung cấp Rau sạch Organic",
                    Email = "rausachorganic@gmail.com",
                    Phone = "0967123456",
                    EducationId = 1
                },
                new Supplier
                {
                    SupplierId = 6,
                    SupplierName = "Công ty Thực phẩm Chay",
                    Email = "info@thucphamchay.com",
                    Phone = "0968123456",
                    EducationId = 1
                },
                new Supplier
                {
                    SupplierId = 7,
                    SupplierName = "Nhà cung cấp Thịt bò sạch",
                    Email = "thitbosach@gmail.com",
                    Phone = "0969123456",
                    EducationId = 1
                },
                new Supplier
                {
                    SupplierId = 8,
                    SupplierName = "Công ty Thực phẩm Trái cây tươi",
                    Email = "info@thucphamtraicay.com",
                    Phone = "0970123456",
                    EducationId = 1
                },
                new Supplier
                {
                    SupplierId = 9,
                    SupplierName = "Công ty Thực phẩm Nước giải khát",
                    Email = "info@thucphamnuocgiakhat.com",
                    Phone = "0981123456",
                    EducationId = 1
                },
                new Supplier
                {
                    SupplierId = 10,
                    SupplierName = "Nhà cung cấp Hạt giống Organic",
                    Email = "hatgiomgorganic@gmail.com",
                    Phone = "0964123456",
                    EducationId = 1
                },
                new Supplier
                {
                    SupplierId = 11,
                    SupplierName = "Cửa hàng Thực phẩm Đông lạnh",
                    Email = "thucphamdonglanh@gmail.com",
                    Phone = "0965123456",
                    EducationId = 1
                },
                new Supplier
                {
                    SupplierId = 12,
                    SupplierName = "Nhà cung cấp Thực phẩm Dinh dưỡng",
                    Email = "thucphamdinhdưỡng@gmail.com",
                    Phone = "0966123456",
                    EducationId = 1
                },
                new Supplier
                {
                    SupplierId = 13,
                    SupplierName = "Công ty Thực phẩm Cao cấp",
                    Email = "info@thucphamcaocap.com",
                    Phone = "0962123456",
                    EducationId = 1
                }
            );
        }
    }
}
