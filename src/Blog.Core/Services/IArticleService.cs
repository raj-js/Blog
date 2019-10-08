using Blog.Core.Models;
using Blog.Infrastructure.Paging;
using System.Threading.Tasks;

namespace Blog.Core.Services
{
    /// <summary>
    /// 文章服务
    /// </summary>
    public interface IArticleService
    {
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pager">
        /// Category 文章类型
        /// Tag 文章标签
        /// string 关键词
        /// </param>
        /// <returns></returns>
        Task<Paged<Article>> PagingQuery(Pager<(Category, Tag, string)> pager);

        /// <summary>
        /// 根据文章编号查找
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Article> Single(string id);

        /// <summary>
        /// 写草稿
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        Task<Article> Scrawl(Article article);

        /// <summary>
        /// 发布文章
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        Task<Article> Publish(Article article);

        /// <summary>
        /// 编辑文章
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        Task<Article> Edit(Article article);

        /// <summary>
        /// 删除文章
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        Task Delete(Article article);
    }
}
