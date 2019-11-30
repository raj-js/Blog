using Blog.Core.DTOs;
using Blog.Core.Models;
using Sparrow.Core.DTOs.Responses;
using Sparrow.Core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Core.Services
{
    public interface ICategoryService : IAppService<Category, int, CategoryCreateDTO, CategoryUpdateDTO, CategoryDTO>
    {
        /// <summary>
        /// 根据分类编号获取分类封面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<OpResponse<string>> GetCover(int id);

        /// <summary>
        /// 获取所有启用的分类
        /// </summary>
        /// <returns></returns>
        OpResponse<List<CategoryDTO>> GetEnabledCategories();
    }
}
