using Blog.Core.DTOs;
using Blog.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Sparrow.Core.ApiControllers;
using Sparrow.Core.Services;

namespace Blog.Api.Controllers
{
    /// <summary>
    /// 评论接口
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ApiControllerBase<Comment, string, CommentCreateDTO, CommentUpdateDTO, CommentDTO>
    {
        /// <summary>
        /// 构造器
        /// </summary>
        /// <param name="curlService"></param>
        public CommentController(IAppService<Comment, string, CommentCreateDTO, CommentUpdateDTO, CommentDTO> curlService) : base(curlService)
        {
        }
    }
}