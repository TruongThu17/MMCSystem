using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class AboutDTO
    {
        public int ID { get; set; }
        public string? Description { get; set; }
        public IFormFile? ImgFile { get; set; }
        public string? Img { get; set; }
    }
}
