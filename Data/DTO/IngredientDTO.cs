using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class IngredientDTO
    {
        public int IngredientId { get; set; }
        [DisplayName("Tên hàng nhập")]
        public string IngredientName { get; set; }
        [DisplayName("Giá nhập")]
        public decimal Price { get; set; }
        [DisplayName("Tồn")]
        public decimal? UnitInStock { get; set; }
        [DisplayName("Số lượng nhập")]
        public decimal? UnitImport { get; set; }
        [DisplayName("Đơn vị")]
        public string? Unit { get; set; }
        [DisplayName("Ngày nhập")]
        public DateTime DateImport { get; set; }

        public int? SupplierId { get; set; }
        public virtual SupplierDTO? Supplier { get; set; }
    }
}
