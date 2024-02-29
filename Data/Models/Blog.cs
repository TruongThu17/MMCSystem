using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string Tilte { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
    }
}
