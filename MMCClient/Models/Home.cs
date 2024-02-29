using Data.Models;

namespace MMCClient.Models
{
    public class Home
    {
        public About About { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
