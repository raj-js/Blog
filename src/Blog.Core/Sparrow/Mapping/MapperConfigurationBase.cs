using AutoMapper;

namespace Blog.Core.Sparrow.Mapping
{
    public abstract class MapperConfigurationBase<TEntity, TCreateReqDto, TUpdateReqDto, TRespDto> : IMapperConfiguration<TEntity, TCreateReqDto, TUpdateReqDto, TRespDto>
    {
        public virtual void Config(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TCreateReqDto, TEntity>();
            cfg.CreateMap<TUpdateReqDto, TEntity>();
            cfg.CreateMap<TEntity, TRespDto>();
        }
    }
}
