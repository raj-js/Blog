using AutoMapper;
using Blog.Core.DTOs;
using Blog.Core.Models;
using Sparrow.Core.Mapping;
using Sparrow.Core.Mapping.Converters;

namespace Blog.Core.Mapping
{
    public class CategoryMapperConfiguration : MapperConfigurationBase<Category, CategoryCreateDTO, CategoryUpdateDTO, CategoryDTO>
    {
        public override void Config(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<CategoryCreateDTO, Category>()
               .ForMember(
                dst => dst.Cover,
                opt => opt.ConvertUsing(new FormFileConverter(), src => src.Cover)
               );

            cfg.CreateMap<CategoryUpdateDTO, Category>().ForMember(
                dst => dst.Cover,
                opt => opt.ConvertUsing(new FormFileConverter(), src => src.Cover)
               );
            cfg.CreateMap<Category, CategoryDTO>();
        }
    }
}
