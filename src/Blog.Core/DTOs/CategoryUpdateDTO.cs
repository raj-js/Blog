namespace Blog.Core.DTOs
{
    public class CategoryUpdateDTO
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public bool Enable { get; set; }
    }
}
