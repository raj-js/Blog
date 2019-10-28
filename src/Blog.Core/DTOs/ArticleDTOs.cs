using System;

namespace Blog.Core.DTOs
{
    /// <summary>
    /// 文章详细信息
    /// </summary>
    public class ArticleDTO
    {
        /// <summary>
        /// 文章编号
        /// </summary>
        public string Id { get; set; }

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
        /// 分类
        /// </summary>
        public int Category { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public int[] Tags { get; set; }

        /// <summary>
        /// 阅读数
        /// </summary>
        public int Reads { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        public int Likes { get; set; }

        /// <summary>
        /// 是否置顶
        /// </summary>
        public bool IsTop { get; set; }

        /// <summary>
        /// 是否为草稿
        /// </summary>
        public bool IsDraft { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Creation { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime? PublishTime { get; set; }
    }

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
        public int Category { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public int[] Tags { get; set; }

        /// <summary>
        /// 是否为草稿
        /// </summary>
        public bool IsDraft { get; set; }
    }

    /// <summary>
    /// 文章查询
    /// </summary>
    public class ArticleQueryDTO
    {
        /// <summary>
        /// 分类
        /// </summary>
        public int? Category { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public int? Tag { get; set; }
    }

    /// <summary>
    /// 文章修改
    /// </summary>
    public class ArticleUpdateDTO
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string Id { get; set; }

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
        /// 分类
        /// </summary>
        public int Category { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public int[] Tags { get; set; }
    }

    /// <summary>
    /// 文章列表项
    /// </summary>
    public class ArticleListItemDTO
    {
        /// <summary>
        /// 文章编号
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        public string Digest { get; set; }

        /// <summary>
        /// 阅读数
        /// </summary>
        public int Reads { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        public int Likes { get; set; }

        /// <summary>
        /// 是否置顶
        /// </summary>
        public bool IsTop { get; set; }

        /// <summary>
        /// 是否为草稿
        /// </summary>
        public bool IsDraft { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Creation { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public string[] Tags { get; set; }
    }
}
