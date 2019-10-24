using Blog.Core.DTOs;
using Blog.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Sparrow.Core.ApiControllers;
using Sparrow.Core.Services;

namespace Blog.Api.Controllers
{
    /// <summary>
    /// 标签
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ApiControllerBase<Tag, int, TagCreateDTO, TagDTO, TagDTO>
    {
        /// <summary>
        /// 构造器
        /// </summary>
        /// <param name="curlService"></param>
        public TagController(IAppService<Tag, int, TagCreateDTO, TagDTO, TagDTO> curlService) : base(curlService)
        {
        }
    }
}