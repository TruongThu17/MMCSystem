using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class ClassDTO
    {

        public int ClassId { get; set; }
        [DisplayName("Tên lớp")]
        public string ClassName { get; set; }
        public virtual EducationDTO? Education { get; set; }
        public virtual ClassTypeDTO? ClassType { get; set; }
    }
}
