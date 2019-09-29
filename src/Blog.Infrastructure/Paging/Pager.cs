namespace Blog.Infrastructure.Paging
{
    public class Pager
    {
        public int Skip { get; set; }

        public int Take { get; set; }

        public string Order { get; set; }
    }
}
