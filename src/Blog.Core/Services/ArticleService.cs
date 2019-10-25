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

        public ArticleService(IMapper mapper, IStore<Article, string> store)
        {
            _mapper = mapper;
            _store = store;
        }

        public async Task<OpResponse<string>> SaveAsDraft(ArticleCreateDTO article)
        {
            var entity = _mapper.Map<Article>(article);
            entity.Reads = 0;
            entity.Likes = 0;
            entity.IsDraft = true;
            entity.IsDeleted = false;
            entity.Creation = DateTime.Now;
            entity.PublishTime = null;
            
            return Success(await _store.CreateAndGetIdAsync(entity));
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
                return Success();
            }

            return Failure();
        }

        public async Task<OpResponse<(List<ArticleListItemDTO> List, long Total)>> PageQuery(ArticleQueryDTO query, int pageIndex, int pageSize, params (string Field, bool IsAsc)[] sortFields)
        {
            Expression<Func<Article, bool>> exp = s => true;

            if (query.Category != null)
                exp = exp.And(s => s.Category == query.Category.Value);

            if (query.Tag != null)
                exp = exp.And(s => s.Tags.Contains(query.Tag.Value));

            var (Entities, Total) = await _store.PageQuery(exp, sortFields, pageIndex, pageSize);

            return Success((
                Entities.Select(_mapper.Map<ArticleListItemDTO>).ToList(),
                Total
                ));
        }
    }
}
