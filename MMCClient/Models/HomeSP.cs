using Data.DTO;
using Data.Models;

namespace MMCClient.Models
{
    public class HomeSP
    {
        public List<Blog>? Blogs { get; set; }
        public List<AccountAdminDTO>? Accounts { get; set; }
        public int? CountAcc { get; set; }
        public int? CountBlog { get; set; }
    }
}
