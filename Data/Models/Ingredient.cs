using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public decimal Price { get; set; }
        public decimal? UnitInStock { get; set; }
        public decimal? UnitImport { get; set; }
        public string? Unit { get; set; }
        public DateTime DateImport { get; set; }
        public int? SupplierId { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public int? EducationId { get; set; }
        public virtual Education? Education { get; set; }
    }
}
