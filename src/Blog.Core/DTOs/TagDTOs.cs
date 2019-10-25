namespace Blog.Core.DTOs
{
    public class TagDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Enable { get; set; }
    }

    public class TagCreateDTO
    {
        public string Name { get; set; }

        public bool Enable { get; set; } = true;
    }
}
