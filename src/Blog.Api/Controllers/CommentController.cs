using Blog.Core.DTOs;
using Blog.Core.Models;
using Blog.Core.Sparrow.ApiControllers;
using Blog.Core.Sparrow.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    /// <summary>
    /// 评论接口
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : CURLApiControllerBase<Comment, string, CommentCreateDTO, CommentUpdateDTO, CommentDTO>
    {
        /// <summary>
        /// 构造器
        /// </summary>
        /// <param name="curlService"></param>
        public CommentController(ICURLService<Comment, string, CommentCreateDTO, CommentUpdateDTO, CommentDTO> curlService) : base(curlService)
        {
        }
    }
}