namespace MMCClient.Models
{
    public class PageSz<T>
    {
        public int PageSize { get; set; } = 10;
        public int PageNumber { get; set; }
        public string? searchString { get; set; }
        public int CountPage { get; set; }
        public int? CountItem { get; set; }
        public List<T> list { get; set; }

    }
}
