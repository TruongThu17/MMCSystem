using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class MealTypeDTO
    {
        [DisplayName("Mã loại bữa ăn")]
        public int Id { get; set; }
        [DisplayName("Loại bữa ăn")]
        public string Name { get; set; }
    }
}
