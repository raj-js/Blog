using Blog.Core.DTOs;
using Blog.Core.Models;
using Sparrow.Core.DTOs.Responses;
using Sparrow.Core.Services;
using System.Threading.Tasks;

namespace Blog.Core.Services
{
    /// <summary>
    /// 文章服务
    /// </summary>
    public interface IArticleService : IAppService<Article, string, ArticleCreateDTO, ArticleUpdateDTO, ArticleDTO>
    {
        /// <summary>
        /// 写草稿
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        Task<OpResponse<ArticleDTO>> CreateDraft(ArticleCreateDTO article);

        /// <summary>
        /// 发布文章
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<OpResponse<ArticleDTO>> Publish(string id);
    }
}
