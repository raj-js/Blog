namespace Blog.Core.DTOs
{
    public class CommentCreateDTO
    {
        public string ArticleId { get; set; }

        public string Poster { get; set; }

        public string Content { get; set; }
    }
}
