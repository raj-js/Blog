using Microsoft.AspNetCore.Http;

namespace Blog.Core.DTOs
{
    /// <summary>
    /// 分类
    /// </summary>
    public class CategoryDTO 
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string Id { get; set; }

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

        /// <summary>
        /// 访问总数
        /// </summary>
        public long Temperature { get; set; }

        /// <summary>
        /// 文章数
        /// </summary>
        public long Articles { get; set; }
    }

    /// <summary>
    /// 创建分类
    /// </summary>
    public class CategoryCreateDTO
    {
        /// <summary>
        /// 分类名称
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
     
    /// <summary>
    /// 更新分类
    /// </summary>
    public class CategoryUpdateDTO
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 封面
        /// </summary>
        public string Cover { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Enable { get; set; }
    }
}
