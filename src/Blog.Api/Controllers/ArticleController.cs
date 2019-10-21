using Blog.Core.DTOs;
using Blog.Core.Models;
using Blog.Core.Services;
using Blog.Core.Sparrow.ApiControllers;
using Blog.Core.Sparrow.DTOs.Response;
using Blog.Core.Sparrow.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blog.Api.Controllers
{
    /// <summary>
    /// 文章接口
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : CURLApiControllerBase<Article, string, ArticleCreateDTO, ArticleUpdateDTO, ArticleDTO>
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
        public async Task<ApiResponse<ArticleDTO>> CreateDraft([FromBody]ArticleCreateDTO dto)
        {
            return ApiResponse.Success(await _articleService.CreateDraft(dto));
        }

        /// <summary>
        /// 文章发布
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("publish/{id}")]
        public async Task<ApiResponse> Publish(string id)
        {
            var article = await _articleService.Publish(id);
            if (article != null)
                return ApiResponse.Success(article);

            return ApiResponse.Failure();
        }
    }
}