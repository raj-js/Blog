using Autofac;
using Blog.Core.Sparrow.Stores;
using Blog.Stores.Mongo.IdGenerators;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using System;

namespace Blog.Stores.Mongo
{
    public static class MongoExtensions
    {
        public static void AddMongo(this ContainerBuilder builder, Action<MongoSettings> action)
        {
            BsonSerializer.RegisterIdGenerator(typeof(string), StringObjectIdGenerator.Instance);
            BsonSerializer.RegisterIdGenerator(typeof(Guid), CombGuidGenerator.Instance);
            BsonSerializer.RegisterIdGenerator(typeof(int), IntGenerator.Instance);
            BsonSerializer.RegisterIdGenerator(typeof(long), LongGenerator.Instance);

            var mongoAccessor = new MongoAccessor(action);
            builder.RegisterInstance(mongoAccessor).As<IMongoAccessor>().SingleInstance();

            builder.RegisterGeneric(typeof(MongoStore<,>)).As(typeof(ICreateStore<,>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(MongoStore<,>)).As(typeof(IRemoveStore<,>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(MongoStore<,>)).As(typeof(IUpdateStore<,>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(MongoStore<,>)).As(typeof(IQueryStore<,>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(MongoStore<,>)).As(typeof(ICURLStore<,>)).InstancePerLifetimeScope();
        }
    }
}
