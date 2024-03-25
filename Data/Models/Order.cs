using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int MealPlanId { get; set; }
        public int ClassId { get; set; }
        public DateTime Date { get; set; }
        public string? Note { get; set; }
        public int Quantity { get; set; }
        public int EducationId { get; set; }
        public virtual Education? Education { get; set; }
        public virtual Class? Class { get; set; }
        public virtual MealPlan? MealPlan { get; set; }
    }
}
