namespace Blog.Core.DTOs
{
    public class ArticleCreateDTO
    {
        public string Title { get; set; }

        public string Digest { get; set; }

        public string Content { get; set; }

        public bool IsDraft { get; set; }
    }
}
