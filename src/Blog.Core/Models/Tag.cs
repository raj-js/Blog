using Sparrow.Core;

namespace Blog.Core.Models
{
    public class Tag : IEntity
    {
        public int Id { get; set; }

        public string Color { get; set; }

        public string Name { get; set; }

        public bool Enable { get; set; }
    }
}
