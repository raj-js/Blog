using Autofac;
using Blog.Core.Services;
using Blog.Core.Sparrow.Services;
using Microsoft.AspNetCore.Builder;

namespace Blog.Core.Sparrow
{
    public static class Bootstrapper
    {
        public static void AddSparrow(this ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(CURLService<,,,,>)).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterType<ArticleService>().AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType<CommentService>().AsImplementedInterfaces().InstancePerLifetimeScope();
        }

        public static void UseSparrow(this IApplicationBuilder app)
        {

        }
    }
}
