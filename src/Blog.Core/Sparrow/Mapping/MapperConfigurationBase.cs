using AutoMapper;

namespace Blog.Core.Sparrow.Mapping
{
    public abstract class MapperConfigurationBase<TSrc, TDest> : IMapperConfiguration<TSrc, TDest>
    {
        public void Config(IMapperConfigurationExpression cfg)
        {
            MapSrc(cfg.CreateMap<TSrc, TDest>());
            MapDest(cfg.CreateMap<TDest, TSrc>());
        }

        public abstract void MapSrc(IMappingExpression<TSrc, TDest> expression);

        public abstract void MapDest(IMappingExpression<TDest, TSrc> expression);
    }
}
