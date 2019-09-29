using MongoDB.Driver;
using System;

namespace Blog.Core.Data
{
    public class MongoOptions : IMongoOptions
    {
        public MongoClientSettings ClientSettings { get; set; }
        public MongoDatabaseSettings DatabaseSettings { get; set; }

        public MongoOptions(
            Action<MongoClientSettings> clientSettings = null,
            Action<MongoDatabaseSettings> databaseSettings = null
            )
        {
            ClientSettings = new MongoClientSettings();
            DatabaseSettings = new MongoDatabaseSettings();

            clientSettings?.Invoke(ClientSettings);
            databaseSettings?.Invoke(DatabaseSettings);
        }
    }
}
