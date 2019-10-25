using Autofac;

namespace Blog.Core.Services
{
    public static class ServiceExtensions
    {
        public static void RegisteAppServices(this ContainerBuilder builder)
        {
            builder.RegisterType<ArticleService>().AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType<CommentService>().AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
