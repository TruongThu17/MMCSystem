using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Class>? Classes { get; set; }
        public virtual ICollection<MealType>? MealTypes { get; set; }
        public virtual ICollection<Dish>? Dishs { get; set; }
        public virtual ICollection<User>? Users { get; set; }
        public virtual ICollection<MealPlan>? MealPlans { get; set; }
        public virtual ICollection<Supplier>? Suppliers { get; set; }
        public virtual ICollection<Ingredient>? Ingredients { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
    }
}
