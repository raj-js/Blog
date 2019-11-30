using Blog.Core.DTOs;
using Blog.Core.Models;
using Blog.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Sparrow.Core.ApiControllers;
using Sparrow.Core.DTOs.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Api.Controllers
{
    /// <summary>
    /// 类别
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ApiControllerBase<Category, int, CategoryCreateDTO, CategoryUpdateDTO, CategoryDTO>
    {
        private readonly ICategoryService _categoryService;

        /// <summary>
        /// 构造器
        /// </summary>
        /// <param name="categoryService"></param>
        public CategoryController(ICategoryService categoryService) : base(categoryService)
        {
            _categoryService = categoryService;
        }

        /// <summary>
        /// 获取所有启用的分类
        /// </summary>
        /// <returns></returns>
        [HttpGet("all/enabled")]
        public OpResponse<List<CategoryDTO>> GetEnabledCategories() 
        {
            return _categoryService.GetEnabledCategories();
        }
    }
}