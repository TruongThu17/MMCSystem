using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class MealPlan
    {
        public int MealPlanID { get; set; }
        public string? Description { get; set; }
        public string? MealPlanName { get; set; }
        public int ClassTypeId { get; set; }
        public int MealTypeId { get; set; }
        public int? EducationId { get; set; }
        public DateTime? DatePlan { get; set; }
        public virtual Education? Education { get; set; }
        public virtual MealType? MealType { get; set; }
        public virtual ICollection<MealPlanDetail>? MealPlanDetails { get; set; }
        public virtual ClassType? ClassType { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }

    }
}
