using Autofac;

namespace Blog.Core.Services
{
    public static class ServiceExtensions
    {
        public static void RegisteAppServices(this ContainerBuilder builder)
        {
            builder.RegisterType(typeof(ArticleService)).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType(typeof(CategoryService)).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType(typeof(CommentService)).AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
