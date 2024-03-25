using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class RegistratorVM
    {
        [DisplayName("Username")]
        public string? Username { get; set; }

        [EmailAddress]
        [DisplayName("Email")]
        public string? Email { get; set; }
        [DisplayName("Mật khẩu")]
        public string? Password { get; set; }
        [DisplayName("Họ và tên ")]
        public string? FullName { get; set; }
        [DisplayName("Ngày sinh")]
        public DateTime? BirthDay { get; set; }
        [DisplayName("Số điện thoại")]
        public string? PhoneNumber { get; set; }
        [DisplayName("Địa chỉ")]
        public string? Address { get; set; }
        [DisplayName("Tên trường")]
        public string EducationName { get; set; }
    }
}
