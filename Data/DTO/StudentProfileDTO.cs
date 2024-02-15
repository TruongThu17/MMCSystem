using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class StudentProfileDTO
    {
        public string? FullName { get; set; }
        public DateTime? BirthDay { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? ParentFullName { get; set; }
        public string? ParentPhone { get; set; }
    }
}
