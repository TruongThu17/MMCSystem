using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    // lưu trữ loại bữa ăn như: ăn sáng, ăn trưa , ăn tối
    public class MealType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<MealPlan>? MealPlans { get; set; }
    }
}
