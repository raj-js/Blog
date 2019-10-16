using AutoMapper;
using Blog.Core.Dtos;
using Blog.Core.Models;
using Blog.Core.Sparrow.Services;
using Blog.Core.Sparrow.Stores;

namespace Blog.Core.Services
{
    public class ArticleService : ServiceBase<Article, string, ArticleCreateReqDto, ArticleUpdateReqDto, ArticleRespDto>, IArticleService
    {
        public ArticleService(IMapper mapper, ICurlStore<Article, string> store) : 
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
