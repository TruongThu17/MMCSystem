using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Meals
    {
        public int MealID { get; set; }
        public DateTime Date { get; set; }
        public int MealTypeId { get; set; }
        public virtual MealType? MealType { get; set; }
        public virtual ICollection<MealItems>? MealItems { get; set; }
    }
}
