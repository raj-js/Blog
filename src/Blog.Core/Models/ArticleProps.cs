using MongoDB.Bson;

namespace Blog.Core.Models
{
    public class ArticleProps
    {
        public string Id { get; private set; }

        public string ArticleId { get; private set; }

        public string Name { get; private set; }

        public string Value { get; private set; }
    }
}
