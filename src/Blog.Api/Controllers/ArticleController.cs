using Blog.Core.DTOs;
using Blog.Core.Models;
using Blog.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Sparrow.Core.ApiControllers;
using static Sparrow.Core.DTOs.Responses.OpResponse;
using System.Threading.Tasks;
using Sparrow.Core.DTOs.Responses;

namespace Blog.Api.Controllers
{
    /// <summary>
    /// 文章接口
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ApiControllerBase<Article, string, ArticleCreateDTO, ArticleUpdateDTO, ArticleDTO>
    {
        private readonly IArticleService _articleService;

        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="articleService"></param>
        public ArticleController(IArticleService articleService) : base(articleService)
        {
            _articleService = articleService;
        }

        /// <summary>
        /// 创建草稿
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost("draft")]
        public async Task<OpResponse<ArticleDTO>> CreateDraft([FromBody]ArticleCreateDTO dto)
        {
            return await _articleService.CreateDraft(dto);
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
            if (article != null)
                return Success(article);

            return Failure();
        }
    }
}