using Blog.Core.DTOs;
using Sparrow.Core.DTOs.Responses;
using Sparrow.Core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Core.Services
{
    /// <summary>
    /// 文章服务
    /// </summary>
    public interface IArticleService : IAppService
    {
        /// <summary>
        /// 写草稿
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        Task<OpResponse<string>> SaveAsDraft(ArticleCreateDTO article);

        /// <summary>
        /// 立即发布
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        Task<OpResponse<string>> PublishImmediately(ArticleCreateDTO article);

        /// <summary>
        /// 修改文章
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        Task<OpResponse> ModifyArticle(ArticleUpdateDTO article);

        /// <summary>
        /// 删除文章
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<OpResponse> MarkAsDeleted(string id);

        /// <summary>
        /// 置顶文章
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<OpResponse> MarkAsTop(string id);

        /// <summary>
        /// 发布文章
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<OpResponse> Publish(string id);

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="query"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="sortFields"></param>
        /// <returns></returns>
        Task<OpResponse<(List<ArticleListItemDTO> List, long Total)>> PageQuery(ArticleQueryDTO query, int pageIndex, int pageSize, params (string Field, bool IsAsc)[] sortFields);
    }
}
