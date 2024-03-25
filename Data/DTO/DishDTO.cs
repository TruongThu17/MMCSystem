using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class DishDTO
    {
        [DisplayName("Mã món")]
        public int DishId { get; set; }
        [DisplayName("Tên món")] 
        public string DishName { get; set; }
        [DisplayName("Mô tả")]
        public string? Description { get; set; }
        [DisplayName("Dinh dưỡng")]
        public string? Nutrition { get; set; }
        [DisplayName("Loại món")]
        public int MealTypeId { get; set; }
        public int? EducationId { get; set; }
        public virtual MealTypeDTO? MealType { get; set; }
    }
}
