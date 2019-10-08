using System;

namespace Blog.Core.Models
{
    public class Comment
    {
        public string Id { get; private set; }

        public string ArticleId { get; private set; }

        public string Poster { get; private set; }

        public string Content { get; private set; }

        public string PosterIp { get; private set; }

        public bool IsAnonymous { get; private set; }

        public bool IsApproved { get; private set; }

        public bool IsDeleted { get; private set; }

        public DateTime Creation { get; private set; }
    }
}
