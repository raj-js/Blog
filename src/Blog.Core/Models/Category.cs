using Sparrow.Core;

namespace Blog.Core.Models
{
    public class Category : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public bool Enable { get; set; }
    }
}
