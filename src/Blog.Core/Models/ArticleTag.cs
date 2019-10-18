using Blog.Core.Sparrow;

namespace Blog.Core.Models
{
    public class ArticleTag : IEntity<long>
    {
        public long Id { get; set; }

        public string ArticleId { get; set; }

        public int TagId { get; set; }
    }
}
