using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class RegisterModel
    {
        public string? Username { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? FullName { get; set; } 
        public DateTime? BirthDay { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public bool? Status { get; set; }
        public string? ParentFullName { get; set; }
        public string? ParentPhone { get; set; }
        public int? EducationId { get; set; }
        public string? StudentCode { get; set; }
        public int? ClassId { get; set; }
    }
}
