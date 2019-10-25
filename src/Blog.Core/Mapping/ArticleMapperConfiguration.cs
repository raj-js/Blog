using AutoMapper;
using Blog.Core.DTOs;
using Blog.Core.Models;
using Sparrow.Core.Mapping;

namespace Blog.Core.Mapping
{
    public class ArticleMapperConfiguration : MapperConfigurationBase<Article, ArticleCreateDTO, ArticleUpdateDTO, ArticleListItemDTO, ArticleDTO>
    {
        public override void Config(IMapperConfigurationExpression cfg)
        {
            base.Config(cfg);
        }
    }
}
