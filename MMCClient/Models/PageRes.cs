namespace MMCClient.Models
{
	public class PageRes<T>
	{
		public T Obj { get; set; }
        public string? Message { get; set; }
    }
}
