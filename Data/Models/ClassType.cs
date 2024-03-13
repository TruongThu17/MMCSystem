using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ClassType
    {
        public int ClassTypeId { get; set; }
        public string ClassTypeName { get; set; }
        public virtual ICollection<Class>? Classes { get; set; }
        public virtual ICollection<MealPlan>? MealPlans { get; set; }
    }
}
