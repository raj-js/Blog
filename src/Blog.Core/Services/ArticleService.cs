using AutoMapper;
using Blog.Core.DTOs;
using Blog.Core.Models;
using Sparrow.Core.DTOs.Responses;
using Sparrow.Core.Services;
using Sparrow.Core.Stores;
using Sparrow.Infrastructure.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using static Sparrow.Core.DTOs.Responses.OpResponse;

namespace Blog.Core.Services
{
    public class ArticleService : AppServiceBase, IArticleService
    {
        private readonly IMapper _mapper;
        private readonly IStore<Article, string> _store;
        private readonly IStore<Category, int> _categoryStore;
        private readonly IStore<Tag, int> _tagStore;
        private readonly IStore<ArticleCategory, long> _articleCategoryStore;
        private readonly IStore<ArticleTag, long> _articleTagStore;

        public ArticleService(
            IMapper mapper,
            IStore<Article, string> store,
            IStore<Category, int> categoryStore,
            IStore<Tag, int> tagStore,
            IStore<ArticleCategory, long> articleCategoryStore,
            IStore<ArticleTag, long> articleTagStore
            )
        {
            _mapper = mapper;
            _store = store;
            _categoryStore = categoryStore;
            _tagStore = tagStore;
            _articleCategoryStore = articleCategoryStore;
            _articleTagStore = articleTagStore;
        }

        public Task<OpResponse<string>> SaveAsDraft(ArticleCreateDTO article)
        {
            return SaveNewArticle(article, asDraft: true);
        }

        public Task<OpResponse<string>> PublishImmediately(ArticleCreateDTO article)
        {
            return SaveNewArticle(article, asDraft: false);
        }

        public async Task<OpResponse> Publish(string id)
        {
            var entity = await _store.FindAsync(id);
            if (entity == null)
                return Failure("404", $"编号为`{id}`的文章不存在");

            if (entity.IsDraft)
            {
                entity.IsDraft = true;
                entity.PublishTime = DateTime.Now;

                await _store.UpdateAsync(entity);
                await _store.SaveAsync();

                return Success();
            }

            return Failure();
        }

        public async Task<OpResponse<(List<ArticleListItemDTO> List, long Total)>> PageQuery(ArticleQueryDTO query, int pageIndex, int pageSize, params (string Field, bool IsAsc)[] sortFields)
        {
            Expression<Func<Article, bool>> exp = s => true;

            if (query.Category != null)
            {
                var articleIds = _articleCategoryStore
                    .Query()
                    .Where(s => s.CategoryId == query.Category.Value)
                    .Select(s => s.ArticleId);

                exp = exp.And(s => articleIds.Contains(s.Id));
            }

            if (query.Tag != null)
            {
                var articleIds = _articleTagStore
                        .Query()
                        .Where(s => s.TagId == query.Tag.Value)
                        .Select(s => s.ArticleId);

                exp = exp.And(s => articleIds.Contains(s.Id));
            }

            var (Entities, Total) = await _store.PageQuery(exp, sortFields, pageIndex, pageSize);

            return Success((
                Entities.Select(ToArticleListItem).ToList(),
                Total
                ));
        }

        public async Task<OpResponse> ModifyArticle(ArticleUpdateDTO article)
        {
            var entity = await _store.FindAsync(article.Id);
            if (entity == null)
                return Failure("404", $"编号为`{article.Id}`的文章不存在");

            entity = _mapper.Map(article, entity);
            await _store.UpdateAsync(entity);

            var articleCategory = await _articleCategoryStore.SingleAsync(s => s.ArticleId == entity.Id);
            articleCategory.CategoryId = article.Category;

            await _articleTagStore.RemoveAsync(s => s.ArticleId == entity.Id && !article.Tags.Contains(s.TagId));

            var articleTags = _articleTagStore
                .Query()
                .Where(s => s.ArticleId == entity.Id && article.Tags.Contains(s.TagId))
                .Select(s => s.TagId)
                .ToArray();

            var newTags = article.Tags
                .Where(s => !articleTags.Contains(s))
                .Select(tagId => new ArticleTag { ArticleId = entity.Id, TagId = tagId });

            await _articleTagStore.CreateManyAsync(newTags);

            await _store.SaveAsync();
            return Success();
        }

        public async Task<OpResponse> MarkAsDeleted(string id)
        {
            var entity = await _store.FindAsync(id);
            if (entity == null)
                return Failure("404", $"编号为`{id}`的文章不存在");

            entity.IsDeleted = true;
            await _store.UpdateAsync(entity);
            await _store.SaveAsync();

            return Success();
        }

        public async Task<OpResponse> MarkAsTop(string id)
        {
            var entity = await _store.FindAsync(id);
            if (entity == null)
                return Failure("404", $"编号为`{id}`的文章不存在");

            if (entity.IsDeleted)
                return Failure("500", $"编号为`{id}`的文章已删除");

            if (entity.IsDraft)
                return Failure("500", $"编号为`{id}`的文章未发布");

            entity.IsTop = true;
            await _store.UpdateAsync(entity);
            await _store.SaveAsync();

            return Success();
        }

        #region privates

        private async Task<OpResponse<string>> SaveNewArticle(ArticleCreateDTO article, bool asDraft)
        {
            var entity = _mapper.Map<Article>(article);

            entity.Reads = 0;
            entity.Likes = 0;
            entity.IsDraft = asDraft;
            entity.IsDeleted = false;
            entity.Creation = DateTime.Now;
            entity.PublishTime = asDraft ? null : new DateTime?(DateTime.Now);

            var articleId = await _store.CreateAndGetIdAsync(entity);

            var articleCategory = new ArticleCategory
            {
                ArticleId = articleId,
                CategoryId = article.Category
            };
            await _articleCategoryStore.CreateAsync(articleCategory);

            var articleTags = article.Tags.Select(tagId => new ArticleTag
            {
                ArticleId = articleId,
                TagId = tagId
            });
            await _articleTagStore.CreateManyAsync(articleTags);

            await _store.SaveAsync();

            return Success(articleId);
        }

        private ArticleListItemDTO ToArticleListItem(Article article)
        {
            var dto = _mapper.Map<ArticleListItemDTO>(article);

            var articleCategory = _articleCategoryStore.Single(s => s.ArticleId == article.Id);
            var category = _categoryStore.Find(articleCategory.CategoryId);

            var articleTags = _articleTagStore
                .Query()
                .Where(s => s.ArticleId == article.Id)
                .Select(s => s.TagId)
                .ToArray();

            var tags = _tagStore
                .Query()
                .Where(s => articleTags.Contains(s.Id))
                .ToArray();

            dto.Category = category.Name;
            dto.Tags = tags.Select(s => s.Name).ToArray();

            return dto;
        }

        #endregion
    }
}
