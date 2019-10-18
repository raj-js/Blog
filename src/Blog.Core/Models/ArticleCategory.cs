using Blog.Core.Sparrow;

namespace Blog.Core.Models
{
    public class ArticleCategory : IEntity<long>
    {
        public long Id { get; set; }

        public string ArticleId { get; set; }

        public int CategoryId { get; set; }
    }
}
