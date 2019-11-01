using Sparrow.Core;
using System;

namespace Blog.Core.Models
{
    /// <summary>
    /// 文章访问历史
    /// </summary>
    public class ArticleVisitHistory : IEntity<long>
    {
        /// <summary>
        /// 编号
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 文章编号
        /// </summary>
        public string ArticleId { get; set; }

        /// <summary>
        /// 访问用户
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 访问IP
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 访问时间
        /// </summary>
        public DateTime VisitTime { get; set; }
    }
}
