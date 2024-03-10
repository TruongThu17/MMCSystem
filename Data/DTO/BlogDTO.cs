using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class BlogDTO
    {
        public int ID { get; set; }
        public string Tilte { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public IFormFile? ImgFile { get; set; }
    }
}
