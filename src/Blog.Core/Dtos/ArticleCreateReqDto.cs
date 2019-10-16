namespace Blog.Core.Dtos
{
    public class ArticleCreateReqDto
    {
        public string Title { get; set; }

        public string Digest { get; set; }

        public string Content { get; set; }

        public bool IsTop { get; set; }

        public bool IsDraft { get; set; }

        public string[] Tags { get; set; }

        public string Category { get; set; }
    }
}
