namespace Blog.Infrastructure.Paging
{
    public class Pager<TEntity> : Pager
    {
        public TEntity Entity { get; set; }
    }
}
