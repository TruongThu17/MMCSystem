using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Dish
    {
        public int DishId { get; set; } 
        public string DishName { get; set; }
        public string? Description { get; set; }
        public string? Nutrition { get; set; }
        public int MealTypeId { get; set; }
        public int? EducationId { get; set; }
        public virtual Education? Education { get; set; }
        public virtual MealType? MealType { get; set; }
        public virtual ICollection<MealPlan>? MealPlans { get; set; }
    }
}
