using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public int? EducationId { get; set; }
        public virtual Education? Education { get; set; }
        public virtual ICollection<Ingredient>? Ingredients { get; set; }
    }
}
