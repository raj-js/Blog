using Blog.Core.DTOs;
using Blog.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Sparrow.Core.ApiControllers;
using Sparrow.Core.Services;

namespace Blog.Api.Controllers
{
    /// <summary>
    /// 类别
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ApiControllerBase<Category, int, CategoryCreateDTO, CategoryUpdateDTO, CategoryDTO>
    {
        /// <summary>
        /// gouza构造器
        /// </summary>
        /// <param name="curlService"></param>
        public CategoryController(IAppService<Category, int, CategoryCreateDTO, CategoryUpdateDTO, CategoryDTO> curlService) : base(curlService)
        {
        }
    }
}