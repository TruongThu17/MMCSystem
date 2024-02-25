using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    // lưu trữ loại món ăn: Món chính, Món phụ, Tráng miệng
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Menu>? Menus { get; set; }
    }
}
