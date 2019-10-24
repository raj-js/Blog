using Sparrow.Core;
using System;

namespace Blog.Core.Models
{
    public class Article : IEntity<string>
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Digest { get; set; }

        public string Content { get; set; }

        public int Reads { get; set; }

        public int Likes { get; set; }

        public bool IsTop { get; set; }

        public bool IsDraft { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime Creation { get; set; }

        public DateTime? PublishTime { get; set; }
    }
}
