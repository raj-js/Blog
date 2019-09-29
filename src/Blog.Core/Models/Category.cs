using MongoDB.Bson;

namespace Blog.Core.Models
{
    public class Category
    {
        public ObjectId Id { get; private set; }

        public string Name { get; private set; }

        public int Order { get; private set; }

        public bool Enable { get; private set; }

        public int? ParentId { get; set; }
    }
}
