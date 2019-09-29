using MongoDB.Bson;

namespace Blog.Core.Models
{
    public class Tag
    {
        public ObjectId Id { get; set; }

        public string Name { get; set; }

        public bool Enable { get; set; }
    }
}
