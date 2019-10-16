using AutoMapper;

namespace Blog.Core.Sparrow.Mapping
{
    public interface IMapperConfiguration<TSrc, TDest>
    {
        void Config(IMapperConfigurationExpression cfg);
    }
}
