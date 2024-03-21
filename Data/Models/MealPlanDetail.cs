using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class MealPlanDetail
    {
        public int MealPlanID { get; set; }
        public int DishId { get; set; }
        public decimal? Quantity { get; set; }
        public virtual MealPlan? MealPlan { get; set; }
        public virtual Dish? Dish { get; set; }
    }
}
