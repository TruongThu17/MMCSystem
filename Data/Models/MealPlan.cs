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
        public virtual MealType? MealType { get; set; }

        public virtual ClassType? ClassType { get; set; }

    }
}
