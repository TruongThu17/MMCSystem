using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class ClassTypeDTO
    {
        public int ClassTypeId { get; set; }
        [DisplayName("Phân loại")]
        public string ClassTypeName { get; set; }
    }
}
