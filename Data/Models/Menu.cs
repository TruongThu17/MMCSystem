using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Menu
    {
        public int DishID { get; set; }
        public string DishName { get; set; }
        // Món chính, Món phụ, Tráng miệng
        public int CategoryId { get; set; }
        public string? Description { get; set; }
        public string? NutritionInformation { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ICollection<MealItems>? MealItems { get; set; }

    }
}
