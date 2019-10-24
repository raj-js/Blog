using AutoMapper;
using Blog.Core.DTOs;
using Blog.Core.Models;
using Sparrow.Core.DTOs.Responses;
using Sparrow.Core.Services;
using Sparrow.Core.Stores;
using System;
using System.Threading.Tasks;
using static Sparrow.Core.DTOs.Responses.OpResponse;

namespace Blog.Core.Services
{
    public class ArticleService : AppServiceBase<Article, string, ArticleCreateDTO, ArticleUpdateDTO, ArticleDTO>, IArticleService
    {
        public ArticleService(IMapper mapper, ICURLStore<Article, string> store) :
            base(mapper, store)
        {

        }

        public async Task<OpResponse<ArticleDTO>> CreateDraft(ArticleCreateDTO article)
        {
            var entity = ToEntity(article);
            entity.Reads = 0;
            entity.Likes = 0;
            entity.IsDraft = true;
            entity.IsDeleted = false;
            entity.Creation = DateTime.Now;
            entity.PublishTime = null;
            
            return Success(ToDTO(await Store.CreateAsync(entity)));
        }

        public async Task<OpResponse<ArticleDTO>> Publish(string id)
        {
            var entity = await Store.FindAsync(id);

            if (entity == null)
                return Failure<ArticleDTO>();

            if (entity.IsDraft)
            {
                entity.IsDraft = true;
                entity.PublishTime = DateTime.Now;

                entity = await Store.UpdateAsync(entity);
            }

            return Success(ToDTO(entity));
        }
    }
}
