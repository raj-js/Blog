using AutoMapper;
using Blog.Core.Dtos;
using Blog.Core.Models;
using Blog.Core.Sparrow.Mapping;

namespace Blog.Core.Mapping
{
    public class ArticleMapperConfiguration : MapperConfigurationBase<Article, ArticleCreateReqDto, ArticleUpdateReqDto, ArticleRespDto>, IMapperConfiguration<Article, ArticleCreateReqDto, ArticleUpdateReqDto, ArticleRespDto>
    {
        public override void Config(IMapperConfigurationExpression cfg)
        {
            base.Config(cfg);
        }
    }
}
