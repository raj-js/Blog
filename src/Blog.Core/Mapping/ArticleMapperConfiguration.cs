using AutoMapper;
using Blog.Core.Models;
using Blog.Core.Sparrow.Mapping;

namespace Blog.Core.Mapping
{
    public class ArticleDTO
    {

    }

    public class ArticleMapperConfiguration : IMapperConfiguration<Article, ArticleDTO>
    {
        public void Config(IMapperConfigurationExpression cfg)
        {
            // cfg.CreateMap<Article, ArticleDTO>().ForMember()
        }
    }
}
