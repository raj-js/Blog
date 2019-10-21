namespace Blog.Core.DTOs
{
    /// <summary>
    /// 创建文章
    /// </summary>
    public class ArticleCreateDTO
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        public string Digest { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 是否置顶
        /// </summary>
        public bool IsTop { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public int[] Tags { get; set; }

        /// <summary>
        /// 是否为草稿
        /// </summary>
        public bool IsDraft { get; set; }
    }
}
