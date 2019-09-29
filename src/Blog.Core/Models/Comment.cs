using System;

namespace Blog.Core.Models
{
    public class Comment
    {
        public Guid Id { get; private set; }

        public Guid ArticleId { get; private set; }

        public string NickName { get; private set; }

        public string Content { get; private set; }

        public string Ip { get; private set; }

        public bool IsAnonymous { get; private set; }

        public bool IsApproved { get; private set; }

        public bool IsDeleted { get; private set; }

        public DateTime Creation { get; private set; }
    }
}
