using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class User : IdentityUser<Guid>
    {
        public string? FullName { get; set; }
        public DateTime? BirthDay { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public bool Status { get; set; }
    }
}
