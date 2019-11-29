using Sparrow.Core;
using System;

namespace Blog.Core.Models
{
    /// <summary>
    /// 文章
    /// </summary>
    public class Article : IEntity<string>
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
        /// 编辑器类型
        /// </summary>
        public EditorType EditorType { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 阅读数
        /// </summary>
        public int Views { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        public int Likes { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public ArticleStatus Status { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Creation { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime? PublishTime { get; set; }
    }
}
