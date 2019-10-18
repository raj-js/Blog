using Blog.Core.DTOs;
using Blog.Core.Models;
using Blog.Core.Sparrow.ApiControllers;
using Blog.Core.Sparrow.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    /// <summary>
    /// 标签接口控制器
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : CURLApiControllerBase<Tag, int, TagCreateDTO, TagDTO, TagDTO>
    {
        /// <summary>
        /// 构造器
        /// </summary>
        /// <param name="curlService"></param>
        public TagController(ICURLService<Tag, int, TagCreateDTO, TagDTO, TagDTO> curlService) : base(curlService)
        {
        }
    }
}