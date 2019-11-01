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
        /// 新增
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public override Task<OpResponse<CategoryDTO>> Post([FromForm] CategoryCreateDTO dto)
        {
            return base.Post(dto);
        }

        /// <summary>
        /// 获取分类封面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("cover/{id}")]
        public async Task<IActionResult> GetCover(int id) 
        {
            var resp = await _categoryService.GetCover(id);

            if (!resp.IsSuccess)
                return NotFound(resp.Errors);

            return File(resp.Data, "image/jpeg");
        }
    }
}