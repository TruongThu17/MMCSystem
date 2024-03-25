using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class MealPLanDTO
    {
        public int MealPlanID { get; set; } 
        [DisplayName("Mô tả kế hoạch")]
        public string? Description { get; set; }
        [DisplayName("Tên kế họach")]
        public string? MealPlanName { get; set; }
        [DisplayName("Loại lớp")]
        public int ClassTypeId { get; set; }
        [DisplayName("Loại bữa ăn")]
        public int MealTypeId { get; set; }
        [DisplayName("Thời gian")]
        public DateTime? DatePlan { get; set; }
        public virtual MealTypeDTO? MealType { get; set; }
        public virtual ICollection<MealPlanDetailDTO>? MealPlanDetails { get; set; }
        public virtual ClassTypeDTO? ClassType { get; set; }
    }
}
