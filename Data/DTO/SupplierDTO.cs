using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class SupplierDTO
    {
        [DisplayName("Mã đối tác")]
        public int SupplierId { get; set; }
        [DisplayName("Tên đối tác")]
        public string SupplierName { get; set; }
        [DisplayName("Số điện thoại")]
        public string? Phone { get; set; }
        [DisplayName("Địa chỉ email")]
        public string? Email { get; set; }
    }
}
