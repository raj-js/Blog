namespace Blog.Infrastructure.Paging
{
    public class Pager<TEntity> : Pager where TEntity : class
    {
        public TEntity Entity { get; set; }
    }
}
