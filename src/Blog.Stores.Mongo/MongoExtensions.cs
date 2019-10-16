using Autofac;
using Blog.Core.Sparrow.Stores;
using System;

namespace Blog.Stores.Mongo
{
    public static class MongoExtensions
    {
        public static void AddMongo(this ContainerBuilder builder, Action<MongoSettings> action)
        {
            var mongoAccessor = new MongoAccessor(action);
            builder.RegisterInstance(mongoAccessor).As<IMongoAccessor>().SingleInstance();
            builder.RegisterGeneric(typeof(ICreateStore<,>)).As(typeof(MongoStore<,>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(IRemoveStore<,>)).As(typeof(MongoStore<,>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(IUpdateStore<,>)).As(typeof(MongoStore<,>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(IQueryStore<,>)).As(typeof(MongoStore<,>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(ICurlStore<,>)).As(typeof(MongoStore<,>)).InstancePerLifetimeScope();
        }
    }
}
