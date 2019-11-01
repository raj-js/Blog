using AutoMapper;
using Blog.Core.DTOs;
using Blog.Core.Models;
using Sparrow.Core.DTOs.Responses;
using Sparrow.Core.Services;
using Sparrow.Core.Stores;
using System.Linq;
using System.Threading.Tasks;
using static Sparrow.Core.DTOs.Responses.OpResponse;

namespace Blog.Core.Services
{
    public class CategoryService : AppServiceBase<Category, int, CategoryCreateDTO, CategoryUpdateDTO, CategoryDTO>, ICategoryService
    {
        private readonly IStore<ArticleCategory, long> _articleCategoryStore;
        private readonly IStore<Article, string> _articleStore;

        public CategoryService(IMapper mapper,
            IStore<Category, int> store,
            IStore<ArticleCategory, long> articleCategoryStore,
            IStore<Article, string> articleStore
            ) : base(mapper, store)
        {
            _articleCategoryStore = articleCategoryStore;
            _articleStore = articleStore;
        }

        public async Task<OpResponse<byte[]>> GetCover(int id)
        {
            var category = await Store.FindAsync(id);
            if (category == null)
                return Failure<byte[]>("404", "分类不存在");

            return Success(category.Cover);
        }

        protected override CategoryDTO ToListItemDTO(Category entity)
        {
            var dto = base.ToListItemDTO(entity);

            var (Temperature, Articles) = GetCategoryProps(entity);
            dto.Articles = Articles;
            dto.Temperature = Temperature;

            return dto;
        }

        protected override CategoryDTO ToDTO(Category entity)
        {
            var dto = base.ToDTO(entity);

            var (Temperature, Articles) = GetCategoryProps(entity);
            dto.Articles = Articles;
            dto.Temperature = Temperature;

            return dto;
        }

        #region privates

        private (long Temperature, long Articles) GetCategoryProps(Category entity)
        {
            var articleIds = _articleCategoryStore
                 .Query()
                 .Where(s => s.CategoryId == entity.Id)
                 .Select(s => s.ArticleId)
                 .ToArray();

             return (
                _articleStore
                    .Query()
                    .Where(s => !s.IsDeleted && !s.IsDraft && articleIds.Contains(s.Id))
                    .Sum(s => s.Reads),

                articleIds.LongCount()
                );
        }

        #endregion
    }
}
