using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int EducationId { get; set; }
        public int ClassTypeId { get; set; }
        public virtual Education? Education { get; set; }
        public virtual ClassType? ClassType { get; set; }
        public virtual ICollection<User>? Users { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
    }
}
