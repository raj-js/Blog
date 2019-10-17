namespace Blog.Core.Sparrow.DTOs.Paging
{
    public class PageQuery<TDTO> : PageQuery
    {
        public TDTO Query { get; set; }
    }
}
