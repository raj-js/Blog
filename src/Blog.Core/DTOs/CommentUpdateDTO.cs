namespace Blog.Core.DTOs
{
    public class CommentUpdateDTO
    {
        public string Id { get; set; }

        public bool IsApproved { get; set; }

        public bool IsDeleted { get; set; }
    }
}
