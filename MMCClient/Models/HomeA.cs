using Data.DTO;

namespace MMCClient.Models
{
    public class HomeA
    {
        public List<AccountStudentDTO>? Accounts { get; set; }
        public int? CountAcc { get; set; }
        public int? CountSup { get; set; }
        public int? CountOrder { get; set; }
        public Decimal? Month { get; set; }
        public Decimal? Day { get; set; }
        public List<OrderDTO>? Orders { get; set; }
        public List<SupplierDTO>? Suppliers { get; set; }
    }
}
