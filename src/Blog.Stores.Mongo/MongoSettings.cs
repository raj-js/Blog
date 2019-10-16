using MongoDB.Driver;

namespace Blog.Stores.Mongo
{
    public class MongoSettings
    {
        public MongoClientSettings ClientSettings { get; set; } = new MongoClientSettings();

        public string DatabaseName { get; set; }

        public MongoDatabaseSettings DatabaseSettings { get; set; } = new MongoDatabaseSettings();

        public MongoCollectionSettings CollectionSettings { get; set; } = new MongoCollectionSettings();
    }
}
