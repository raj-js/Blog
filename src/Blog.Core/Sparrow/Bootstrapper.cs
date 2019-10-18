using Autofac;
using Blog.Core.Services;
using Microsoft.AspNetCore.Builder;

namespace Blog.Core.Sparrow
{
    public static class Bootstrapper
    {
        public static void AddSparrow(this ContainerBuilder builder)
        {
            builder.RegisterType<ArticleService>().AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType<TagService>().AsImplementedInterfaces().InstancePerLifetimeScope();
        }

        public static void UseSparrow(this IApplicationBuilder app)
        {

        }
    }
}
