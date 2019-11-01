using Blog.Core.DTOs;
using Blog.Core.Models;
using Sparrow.Core.DTOs.Responses;
using Sparrow.Core.Services;
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
        Task<OpResponse<byte[]>> GetCover(int id);
    }
}
