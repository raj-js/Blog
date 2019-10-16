using AutoMapper;

namespace Blog.Core.Sparrow.Mapping
{
    public interface IMapperConfiguration<TEntity, TCreateReqDto, TUpdateReqDto, TRespDto>
    {
        void Config(IMapperConfigurationExpression cfg);
    }
}
