using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class OrderDTO 
    {
        public int OrderId { get; set; }
        public int MealPlanId { get; set; }
        public int ClassId { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public string? Note { get; set; }
        public virtual ClassDTO? Class { get; set; }
        public virtual MealPLanDTO? MealPlan { get; set; }
    }
}
