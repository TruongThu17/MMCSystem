using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class About
    {
        public int ID { get; set; }
        public string? Description { get; set; }
        public string? Img { get; set; }
    }
}
