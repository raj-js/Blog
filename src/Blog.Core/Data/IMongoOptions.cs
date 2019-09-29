using MongoDB.Driver;

namespace Blog.Core.Data
{
    public interface IMongoOptions
    {
        MongoClientSettings ClientSettings { get; set; }

        MongoDatabaseSettings DatabaseSettings { get; set; }
    }
}
