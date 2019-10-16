using Blog.Core.Dtos;
using Blog.Core.Models;
using Blog.Core.Sparrow.Services;
using System.Threading.Tasks;

namespace Blog.Core.Services
{
    /// <summary>
    /// 文章服务
    /// </summary>
    public interface IArticleService : ICurlService<Article, string, ArticleCreateReqDto, ArticleUpdateReqDto, ArticleRespDto>
    {
        /// <summary>
        /// 写草稿
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        // Task<ArticleRespDto> CreateDraft(ArticleCreateReqDto article);

        /// <summary>
        /// 发布文章
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // Task<ArticleRespDto> Publish(string id);
    }
}
