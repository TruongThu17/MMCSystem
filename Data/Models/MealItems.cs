using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class MealItems
    {
        public int MealID { get; set; }
        public int DishID { get; set; }
        public int? Quantity { get; set; }
        public string? Unit { get; set; }
        public virtual Menu? Menu { get; set; }
        public virtual Meals? Meals { get; set; }
    }
}
