using Autofac;
using Blog.Core.Services;
using Blog.Core.Sparrow.Mapping;
using Blog.Core.Sparrow.Services;
using Blog.Core.Sparrow.Stores;
using Microsoft.AspNetCore.Builder;

namespace Blog.Core.Sparrow
{
    public static class Bootstrapper
    {
        public static void AddSparrow(this ContainerBuilder builder)
        {
            builder.RegisterType<ArticleService>().AsImplementedInterfaces().InstancePerLifetimeScope();

            //builder.RegisterGeneric(typeof(ICreateStore<,>)).AsImplementedInterfaces().InstancePerLifetimeScope();
            //builder.RegisterGeneric(typeof(IRemoveStore<,>)).AsImplementedInterfaces().InstancePerLifetimeScope();
            //builder.RegisterGeneric(typeof(IUpdateStore<,>)).AsImplementedInterfaces().InstancePerLifetimeScope();
            //builder.RegisterGeneric(typeof(IQueryStore<,>)).AsImplementedInterfaces().InstancePerLifetimeScope();
            //builder.RegisterGeneric(typeof(ICURLStore<,>)).AsImplementedInterfaces().InstancePerLifetimeScope();

            //builder.RegisterGeneric(typeof(ICreateService<,,,>)).AsImplementedInterfaces().InstancePerLifetimeScope();
            //builder.RegisterGeneric(typeof(IRemoveService<,>)).AsImplementedInterfaces().InstancePerLifetimeScope();
            //builder.RegisterGeneric(typeof(IUpdateService<,,,>)).AsImplementedInterfaces().InstancePerLifetimeScope();
            //builder.RegisterGeneric(typeof(IQueryService<,,>)).AsImplementedInterfaces().InstancePerLifetimeScope();
            //builder.RegisterGeneric(typeof(ICURLService<,,,,>)).AsImplementedInterfaces().InstancePerLifetimeScope();

            //builder.RegisterGeneric(typeof(IMapperConfiguration<,,,>)).AsImplementedInterfaces().InstancePerLifetimeScope();
        }

        public static void UseSparrow(this IApplicationBuilder app)
        {

        }
    }
}
