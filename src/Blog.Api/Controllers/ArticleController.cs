using Blog.Core.DTOs;
using Blog.Core.Services;
using Microsoft.AspNetCore.Authorization;
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
            if (query != null && dto != null)
            {
                var opResponse = await _articleService
                    .PageQuery(dto, query.PageIndex, query.PageSize, (query.Order, query.IsAsc));

                if (opResponse.IsSuccess)
                    return Success(PagingHelper.From(opResponse.Data));
            }

            return Failure<Paged<ArticleListItemDTO>>();
        }

        /// <summary>
        /// 获取文章详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<OpResponse<ArticleDTO>> Get([FromRoute]string id) 
        {
            return await _articleService.Get(id);
        }

        /// <summary>
        /// 创建草稿
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost("draft")]
        [Authorize]
        public async Task<OpResponse<string>> Draft([FromBody]ArticleCreateDTO dto)
        {
            return await _articleService.SaveAsDraft(dto);
        }

        /// <summary>
        /// 立即发布
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost("publish")]
        [Authorize]
        public async Task<OpResponse<string>> Publish([FromBody]ArticleCreateDTO dto)
        {
            return await _articleService.PublishImmediately(dto);
        }

        /// <summary>
        /// 修改文章
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut]
        [Authorize]
        public async Task<OpResponse> Put([FromBody]ArticleUpdateDTO dto)
        {
            return await _articleService.ModifyArticle(dto);
        }

        /// <summary>
        /// 文章发布
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("publish/{id}")]
        [Authorize]
        public async Task<OpResponse> Publish([FromRoute]string id)
        {
            var article = await _articleService.Publish(id);
            return article != null ? Success() : Failure();
        }

        /// <summary>
        /// 删除文章
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<OpResponse> Delete([FromRoute]string id)
        {
            return await _articleService.MarkAsDeleted(id);
        }

        /// <summary>
        /// 置顶文章
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("markAsTop/{id}")]
        [Authorize]
        public async Task<OpResponse> MarkAsTop([FromRoute]string id)
        {
            return await _articleService.MarkAsTop(id);
        }
    }
}