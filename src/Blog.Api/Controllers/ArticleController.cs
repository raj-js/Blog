using Blog.Core.DTOs;
using Blog.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Sparrow.Core.ApiControllers;
using Sparrow.Core.DTOs.Paging;
using Sparrow.Core.DTOs.Responses;
using System.Threading.Tasks;
using static Sparrow.Core.DTOs.Responses.OpResponse;

namespace Blog.Api.Controllers
{
    /// <summary>
    /// 文章接口
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ApiControllerBase
    {
        private readonly IArticleService _articleService;

        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="articleService"></param>
        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="query"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpGet("paging")]
        public async Task<OpResponse<Paged<ArticleListItemDTO>>> Paging([FromQuery]PageQuery query, [FromQuery]ArticleQueryDTO dto)
        {
            var opResponse = await _articleService.PageQuery(dto, query.PageIndex, query.PageSize, (query.Order, query.IsAsc));

            if (opResponse.IsSuccess)
                return Success(PagingHelper.From(opResponse.Data));

            return Failure<Paged<ArticleListItemDTO>>();
        }

        /// <summary>
        /// 创建草稿
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost("draft")]
        public async Task<OpResponse<string>> CreateDraft([FromBody]ArticleCreateDTO dto)
        {
            return await _articleService.SaveAsDraft(dto);
        }

        /// <summary>
        /// 文章发布
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("publish/{id}")]
        public async Task<OpResponse> Publish(string id)
        {
            var article = await _articleService.Publish(id);
            return article != null ? Success() : Failure();
        }
    }
}