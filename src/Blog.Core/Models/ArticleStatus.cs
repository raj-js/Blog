using System;

namespace Blog.Core.Models
{
    /// <summary>
    /// 文字状态
    /// </summary>
    [Flags]
    public enum ArticleStatus
    {
        /// <summary>
        /// 草稿
        /// </summary>
        Draft = 0x1,

        /// <summary>
        /// 已发布
        /// </summary>
        Published = 0x10,

        /// <summary>
        /// 已删除
        /// </summary>
        Deleted = 0x100,

        /// <summary>
        /// 置顶
        /// </summary>
        Top = 0x1000
    }
}
