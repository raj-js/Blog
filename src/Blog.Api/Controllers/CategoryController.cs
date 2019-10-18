using Blog.Core.DTOs;
using Blog.Core.Models;
using Blog.Core.Sparrow.ApiControllers;
using Blog.Core.Sparrow.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    /// <summary>
    /// 类别
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : CURLApiControllerBase<Category, int, CategoryCreateDTO, CategoryUpdateDTO, CategoryDTO>
    {
        /// <summary>
        /// gouza构造器
        /// </summary>
        /// <param name="curlService"></param>
        public CategoryController(ICURLService<Category, int, CategoryCreateDTO, CategoryUpdateDTO, CategoryDTO> curlService) : base(curlService)
        {
        }
    }
}