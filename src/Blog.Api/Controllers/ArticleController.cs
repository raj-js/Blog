using Blog.Core.DTOs;
using Blog.Core.Models;
using Blog.Core.Sparrow.ApiControllers;
using Blog.Core.Sparrow.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    /// <summary>
    /// 文章接口
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : CURLApiControllerBase<Article, string, ArticleCreateDTO, ArticleUpdateDTO, ArticleDTO>
    {
        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="curlService"></param>
        public ArticleController(ICURLService<Article, string, ArticleCreateDTO, ArticleUpdateDTO, ArticleDTO> curlService) : base(curlService)
        {
        }
    }
}