using System;
using System.Threading.Tasks;
using AutoMapper;
using Blog.Core.DTOs;
using Blog.Core.Models;
using Blog.Core.Sparrow.Services;
using Blog.Core.Sparrow.Stores;

namespace Blog.Core.Services
{
    public class ArticleService : CURLService<Article, string, ArticleCreateDTO, ArticleUpdateDTO, ArticleDTO>, IArticleService
    {
        public ArticleService(IMapper mapper, ICURLStore<Article, string> store) :
            base(mapper, store)
        {

        }

        public async Task<ArticleDTO> CreateDraft(ArticleCreateDTO article)
        {
            var entity = ToEntity(article);
            entity.Reads = 0;
            entity.Likes = 0;
            entity.IsDraft = true;
            entity.IsDeleted = false;
            entity.Creation = DateTime.Now;
            entity.PublishTime = null;
            
            return ToDTO(await Store.CreateAsync(entity));
        }

        public async Task<ArticleDTO> Publish(string id)
        {
            var entity = await Store.FindAsync(id);

            if (entity == null)
                return null;

            if (entity.IsDraft)
            {
                entity.IsDraft = true;
                entity.PublishTime = DateTime.Now;

                entity = await Store.UpdateAsync(entity);
            }

            return ToDTO(entity);
        }
    }
}
