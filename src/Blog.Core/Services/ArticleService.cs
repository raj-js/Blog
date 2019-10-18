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

        //public Task<ArticleRespDto> CreateDraft(ArticleCreateReqDto article)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<ArticleRespDto> Publish(string id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
