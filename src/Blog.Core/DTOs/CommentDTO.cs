using System;

namespace Blog.Core.DTOs
{
    public class CommentDTO
    {
        public string Id { get; set; }

        public int Order { get; set; }

        public string Poster { get; set; }

        public string Content { get; set; }

        public string PosterIp { get; set; }

        public bool IsAnonymous { get; set; }

        public bool IsApproved { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime Creation { get; set; }
    }
}
