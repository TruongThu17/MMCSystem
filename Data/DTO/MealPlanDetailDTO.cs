using Data.Models;
using System.ComponentModel;

namespace Data.DTO
{
    public class MealPlanDetailDTO
    {
        public int MealPlanID { get; set; }
        public int DishId { get; set; }
        [DisplayName("Số lượng")]
        public decimal? Quantity { get; set; }
        public virtual DishDTO? Dish { get; set; }
    }
}