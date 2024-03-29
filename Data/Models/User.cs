﻿using Microsoft.AspNetCore.Identity;
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
        public string? Address { get; set; }
        public bool Status { get; set; }
        public string? ParentFullName { get; set; }
        public int? ClassId { get; set; }
        public string? Img { get; set; }
        public string? StudentCode { get; set; }
        public int? EducationId { get; set; }
        public virtual Education? Education { get; set; }
        public virtual Class? Class { get; set; }
    }
}
