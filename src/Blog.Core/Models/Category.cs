using Sparrow.Core;

namespace Blog.Core.Models
{
    /// <summary>
    /// 文章分类
    /// </summary>
    public class Category : IEntity
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 分类名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 封面
        /// </summary>
        public string Cover { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Enable { get; set; }
    }
}
