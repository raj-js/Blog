using System;

namespace Blog.Core.DTOs
{
    public class ArticleDTO
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
    }
}
