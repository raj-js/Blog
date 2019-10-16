using MongoDB.Driver;

namespace Blog.Stores.Mongo
{
    public interface IMongoAccessor
    {
        MongoSettings Settings { get; }

        IMongoClient MongoClient { get; }

        IMongoDatabase DefaultDatabase { get; }

        IMongoDatabase GetDatabase(string database = null, MongoDatabaseSettings settings = null);

        IMongoCollection<TDocument> GetCollection<TDocument>(string collection, MongoCollectionSettings settings = null);
    }
}
